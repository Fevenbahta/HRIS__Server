

using ECX.HR.Application.CQRS.Attendance;
using ECX.HR.Application.CQRS.Attendance.Request.Command;
using ECX.HR.Application.CQRS.Attendance.Request.Queries;
using ECX.HR.Application.CQRS.Employee.Request.Command;
using ECX.HR.Application.DTOs.Employees;
using ECX.HR.Application.DTOs.Levels;
using ECX.HR.Application.Response;
using ECX.HR.Domain;
using ECX.HR.Persistence;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System.Data;
using System.Globalization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ECXHR_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceController : ControllerBase

    {
        private readonly IMediator _mediator;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ECXHRDbContext _context;

        public AttendanceController(IMediator mediator, IHttpContextAccessor httpContextAccessor, ECXHRDbContext context)
        {
            _mediator = mediator;
            this._httpContextAccessor = httpContextAccessor;
            _context = context;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }
        // GET: api/<LevelController>
        [HttpGet]
        public async Task<ActionResult<List<AttendanceDto>>> Get()
        {
            var Level = await _mediator.Send(new GetAttendanceListRequest());
            return Ok(Level);
        }

        // GET api/<LevelController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AttendanceDto>> Get(string id)
        {
            var Level = await _mediator.Send(new GetAttendanceDetailRequest { AttendanceId = id });
            return Ok(Level);
        }

        [HttpPost("import")]
        public async Task<IActionResult> ImportExcel([FromForm] IFormFile file)
        {
            if (file == null || file.Length <= 0)
            {
                return BadRequest("Invalid file");
            }

            try
            {
                var attendances = new List<Attendances>();


                using (var package = new ExcelPackage(file.OpenReadStream()))
                {
                    var worksheet = package.Workbook.Worksheets[0];
                    var rowCount = worksheet.Dimension.Rows;

                    for (int row = 2; row <= rowCount; row++) // Assuming the first row is header
                    {
                        double dd = double.Parse(worksheet.Cells[row, 6].Value.ToString());
                 var employee = _context.Employee.FirstOrDefault(e => e.AttendanceId == worksheet.Cells[row, 2].Value.ToString());
                   


                        var attendance = new Attendances
                        {
                            EmpId = employee?.EmpId ?? new Guid("b6692f64-7e87-4288-a493-ee2df975e5c9"),


                            TimeTable = worksheet.Cells[row, 7].Value.ToString(),


                            AttendanceId = worksheet.Cells[row, 2].Value.ToString(),
                            date = DateTime.FromOADate(dd).Date,

                            OnDuty = TimeSpan.Parse(worksheet.Cells[row, 8].Value?.ToString()),
                            OffDuty = TimeSpan.Parse(worksheet.Cells[row, 9].Value?.ToString()),
                            ClockIn = TimeSpan.Parse(worksheet.Cells[row, 10].Value?.ToString() ?? "0"),
                            ClockOut = TimeSpan.Parse(worksheet.Cells[row, 11].Value?.ToString() ?? "0"),
                            Normall = Convert.ToDecimal(worksheet.Cells[row, 12].Value?.ToString() ?? "0"),
                            RealTime = Convert.ToDecimal(worksheet.Cells[row, 13].Value?.ToString() ?? "0"),
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                            Department = worksheet.Cells[row, 22].Value.ToString(),

                            Late = TimeSpan.Parse(worksheet.Cells[row, 14].Value?.ToString() ?? "0"),
                            Status=0

                            // LeaveType = worksheet.Cells[row, 19].Value?.ToString(),




                        };

                        attendances.Add(attendance);
                    }
                }

                _context.Attendances.AddRange(attendances);
                await _context.SaveChangesAsync();

                return Ok(new { message = "Data imported successfully" });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Internal Server Error: {ex.Message}");
            }
        }

        

        [HttpPut("{id}")]


        public async Task<ActionResult> Put([FromBody] EmployeeDto Employee)
        {
            var command = new UpdateAttendanceEmployeeCommand { EmployeeDto = Employee };
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult> Delete(string id)
        {
            var command = new DeleteAttendanceCommand { AttendanceId = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
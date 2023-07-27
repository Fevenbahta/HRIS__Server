
using ECX.HR.Application.CQRS.Employee.Request.Command;
using ECX.HR.Application.CQRS.Employee.Request.Queries;
using ECX.HR.Application.DTOs.Employees;
using ECX.HR.Application.Response;

using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ECXHR_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase

    {
        private readonly IMediator _mediator;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public EmployeeController(IMediator mediator, IHttpContextAccessor httpContextAccessor)
        {
            _mediator = mediator;
            this._httpContextAccessor = httpContextAccessor;
        }
        // GET: api/<EmployeeController>
        [HttpGet]
        public async Task<ActionResult<List<EmployeeDto>>> Get()
        {
            var Employee = await _mediator.Send(new GetEmployeeListRequest());
            return Ok(Employee);
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeDto>> Get(Guid id)
        {
            var Employee = await _mediator.Send(new GetEmployeeDetailRequest { EmpId = id });
            return Ok(Employee);
        }

        // POST api/<EmployeeController>
        [HttpPost]

        public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] EmployeeDto Employee)
        {
            var user = _httpContextAccessor.HttpContext.User;
            
            var command = new CreateEmployeeCommand { EmployeeDto = Employee };
            
            var response = await _mediator.Send(command);
          
            return Ok(response.Id);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]


        public async Task<ActionResult> Put([FromBody] EmployeeDto Employee)
        {
            var command = new UpdateEmployeeCommand { EmployeeDto = Employee };
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult> Delete(Guid id)
        {
            var command = new DeleteEmployeeCommand { EmpId = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
﻿

using ECX.HR.Application.CQRS.LeaveRequest.Handler.Command;
using ECX.HR.Application.CQRS.LeaveRequest.Request.Command;
using ECX.HR.Application.CQRS.LeaveRequest.Request.Queries;
using ECX.HR.Application.DTOs.Leave;

using ECX.HR.Application.Response;

using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ECXHR_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveRequestController : ControllerBase

    {
        private readonly IMediator _mediator;
        private readonly IHttpContextAccessor _httpContextAccessor;


        public LeaveRequestController(IMediator mediator, IHttpContextAccessor httpContextAccessor)
        {
            _mediator = mediator;
            this._httpContextAccessor = httpContextAccessor;
        }
        // GET: api/<AddressController>
        [HttpGet]
        public async Task<ActionResult<List<LeaveRequestDto>>> Get()
        {
            var LeaveRequest = await _mediator.Send(new GetLeaveRequestListCommand());
            return Ok(LeaveRequest);
        }


        [HttpGet("empId/{Empid}")]
        public async Task<ActionResult<LeaveRequestDto>> GetByEmpId(Guid Empid)
        {
            var LeaveRequest = await _mediator.Send(new GetLeaveRequestByIdCommand { EmpId = Empid });
            return Ok(LeaveRequest);
        }
        [HttpGet("status/{LeaveStatus}/{Supervisor}")]
        public async Task<ActionResult<LeaveRequestDto>> GetByStatus(string LeaveStatus, string Supervisor)
        {
            var LeaveRequest = await _mediator.Send(new GetLeaveRequestStatusByIdCommand { LeaveStatus = LeaveStatus , Supervisor = Supervisor }) ;
            return Ok(LeaveRequest);
        }
        [HttpGet("status/{LeaveStatus}")]
        public async Task<ActionResult<LeaveRequestDto>> GetAllByStatus(string LeaveStatus)
        {
            var LeaveRequest = await _mediator.Send(new GetLeaveRequestAllStatusCommand { LeaveStatus = LeaveStatus });
            return Ok(LeaveRequest);
        }
        // 
        // POST api/<AddressController>
        [HttpPost]
        public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] LeaveRequestDto leaveRequestDto)
        {
            var user = _httpContextAccessor.HttpContext.User;


            var command = new CreateLeaveRequestCommand { LeaveRequestDto = leaveRequestDto };
            var response = await _mediator.Send(command);
            return Ok(response);
        }


        // PUT api/<AddressController>/5
        [HttpPut("{id}")]

        public async Task<ActionResult> Put([FromBody] LeaveRequestDto LeaveRequest)
        {
            var command = new UpdateLeaveRequestCommand { LeaveRequestDto = LeaveRequest };
            //_context.Entry(existingEvent).Property(x => x.ReferenceNumber).IsModified = false;
            await _mediator.Send(command);

            return NoContent();
        }
        // PUT: api/LeaveRequest/UpdateStatus/5
       


        [HttpGet("{fileId}")]
        public async Task<IActionResult> GetFile(Guid fileId)
        {


            var fileData = await _mediator.Send(new GetFileRequestCommand(fileId));

            if (fileData == null)
            {
                return NotFound(); // File not found
            }

            // Determine the file's content type (e.g., application/pdf, image/jpeg, etc.)
            string contentType = "application/pdf"; // Set a default content type
            Response.Headers.Add("contentType", "application/pdf");
            // You can set the content type based on the file's type or extension
            // Example: if (fileExtension == ".pdf") contentType = "application/pdf";

            // Return the file as a downloadable attachment
            return File(fileData, contentType);
        }


        [HttpDelete("{id}")]

        public async Task<ActionResult> Delete(Guid id)
        {
            var command = new DeleteLeaveRequestCommand { leaveRequestId = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
﻿

using ECX.HR.Application.CQRS.LeaveBalance.Request.Command;
using ECX.HR.Application.CQRS.LeaveBalance.Request.Queries;
using ECX.HR.Application.DTOs.LeaveBalance;
using ECX.HR.Application.Response;

using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ECXHR_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveBalanceController : ControllerBase

    {
        private readonly IMediator _mediator;
        private readonly IHttpContextAccessor _httpContextAccessor;


        public LeaveBalanceController(IMediator mediator, IHttpContextAccessor httpContextAccessor)
        {
            _mediator = mediator;
            this._httpContextAccessor = httpContextAccessor;
        }
        // GET: api/<AddressController>
        [HttpGet]
        public async Task<ActionResult<List<LeaveBalanceDto>>> Get()
        {
            var leaveBalance = await _mediator.Send(new GetLeaveBalanceListRequest());
            return Ok(leaveBalance);
        }

 /*       [HttpGet("{Empid}")]
        public async Task<ActionResult<EmployeeDto>> GetByEmpId(Guid Empid)
        {
            var address = await _mediator.Send(new GetAddressDetailRequest { EmpId = Empid });
            return Ok(address);
        }*/
        // POST api/<AddressController>
        [HttpPost]
        public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] LeaveBalanceDto leaveBalance)
        {
            var user = _httpContextAccessor.HttpContext.User;
            var command = new CreateLeaveBalanceCommand { LeaveBalanceDto = leaveBalance };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<AddressController>/5
        [HttpPut("{id}")]

        public async Task<ActionResult> Put([FromBody] LeaveBalanceDto leaveBalance)
        {
            var command = new UpdateLeaveBalanceCommand { LeaveBalanceDto = leaveBalance };
            //_context.Entry(existingEvent).Property(x => x.ReferenceNumber).IsModified = false;
            await _mediator.Send(command);
            
            return NoContent();
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult> Delete(Guid id)
        {
            var command = new DeleteLeaveBalanceCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
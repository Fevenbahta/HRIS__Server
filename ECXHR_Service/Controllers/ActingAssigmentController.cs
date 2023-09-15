using ECX.HR.Application.CQRS.ActingAssigment.Request.Command;
using ECX.HR.Application.CQRS.ActingAssigment.Request.Queries;
using ECX.HR.Application.CQRS.Allowance.Request.Command;
using ECX.HR.Application.CQRS.Allowance.Request.Queries;
using ECX.HR.Application.CQRS.Allowances.Request.Command;
using ECX.HR.Application.DTOs.ActingAssigment;
using ECX.HR.Application.DTOs.Allowances.cs;
using ECX.HR.Application.Response;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECXHR_Service.Controllers
{
    public class ActingAssigmentController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public ActingAssigmentController(IMediator mediator, IHttpContextAccessor httpContextAccessor)
        {
            _mediator = mediator;
            this._httpContextAccessor = httpContextAccessor;
        }
        // GET: api/<AllowanceController>
        [HttpGet]
        public async Task<ActionResult<List<ActingAssigmentDto>>> Get()
        {
            var Accting = await _mediator.Send(new GetAcctingAssigmentListRequest());
            return Ok(Accting);
        }

        // GET api/<AllowanceController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ActingAssigmentDto>> Get(Guid id)
        {
            var Acting = await _mediator.Send(new GetAllowanceDetailRequest { Id = id });
            return Ok(Acting);
        }

        // POST api/<AllowanceController>
        [HttpPost]

        public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] ActingAssigmentDto actingAssigment)
        {
            var user = _httpContextAccessor.HttpContext.User;
            var command = new CreateActingAssigmentCommand { ActingAssigmentDto = actingAssigment };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<AllowanceController>/5
        [HttpPut("{id}")]


        public async Task<ActionResult> Put([FromBody] ActingAssigmentDto actingAssigmentDto)
        {
            var command = new UpdateActingAssigment { ActingAssigmentDto = actingAssigmentDto };
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult> Delete(Guid id)
        {
            var command = new DeleteAllowanceCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}

using ECX.HR.Application.DTOs.EducationLevel;
using ECX.HR.Application.Features.Address.Request.Command;
using ECX.HR.Application.Features.Address.Request.Queries;
using ECX.HR.Application.Response;
using HRMsystem.Application.Features.Address.Request.Command;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ECXHR_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationLevelController : ControllerBase

    {
        private readonly IMediator _mediator;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public EducationLevelController(IMediator mediator, IHttpContextAccessor httpContextAccessor)
        {
            _mediator = mediator;
            this._httpContextAccessor = httpContextAccessor;
        }
        // GET: api/<EducationLevelController>
        [HttpGet]
        public async Task<ActionResult<List<EducationLevelDto>>> Get()
        {
            var EducationLevel = await _mediator.Send(new GetEducationLevelRequest());
            return Ok(EducationLevel);
        }

        // GET api/<EducationLevelController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EducationLevelDto>> Get(int id)
        {
            var EducationLevel = await _mediator.Send(new GetEducationLevelDetailRequest { Id = id });
            return Ok(EducationLevel);
        }

        // POST api/<EducationLevelController>
        [HttpPost]

        public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] EducationLevelDto EducationLevel)
        {
            var user = _httpContextAccessor.HttpContext.User;
            var command = new CreateEducationLevelCommand { EducationLevelDto = EducationLevel };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<EducationLevelController>/5
        [HttpPut("{id}")]


        public async Task<ActionResult> Put([FromBody] EducationLevelDto EducationLevel)
        {
            var command = new UpdateEducationLevelCommand { EducationLevelDto = EducationLevel };
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteEducationLevelCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
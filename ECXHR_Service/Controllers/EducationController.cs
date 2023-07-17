﻿
using ECX.HR.Application.CQRS.Education.Request.Command;
using ECX.HR.Application.CQRS.Education.Request.Queries;
using ECX.HR.Application.DTOs.Education;

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
    public class EducationController : ControllerBase

    {
        private readonly IMediator _mediator;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public EducationController(IMediator mediator, IHttpContextAccessor httpContextAccessor)
        {
            _mediator = mediator;
            this._httpContextAccessor = httpContextAccessor;
        }
        // GET: api/<EducationController>
        [HttpGet]
        public async Task<ActionResult<List<EducationDto>>> Get()
        {
            var Education = await _mediator.Send(new GetEducationListRequest());
            return Ok(Education);
        }

        // GET api/<EducationController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EducationDto>> Get(Guid id)
        {
            var Education = await _mediator.Send(new GetEducationDetailRequest { Id = id });
            return Ok(Education);
        }

        // POST api/<EducationController>
        [HttpPost]

        public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] EducationDto Education)
        {
            var user = _httpContextAccessor.HttpContext.User;
            var command = new CreateEducationCommand { EducationDto = Education };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<EducationController>/5
        [HttpPut("{id}")]


        public async Task<ActionResult> Put([FromBody] EducationDto Education)
        {
            var command = new UpdateEducationCommand { EducationDto = Education };
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult> Delete(Guid id)
        {
            var command = new DeleteEducationCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
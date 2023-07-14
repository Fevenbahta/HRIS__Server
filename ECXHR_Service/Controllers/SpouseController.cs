﻿
using ECX.HR.Application.DTOs.Spouse;
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
    public class SpouseController : ControllerBase

    {
        private readonly IMediator _mediator;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public SpouseController(IMediator mediator, IHttpContextAccessor httpContextAccessor)
        {
            _mediator = mediator;
            this._httpContextAccessor = httpContextAccessor;
        }
        // GET: api/<SpouseController>
        [HttpGet]
        public async Task<ActionResult<List<SpouseDto>>> Get()
        {
            var Spouse = await _mediator.Send(new GetSpouseRequest());
            return Ok(Spouse);
        }

        // GET api/<SpouseController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SpouseDto>> Get(int id)
        {
            var Spouse = await _mediator.Send(new GetSpouseDetailRequest { Id = id });
            return Ok(Spouse);
        }

        // POST api/<SpouseController>
        [HttpPost]

        public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] SpouseDto Spouse)
        {
            var user = _httpContextAccessor.HttpContext.User;
            var command = new CreateSpouseCommand { SpouseDto = Spouse };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<SpouseController>/5
        [HttpPut("{id}")]


        public async Task<ActionResult> Put([FromBody] SpouseDto Spouse)
        {
            var command = new UpdateSpouseCommand { SpouseDto = Spouse };
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteSpouseCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
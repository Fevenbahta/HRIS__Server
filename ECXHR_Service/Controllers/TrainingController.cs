
using ECX.HR.Application.DTOs.Training﻿﻿;
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
    public class Training﻿﻿Controller : ControllerBase

    {
        private readonly IMediator _mediator;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public Training﻿﻿Controller(IMediator mediator, IHttpContextAccessor httpContextAccessor)
        {
            _mediator = mediator;
            this._httpContextAccessor = httpContextAccessor;
        }
        // GET: api/<Training﻿﻿Controller>
        [HttpGet]
        public async Task<ActionResult<List<Training﻿﻿Dto>>> Get()
        {
            var Training﻿﻿ = await _mediator.Send(new GetTraining﻿﻿Request());
            return Ok(Training﻿﻿);
        }

        // GET api/<Training﻿﻿Controller>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Training﻿﻿Dto>> Get(int id)
        {
            var Training﻿﻿ = await _mediator.Send(new GetTraining﻿﻿DetailRequest { Id = id });
            return Ok(Training﻿﻿);
        }

        // POST api/<Training﻿﻿Controller>
        [HttpPost]

        public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] Training﻿﻿Dto Training﻿﻿)
        {
            var user = _httpContextAccessor.HttpContext.User;
            var command = new CreateTraining﻿﻿Command { Training﻿﻿Dto = Training﻿﻿ };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<Training﻿﻿Controller>/5
        [HttpPut("{id}")]


        public async Task<ActionResult> Put([FromBody] Training﻿﻿Dto Training﻿﻿)
        {
            var command = new UpdateTraining﻿﻿Command { Training﻿﻿Dto = Training﻿﻿ };
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteTraining﻿﻿Command { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
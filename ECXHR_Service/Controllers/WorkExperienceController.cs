

using ECX.HR.Application.CQRS.WorkExperience.Request.Command;
using ECX.HR.Application.CQRS.WorkExperience.Request.Queries;
using ECX.HR.Application.DTOs.WorkExperiences;
using ECX.HR.Application.Response;
using ECX.HR.Persistence;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ECXHR_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkExperience﻿﻿Controller : ControllerBase

    {
        private readonly IMediator _mediator;
        private readonly IHttpContextAccessor _httpContextAccessor;
       

        public WorkExperience﻿﻿Controller(IMediator mediator, IHttpContextAccessor httpContextAccessor)
        {
            _mediator = mediator;
            this._httpContextAccessor = httpContextAccessor;
            
        }
        // GET: api/<WorkExperience﻿﻿Controller>
        [HttpGet]
        public async Task<ActionResult<List<WorkExperience﻿﻿Dto>>> Get()
        {
            var WorkExperience﻿﻿ = await _mediator.Send(new GetWorkExperience﻿﻿ListRequest());
            return Ok(WorkExperience﻿﻿);
        }

        // GET api/<WorkExperience﻿﻿Controller>/5
       
        // POST api/<WorkExperience﻿﻿Controller>
        [HttpPost]

        public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] WorkExperience﻿﻿Dto WorkExperience﻿﻿)
        {
            var user = _httpContextAccessor.HttpContext.User;
            var command = new CreateWorkExperience﻿﻿Command { WorkExperience﻿﻿Dto = WorkExperience﻿﻿ };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<WorkExperience﻿﻿Controller>/5
        [HttpPut("{id}")]


        public async Task<ActionResult> Put([FromBody] WorkExperience﻿﻿Dto WorkExperience﻿﻿)
        {
            var command = new UpdateWorkExperience﻿﻿Command { WorkExperience﻿﻿Dto = WorkExperience﻿﻿ };
            await _mediator.Send(command);
            return NoContent();
        }
 

        [HttpDelete("{id}")]

        public async Task<ActionResult> Delete(Guid id)
        {
            var command = new DeleteWorkExperience﻿﻿Command { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
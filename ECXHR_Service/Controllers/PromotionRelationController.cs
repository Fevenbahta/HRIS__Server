﻿
using ECX.HR.Application.CQRS.PromotionRelation.Request.Command;
using ECX.HR.Application.CQRS.PromotionRelation.Request.Queries;
using ECX.HR.Application.CQRS.PromotionRelation.Request.Command;
using ECX.HR.Application.CQRS.PromotionRelation.Request.Queries;
using ECX.HR.Application.DTOs.PromotionRelation;
using ECX.HR.Application.DTOs.PromotionRelation;


using ECX.HR.Application.Response;
//using HRMsystem.Application.Features.Address.Request.Command;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using ECX.HR.Application.CQRS.LeaveRequest.Request.Queries;
using ECX.HR.Application.DTOs.Leave;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ECXHR_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromotionRelationController : ControllerBase

    {
        private readonly IMediator _mediator;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public PromotionRelationController(IMediator mediator, IHttpContextAccessor httpContextAccessor)
        {
            _mediator = mediator;
            this._httpContextAccessor = httpContextAccessor;
        }

        [HttpGet("status/{PromotionStatus}")]
        public async Task<ActionResult<PromotionRelationDto>> GetByStatus(string PromotionStatus)
        {
            var PromotionRelation = await _mediator.Send(new GetPromotionRelationStatusByIdCommand { PromotionStatus = PromotionStatus });
            return Ok(PromotionRelation);
        }

        // GET: api/<PromotionRelationController>
        [HttpGet]
        public async Task<ActionResult<List<PromotionRelationDto>>> Get()
        {
            var PromotionRelation = await _mediator.Send(new GetPromotionRelationListRequest());
            return Ok(PromotionRelation);
        }

        // GET api/<PromotionRelationController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PromotionRelationDto>> Get(Guid id)
        {
            var PromotionRelation = await _mediator.Send(new GetPromotionRelationDetailRequest { empId = id });
            return Ok(PromotionRelation);
        }

        // POST api/<PromotionRelationController>
        [HttpPost]

        public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] PromotionRelationDto PromotionRelation)
        {
            var user = _httpContextAccessor.HttpContext.User;
            var command = new CreatePromotionRelationCommand { PromotionRelationDto = PromotionRelation };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<PromotionRelationController>/5
        [HttpPut("{id}")]


        public async Task<ActionResult> Put([FromBody] PromotionRelationDto PromotionRelation)
        {
            var command = new UpdatePromotionRelationCommand { PromotionRelationDto = PromotionRelation };
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult> Delete(Guid id)
        {
            var command = new DeletePromotionRelationCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
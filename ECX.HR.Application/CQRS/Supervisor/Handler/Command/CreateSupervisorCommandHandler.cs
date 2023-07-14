﻿using AutoMapper;
using ECX.HR.Application.Contracts.Persistent;
using ECX.HR.Application.CQRS.Supervisor.Request.Command;
using ECX.HR.Application.DTOs.Supervisor;
using ECX.HR.Application.DTOs.Supervisor.Validators;
using ECX.HR.Application.Exceptions;

using ECX.HR.Application.Response;
using ECX.HR.Domain;
using MediatR;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.Supervisor.Handler.Command
{
    public class CreateSupervisorCommandHandler : IRequestHandler<CreateSupervisorCommand, BaseCommandResponse>
    {
        BaseCommandResponse response;
        private ISupervisorRepository _SupervisorRepository;
        private IMapper _mapper;
        public CreateSupervisorCommandHandler(ISupervisorRepository SupervisorRepository, IMapper mapper)
        {
            _SupervisorRepository = SupervisorRepository;
            _mapper = mapper;
        }
        public async Task<BaseCommandResponse> Handle(CreateSupervisorCommand request, CancellationToken cancellationToken)
        {
            response = new BaseCommandResponse();
            var validator =new SupervisorDtoValidator();
            var validationResult =await validator.ValidateAsync(request.SupervisorDto);
            
            if(validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Creation Faild";
                response.Errors= validationResult.Errors.Select(x => x.ErrorMessage).ToList();
            }
           
            var Supervisor = _mapper.Map<Supervisor>(request.SupervisorDto);
            var data =await _SupervisorRepository.Add(Supervisor);
            response.Success = true;
            response.Message = "Creation Successfull";
            return response;
        }
    }
}
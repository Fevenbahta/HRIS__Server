﻿using AutoMapper;
using ECX.HR.Application.Contracts.Persistent;
using ECX.HR.Application.CQRS.Education.Request.Command;
using ECX.HR.Application.DTOs.Education;
using ECX.HR.Application.DTOs.Education.Validators;
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

namespace ECX.HR.Application.CQRS.Education.Handler.Command
{
    public class CreateEducationCommandHandler : IRequestHandler<CreateEducationCommand, BaseCommandResponse>
    {
        BaseCommandResponse response;
        private IEducationRepository _EducationRepository;
        private IMapper _mapper;
        public CreateEducationCommandHandler(IEducationRepository EducationRepository, IMapper mapper)
        {
            _EducationRepository = EducationRepository;
            _mapper = mapper;
        }
        public async Task<BaseCommandResponse> Handle(CreateEducationCommand request, CancellationToken cancellationToken)
        {
            response = new BaseCommandResponse();
            var validator =new EducationDtoValidator();
            var validationResult =await validator.ValidateAsync(request.EducationDto);
            
            if(validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Creation Faild";
                response.Errors= validationResult.Errors.Select(x => x.ErrorMessage).ToList();
            }
           
            var Education = _mapper.Map<Education>(request.EducationDto);
            var data =await _EducationRepository.Add(Education);
            response.Success = true;
            response.Message = "Creation Successfull";
            return response;
        }
    }
}

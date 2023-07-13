using AutoMapper;
using ECX.HR.Application.Contracts.Persistent;
using ECX.HR.Application.CQRS.EmployeePosition.Request.Command;
using ECX.HR.Application.DTOs.EmployeePosition;
using ECX.HR.Application.DTOs.EmployeePosition.Validators;
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

namespace ECX.HR.Application.CQRS.EmployeePosition.Handler.Command
{
    public class CreateEmployeePositionCommandHandler : IRequestHandler<CreateEmployeePositionCommand, BaseCommandResponse>
    {
        BaseCommandResponse response;
        private IEmployeePositionRepository _EmployeePositionRepository;
        private IMapper _mapper;
        public CreateEmployeePositionCommandHandler(IEmployeePositionRepository EmployeePositionRepository, IMapper mapper)
        {
            _EmployeePositionRepository = EmployeePositionRepository;
            _mapper = mapper;
        }
        public async Task<BaseCommandResponse> Handle(CreateEmployeePositionCommand request, CancellationToken cancellationToken)
        {
            response = new BaseCommandResponse();
            var validator =new EmployeePositionDtoValidator();
            var validationResult =await validator.ValidateAsync(request.EmployeePositionDto);
            
            if(validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Creation Faild";
                response.Errors= validationResult.Errors.Select(x => x.ErrorMessage).ToList();
            }
           
            var EmployeePosition = _mapper.Map<EmployeePosition>(request.EmployeePositionDto);
            var data =await _EmployeePositionRepository.Add(EmployeePosition);
            response.Success = true;
            response.Message = "Creation Successfull";
            return response;
        }
    }
}

using AutoMapper;
using ECX.HR.Application.Contracts.Persistent;
using ECX.HR.Application.CQRS.Allowance.Request.Command;
using ECX.HR.Application.DTOs.Allowance;
using ECX.HR.Application.DTOs.Allowance.Validators;
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

namespace ECX.HR.Application.CQRS.Allowances.Handler.Command
{
    public class CreateAllowanceCommandHandler : IRequestHandler<CreateAllowanceCommand, BaseCommandResponse>
    {
        BaseCommandResponse response;
        private IAllowanceRepository _AllowanceRepository;
        private IMapper _mapper;
        public CreateAllowanceCommandHandler(IAllowanceRepository AllowanceRepository, IMapper mapper)
        {
            _AllowanceRepository = AllowanceRepository;
            _mapper = mapper;
        }
        public async Task<BaseCommandResponse> Handle(CreateAllowanceCommand request, CancellationToken cancellationToken)
        {
            response = new BaseCommandResponse();
            var validator =new AllowanceDtoValidator();
            var validationResult =await validator.ValidateAsync(request.AllowanceDto);
            
            if(validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Creation Faild";
                response.Errors= validationResult.Errors.Select(x => x.ErrorMessage).ToList();
            }
           
            var Allowance = _mapper.Map<Allowance>(request.AllowanceDto);
            var data =await _AllowanceRepository.Add(Allowance);
            response.Success = true;
            response.Message = "Creation Successfull";
            return response;
        }
    }
}

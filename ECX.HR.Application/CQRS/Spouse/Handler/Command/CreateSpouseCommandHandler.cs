using AutoMapper;
using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Application.Contracts.Persistent;
using ECX.HR.Application.CQRS.Spouse.Request.Command;
using ECX.HR.Application.DTOs.Spouses.Validator;
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

namespace ECX.HR.Application.CQRS.Spouse.Handler.Command
{
    public class CreateSpouseCommandHandler : IRequestHandler<CreateSpouseCommand, BaseCommandResponse>
    {
        BaseCommandResponse response;
        private ISpouseRepository _SpouseRepository;
        private IMapper _mapper;
        public CreateSpouseCommandHandler(ISpouseRepository SpouseRepository, IMapper mapper)
        {
            _SpouseRepository = SpouseRepository;
            _mapper = mapper;
        }
        public async Task<BaseCommandResponse> Handle(CreateSpouseCommand request, CancellationToken cancellationToken)
        {
            response = new BaseCommandResponse();
            var validator =new SpouseValidator();
            var validationResult =await validator.ValidateAsync(request.SpouseDto);
            
            if(validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Creation Faild";
                response.Errors= validationResult.Errors.Select(x => x.ErrorMessage).ToList();
            }
           
            var spouse = _mapper.Map<Spouses>(request.SpouseDto);
            spouse.Id = Guid.NewGuid();
            var data =await _SpouseRepository.Add(spouse);
            response.Success = true;
            response.Message = "Creation Successfull";
            return response;
        }
    }
}

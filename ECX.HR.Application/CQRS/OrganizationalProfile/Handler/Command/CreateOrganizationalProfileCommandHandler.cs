using AutoMapper;
using ECX.HR.Application.Contracts.Persistent;
using ECX.HR.Application.CQRS.OrganizationalProfile.Request.Command;
using ECX.HR.Application.DTOs.OrganizationalProfile;
using ECX.HR.Application.DTOs.OrganizationalProfile.Validators;
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

namespace ECX.HR.Application.CQRS.OrganizationalProfile.Handler.Command
{
    public class CreateOrganizationalProfileCommandHandler : IRequestHandler<CreateOrganizationalProfileCommand, BaseCommandResponse>
    {
        BaseCommandResponse response;
        private IOrganizationalProfileRepository _OrganizationalProfileRepository;
        private IMapper _mapper;
        public CreateOrganizationalProfileCommandHandler(IOrganizationalProfileRepository OrganizationalProfileRepository, IMapper mapper)
        {
            _OrganizationalProfileRepository = OrganizationalProfileRepository;
            _mapper = mapper;
        }
        public async Task<BaseCommandResponse> Handle(CreateOrganizationalProfileCommand request, CancellationToken cancellationToken)
        {
            response = new BaseCommandResponse();
            var validator =new OrganizationalProfileDtoValidator();
            var validationResult =await validator.ValidateAsync(request.OrganizationalProfileDto);
            
            if(validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Creation Faild";
                response.Errors= validationResult.Errors.Select(x => x.ErrorMessage).ToList();
            }
           
            var OrganizationalProfile = _mapper.Map<OrganizationalProfile>(request.OrganizationalProfileDto);
            var data =await _OrganizationalProfileRepository.Add(OrganizationalProfile);
            response.Success = true;
            response.Message = "Creation Successfull";
            return response;
        }
    }
}

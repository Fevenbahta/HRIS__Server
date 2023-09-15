using AutoMapper;
using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Application.CQRS.ActingAssigment.Request.Command;
using ECX.HR.Application.DTOs.ActingAssigment;
using ECX.HR.Application.DTOs.ActingAssigment.Validator;
using ECX.HR.Application.DTOs.Address.Validator;
using ECX.HR.Application.Response;
using ECX.HR.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.ActingAssigment.Handler.Command
{
    public class CreateActingAssigmentCommandHandler : IRequestHandler<CreateActingAssigmentCommand, BaseCommandResponse>
    {
        BaseCommandResponse response;
        private readonly IActingAssigmentRepository _actingAssigmentRepository;
        private readonly IMapper _mapper;

        public CreateActingAssigmentCommandHandler(IActingAssigmentRepository actingAssigmentRepository, IMapper Mapper)
        {
           
            _actingAssigmentRepository = actingAssigmentRepository;
            _mapper = Mapper;
        }
        public async Task<BaseCommandResponse> Handle(CreateActingAssigmentCommand request, CancellationToken cancellationToken)
        {
            response = new BaseCommandResponse();
            var validator = new ActingAssigmentDtoValidator();
            var validationResult = await validator.ValidateAsync(request.ActingAssigmentDto);

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Creation Faild";
                response.Errors = validationResult.Errors.Select(x => x.ErrorMessage).ToList();
            }

            var Acting = _mapper.Map<ActingAssigments>(request.ActingAssigmentDto);
            Acting.Id = Guid.NewGuid();
            var acct = Acting.Id;
            var data = await _actingAssigmentRepository.Add(Acting);
            response.Success = true;
            response.Message = "Creation Successfull";
            response.Id = (Guid)acct;
            return response;
        }
    }
}

using AutoMapper;
using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Application.CQRS.ActingAssigment.Request.Command;
using ECX.HR.Application.DTOs.ActingAssigment.Validator;
using ECX.HR.Application.DTOs.Address.Validator;
using ECX.HR.Application.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.ActingAssigment.Handler.Command
{
    public class UpdateAcctingAssigmentCommandHandler : IRequestHandler<UpdateActingAssigment, Unit>
    {
        private readonly IActingAssigmentRepository _actingAssigmentRepository;
        private readonly IMapper _mapper;

        public UpdateAcctingAssigmentCommandHandler(IActingAssigmentRepository actingAssigmentRepository, IMapper mapper)
        {
            _actingAssigmentRepository = actingAssigmentRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateActingAssigment request, CancellationToken cancellationToken)
        {
            var validator = new ActingAssigmentDtoValidator();
            var validationResult = await validator.ValidateAsync(request.ActingAssigmentDto);
            if (validationResult.IsValid == false)
                throw new ValidationException(validationResult);

            request.ActingAssigmentDto.UpdatedDate = DateTime.Now;
            var act = await _actingAssigmentRepository.GetById(request.ActingAssigmentDto.Id);



            _mapper.Map(request.ActingAssigmentDto, act);

            await _actingAssigmentRepository.Update(act);
            return Unit.Value;
        }
    }
}

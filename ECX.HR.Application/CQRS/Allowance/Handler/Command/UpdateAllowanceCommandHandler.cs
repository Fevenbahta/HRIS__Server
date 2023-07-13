using AutoMapper;
using ECX.HR.Application.Contracts.Persistent;
using ECX.HR.Application.CQRS.Allowance.Request.Command;
using ECX.HR.Application.DTOs.Allowance.Validators;
using ECX.HR.Application.Exceptions;

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.Allowance.Handler.Command
{
    public class UpdateAllowanceCommandHandler : IRequestHandler<UpdateAllowanceCommand, Unit>
    {
        private IAllowanceRepository _AllowanceRepository;
        private IMapper _mapper;
        public UpdateAllowanceCommandHandler(IAllowanceRepository AllowanceRepository, IMapper mapper)
        {
            _AllowanceRepository = AllowanceRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateAllowanceCommand request, CancellationToken cancellationToken)
        {
            var validator = new AllowanceDtoValidator();
            var validationResult = await validator.ValidateAsync(request.AllowanceDto);
            if (validationResult.IsValid == false)
                throw new ValidationException(validationResult);
            var Allowance = await _AllowanceRepository.GetById(request.AllowanceDto.Id);
            _mapper.Map(request.AllowanceDto, Allowance);
            await _AllowanceRepository.Update(Allowance);
            return Unit.Value;
        }
    }
}

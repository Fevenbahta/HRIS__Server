using AutoMapper;
using ECX.HR.Application.Contracts.Persistent;
using ECX.HR.Application.CQRS.Branch.Request.Command;
using ECX.HR.Application.DTOs.Branch.Validators;
using ECX.HR.Application.Exceptions;

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.Branch.Handler.Command
{
    public class UpdateBranchCommandHandler : IRequestHandler<UpdateBranchCommand, Unit>
    {
        private IBranchRepository _BranchRepository;
        private IMapper _mapper;
        public UpdateBranchCommandHandler(IBranchRepository BranchRepository, IMapper mapper)
        {
            _BranchRepository = BranchRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateBranchCommand request, CancellationToken cancellationToken)
        {
            var validator = new BranchDtoValidator();
            var validationResult = await validator.ValidateAsync(request.BranchDto);
            if (validationResult.IsValid == false)
                throw new ValidationException(validationResult);
            var Branch = await _BranchRepository.GetById(request.BranchDto.Id);
            _mapper.Map(request.BranchDto, Branch);
            await _BranchRepository.Update(Branch);
            return Unit.Value;
        }
    }
}

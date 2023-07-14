using AutoMapper;
using ECX.HR.Application.CQRS.Allowance.Request.Command;
using ECX.HR.Application.Exceptions;
using ECX.HR.Application.Contracts.Persistent;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECX.HR.Application.CQRS.Allowances.Request.Command;
using ECX.HR.Application.Contracts.Persistence;

namespace ECX.HR.Application.CQRS.Allowance.Handler.Command
{
    public class DeleteAllowanceCommandHandler : IRequestHandler<DeleteAllowanceCommand>
    {
        private IAllwoanceRepository _AllowanceRepository;
        private IMapper _mapper;
        public DeleteAllowanceCommandHandler(IAllwoanceRepository AllowanceRepository, IMapper mapper)
        {
            _AllowanceRepository = AllowanceRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteAllowanceCommand request, CancellationToken cancellationToken)
        {
            var Allowance = await _AllowanceRepository.GetById(request.Id);
            await _AllowanceRepository.Delete(Allowance);
            return Unit.Value;
        }

        async Task IRequestHandler<DeleteAllowanceCommand>.Handle(DeleteAllowanceCommand request, CancellationToken cancellationToken)
        {
            var Allowance = await _AllowanceRepository.GetById(request.Id);
            if(Allowance == null) 
                throw new NotFoundException(nameof(Allowance), request.Id);
            await _AllowanceRepository.Delete(Allowance);
        }
    }
}

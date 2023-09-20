using AutoMapper;
using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Application.CQRS.Addresss.Request.Command;
using ECX.HR.Application.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.ActingAssigment.Handler.Command
{
    public class DeleteActingAssigmentCommandHandler : IRequestHandler<DeleteAddressCommand>
    {
        private readonly IActingAssigmentRepository _actingAssigmentRepository;
        private readonly IMapper _mapper;

        public DeleteActingAssigmentCommandHandler(IActingAssigmentRepository actingAssigmentRepository, IMapper mapper)
        {
            _actingAssigmentRepository = actingAssigmentRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteAddressCommand request, CancellationToken cancellationToken)
        {
            var act = await _actingAssigmentRepository.GetById(request.Id);

            if (act == null)
                throw new NotFoundException(nameof(act), request.Id);

            // Assuming '1' represents the 'Deleted' status
            act.Status = 1;

            await _actingAssigmentRepository.Update(act); // Update the address with new status

            return Unit.Value;
        }
        async Task IRequestHandler<DeleteAddressCommand>.Handle(DeleteAddressCommand request, CancellationToken cancellationToken)
        {
            var acting = await _actingAssigmentRepository.GetById(request.Id);
            if (acting == null)
                throw new NotFoundException(nameof(acting), request.Id);
            acting.Status = 1;
            await _actingAssigmentRepository.Update(acting);
        }
    }
}

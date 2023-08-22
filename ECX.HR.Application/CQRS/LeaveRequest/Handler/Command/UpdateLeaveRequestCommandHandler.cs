using AutoMapper;
using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Application.CQRS.LeaveRequest.Request.Command;
using ECX.HR.Application.CQRS.LeaveType.Request.Command;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.LeaveRequest.Handler.Command
{
    public class UpdateLeaveRequestCommandHandler : IRequestHandler<UpdateLeaveRequestCommand, Unit>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _maapper;

        public UpdateLeaveRequestCommandHandler(ILeaveRequestRepository leaveRequestRepository, IMapper maapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _maapper = maapper;
        }
        public async Task<Unit> Handle(UpdateLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            /*  var validator = new ();
                var validationResult = await validator.ValidateAsync(request.AddressDto);
                if (validationResult.IsValid == false)
                    throw new ValidationException(validationResult);
    */
            request.leaveRequestdto.UpdatedDate = DateTime.Now;
            var leaveRequest = await _leaveRequestRepository.GetById(request.leaveRequestdto.leaveRequestId);



            _maapper.Map(request.leaveRequestdto, leaveRequest);

            await _leaveRequestRepository.Update(leaveRequest);
            return Unit.Value;
        }

    }
}



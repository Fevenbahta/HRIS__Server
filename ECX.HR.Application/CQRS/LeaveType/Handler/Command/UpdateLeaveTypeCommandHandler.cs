using AutoMapper;
using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Application.CQRS.Addresss.Request.Command;
using ECX.HR.Application.CQRS.LeaveType.Request.Command;
using ECX.HR.Application.DTOs.Address.Validator;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.LeaveType.Handler.Command
{
    
    }
    public class UpdateLeaveTypeCommandHandler : IRequestHandler<UpdateLeaveTypeCommand, Unit>
    {
    private readonly ILeaveTypeRepository _leaveTypeRepository;
    private readonly IMapper _maapper;

    public UpdateLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository, IMapper maapper)
    {
        _leaveTypeRepository = leaveTypeRepository;
        _maapper = maapper;
    }
    public async Task<Unit> Handle(UpdateLeaveTypeCommand request, CancellationToken cancellationToken)
    {
        /*  var validator = new ();
            var validationResult = await validator.ValidateAsync(request.AddressDto);
            if (validationResult.IsValid == false)
                throw new ValidationException(validationResult);
*/
            request.leaveTypeDto.UpdatedDate = DateTime.Now;
            var leaveType = await _leaveTypeRepository.GetById(request.leaveTypeDto.leaveTypeId);



        _maapper.Map(request.leaveTypeDto, leaveType);

            await _leaveTypeRepository.Update(leaveType);
            return Unit.Value;
        }

   

}

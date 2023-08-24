using AutoMapper;
using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Application.CQRS.LeaveRequest.Request.Command;
using ECX.HR.Application.CQRS.LeaveType.Request.Command;
using ECX.HR.Application.DTOs.LeaveRequest.validator;
using ECX.HR.Application.Exceptions;
using ECX.HR.Domain;
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
        private readonly ILeaveBalanceRepository _leaveBalanceRepository;
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _maapper;

        public UpdateLeaveRequestCommandHandler(ILeaveRequestRepository leaveRequestRepository, ILeaveTypeRepository leaveTypeRepository, ILeaveBalanceRepository leaveBalanceRepository, IMapper maapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _leaveBalanceRepository = leaveBalanceRepository;
            _leaveTypeRepository = leaveTypeRepository;
            _maapper = maapper;
        }
        public async Task<Unit> Handle(UpdateLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var validator = new LeaveRequestDtoValidator();
            var validationResult = await validator.ValidateAsync(request.LeaveRequestDto);
            if (validationResult.IsValid == false)
                throw new ValidationException(validationResult);

            request.LeaveRequestDto.UpdatedDate = DateTime.Now;
            var leaveRequest = await _leaveRequestRepository.GetById(request.LeaveRequestDto.leaveRequestId);



            _maapper.Map(request.LeaveRequestDto, leaveRequest);

            await _leaveRequestRepository.Update(leaveRequest);



            if (request.LeaveRequestDto.LeaveStatus == "Approved")
            {

                var leaveStartDate = request.LeaveRequestDto.StartDate;
                var leaveEndDate = request.LeaveRequestDto.EndDate;
                var leaveDuration = (int)(leaveEndDate - leaveStartDate).TotalDays + 1;
                var employeeId = request.LeaveRequestDto.EmpId;
                var leaveBalances = await _leaveBalanceRepository.GetByEmpId(employeeId);
                var leaveTypes = await _leaveTypeRepository.GetAll();




                foreach (var leaveBalance in leaveBalances.OrderBy(lb => lb.StartDate))
                {
                    if (leaveBalance.IsExpired != 1)
                    {
                        var annualRemainingBalance = leaveBalance.AnnualRemainingBalance;
                        var sickRemainingBalance = leaveBalance.SickRemainingBalance;
                        var paternityRemainingBalance = leaveBalance.PaternityRemainingBalance;
                        var maternityRemainingBalance = leaveBalance.MaternityRemainingBalance;
                        var marraiageRemainingBalance = leaveBalance.MarraiageRemainingBalance;
                        var educationRemainingBalance = leaveBalance.EducationRemainingBalance;
                        var compassinateRemainingBalance = leaveBalance.CompassinateRemainingBalance;
                        var courtLeaveRemainingBalance = leaveBalance.CourtLeaveRemainingBalance;
                        var leaveWotPayRemainingBalance = leaveBalance.LeaveWotPayRemainingBalance;

                        if (leaveDuration > 0)
                        {


                            var leaveType = leaveTypes.FirstOrDefault(lt => lt.leaveTypeId == request.LeaveRequestDto.leaveTypeId);

                            if (leaveType != null)
                            {
                                if (leaveType.LeaveTypeName == "Annual" && leaveDuration <= annualRemainingBalance)
                                {
                                    leaveBalance.AnnualRemainingBalance -= leaveDuration;
                                    leaveDuration = 0;
                                }
                                else if (leaveType.LeaveTypeName == "Medical" && leaveDuration <= sickRemainingBalance)
                                {
                                    leaveBalance.SickRemainingBalance -= leaveDuration;
                                    leaveDuration = 0;
                                }
                                else if (leaveType.LeaveTypeName == "Marital" && leaveDuration <= maternityRemainingBalance)
                                {
                                    leaveBalance.MaternityRemainingBalance -= leaveDuration;
                                    leaveDuration = 0;
                                }
                                else if (leaveType.LeaveTypeName == "Marital" && leaveDuration <= educationRemainingBalance)
                                {
                                    leaveBalance.EducationRemainingBalance -= leaveDuration;
                                    leaveDuration = 0;
                                }
                                else if (leaveType.LeaveTypeName == "Marital" && leaveDuration <= marraiageRemainingBalance)
                                {
                                    leaveBalance.MarraiageRemainingBalance -= leaveDuration;
                                    leaveDuration = 0;
                                }
                                else if (leaveType.LeaveTypeName == "Marital" && leaveDuration <= compassinateRemainingBalance)
                                {
                                    leaveBalance.CompassinateRemainingBalance -= leaveDuration;
                                    leaveDuration = 0;
                                }
                                else if (leaveType.LeaveTypeName == "Marital" && leaveDuration <= courtLeaveRemainingBalance)
                                {
                                    leaveBalance.CourtLeaveRemainingBalance -= leaveDuration;
                                    leaveDuration = 0;
                                }
                                else if (leaveType.LeaveTypeName == "Marital" && leaveDuration <= leaveWotPayRemainingBalance)
                                {
                                    leaveBalance.LeaveWotPayRemainingBalance -= leaveDuration;
                                    leaveDuration = 0;
                                }


                                await _leaveBalanceRepository.Update(leaveBalance);
                            }
                            else
                            {

                                break;
                            }
                        }
                    }

                    
                }

            }
            return Unit.Value;
        }
    }
}



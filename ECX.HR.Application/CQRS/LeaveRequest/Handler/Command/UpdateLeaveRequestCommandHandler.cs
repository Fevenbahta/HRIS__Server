﻿/*using AutoMapper;
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
        private readonly IOtherLeaveBalanceRepository _otherLeaveBalanceRepository;
        private readonly ILeaveBalanceRepository _LeaveBalanceRepository;
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _maapper;
        private readonly IEmployeeRepository _employeeRepository;

        public UpdateLeaveRequestCommandHandler(ILeaveRequestRepository leaveRequestRepository, ILeaveTypeRepository leaveTypeRepository, IOtherLeaveBalanceRepository otherLeaveBalanceRepository, IMapper maapper, IEmployeeRepository employeeRepository, ILeaveBalanceRepository leaveBalanceRepository)
        {

            _leaveRequestRepository = leaveRequestRepository;
            _otherLeaveBalanceRepository = otherLeaveBalanceRepository;
            _LeaveBalanceRepository = leaveBalanceRepository;
            _leaveTypeRepository = leaveTypeRepository;
            _maapper = maapper;
            _employeeRepository = employeeRepository;

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


            var leaveTypes = await _leaveTypeRepository.GetAll();
            var leaveType = leaveTypes.FirstOrDefault(lt => lt.leaveTypeId == request.LeaveRequestDto.leaveTypeId);






            if (request.LeaveRequestDto.LeaveStatus == "Approved" && leaveType.LeaveTypeName == "Annual")
            {

                var leaveStartDate = request.LeaveRequestDto.StartDate;
                var leaveEndDate = request.LeaveRequestDto.EndDate;
                var leaveDuration = (int)(leaveEndDate - leaveStartDate).TotalDays + 1;
                var employeeId = request.LeaveRequestDto.EmpId;
                var otherLeaveBalances = await _otherLeaveBalanceRepository.GetByEmpId(employeeId);
                var leaveBalances = await _LeaveBalanceRepository.GetByEmpId(employeeId);

                var employee = await _employeeRepository.GetById(employeeId);
                DateTime employmentStartDate = employee.JoinDate; DateTime currentDate = DateTime.Now;
                int daysElapsed = 365; int yearsOfWork = (currentDate - employmentStartDate).Days / 365;
                int baseLeaveDay = 18 + (yearsOfWork - 1);

                int totalDaysInYear = DateTime.IsLeapYear(currentDate.Year) ? 366 : 365;
                TimeSpan timeWorked = currentDate - employmentStartDate.AddYears(yearsOfWork);
                int daysWorkedInYear = (int)timeWorked.TotalDays;
                int accruedLeave = (int)Math.Round(baseLeaveDay * (double)daysWorkedInYear / totalDaysInYear);

                foreach (var leaveBalance in leaveBalances.OrderBy(lb => lb.StartDate))
                {
                    leaveBalance.TotalRequest += leaveDuration; leaveBalance.TotalRemaining = accruedLeave - leaveBalance.TotalRequest;
                    if (leaveBalance.IsExpired != 1)
                    {
                        var annualRemainingBalance = (leaveBalance.PreviousTwoYear + leaveBalance.PreviousYearAnnualBalance + leaveBalance.AnnualDefaultBalance) - leaveDuration;
                        leaveBalance.AnnualRemainingBalance = annualRemainingBalance;
                        if (leaveDuration > 0)
                        {
                            var leaveType = leaveTypes.FirstOrDefault(lt => lt.leaveTypeId == request.LeaveRequestDto.leaveTypeId);
                            if (leaveType != null)
                            {
                                if (leaveType.LeaveTypeName == "Annual" && leaveDuration <= annualRemainingBalance)
                                {
                                    if (leaveBalance.PreviousTwoYear > 0 && leaveDuration < leaveBalance.PreviousTwoYear)
                                    {
                                        leaveBalance.PreviousTwoYear = Math.Max(0, leaveBalance.PreviousTwoYear - leaveDuration);
                                    }
                                    if (leaveBalance.PreviousTwoYear > 0 && leaveDuration > leaveBalance.PreviousTwoYear)
                                    {
                                        var previousleave = leaveBalance.PreviousYearAnnualBalance + leaveBalance.PreviousTwoYear; previousleave -= leaveDuration;
                                        leaveBalance.PreviousYearAnnualBalance = previousleave;
                                    }
                                    if (leaveDuration > leaveBalance.PreviousYearAnnualBalance && leaveDuration > leaveBalance.PreviousTwoYear)
                                    {
                                        leaveBalance.AnnualRemainingBalance -= leaveDuration;
                                    }
                                }

                            }
                            if (request.LeaveRequestDto.LeaveStatus == "Approved" && leaveType.LeaveTypeName != "Annual")
                            {

                                var leaveStartDate = request.LeaveRequestDto.StartDate;
                                var leaveEndDate = request.LeaveRequestDto.EndDate;
                                var leaveDuration = (int)(leaveEndDate - leaveStartDate).TotalDays + 1;
                                var employeeId = request.LeaveRequestDto.EmpId;
                                var otherLeaveBalances = await _otherLeaveBalanceRepository.GetByEmpId(employeeId);





                                foreach (var otherLeaveBalance in otherLeaveBalances.OrderBy(lb => lb.StartDate))
                                {
                                    if (otherLeaveBalance.IsExpired != 1)
                                    {

                                        var sickRemainingBalance = otherLeaveBalance.SickRemainingBalance;
                                        var paternityRemainingBalance = otherLeaveBalance.PaternityRemainingBalance;
                                        var maternityRemainingBalance = otherLeaveBalance.MaternityRemainingBalance;
                                        var marraiageRemainingBalance = otherLeaveBalance.MarraiageRemainingBalance;
                                        var educationRemainingBalance = otherLeaveBalance.EducationRemainingBalance;
                                        var compassinateRemainingBalance = otherLeaveBalance.CompassinateRemainingBalance;
                                        var courtLeaveRemainingBalance = otherLeaveBalance.CourtLeaveRemainingBalance;
                                        var leaveWotPayRemainingBalance = otherLeaveBalance.LeaveWotPayRemainingBalance;
                                        var abortionRemainingBalance = otherLeaveBalance.AbortionLeaveRemainingBalance;
                                        if (leaveDuration > 0)
                                        {

                                            if (leaveType != null)
                                            {
                                                if (leaveType.LeaveTypeName == "Medical" && leaveDuration <= sickRemainingBalance)
                                                {
                                                    otherLeaveBalance.SickRemainingBalance -= leaveDuration;
                                                    leaveDuration = 0;
                                                    if (otherLeaveBalance.SickEndDate == DateTime.MinValue)
                                                    {
                                                        otherLeaveBalance.SickEndDate = leaveRequest.StartDate.AddDays(366);
                                                        otherLeaveBalance.SickStartDate = leaveRequest.StartDate;

                                                    }

                                                }
                                                else if (leaveType.LeaveTypeName == "Abortion" && leaveDuration <= abortionRemainingBalance)
                                                {
                                                    otherLeaveBalance.AbortionLeaveRemainingBalance -= leaveDuration;
                                                    leaveDuration = 0;
                                                }
                                                else if (leaveType.LeaveTypeName == "Marital" && leaveDuration <= maternityRemainingBalance)
                                                {
                                                    otherLeaveBalance.MaternityRemainingBalance -= leaveDuration;
                                                    leaveDuration = 0;
                                                }
                                                else if (leaveType.LeaveTypeName == "Education" && leaveDuration <= educationRemainingBalance)
                                                {
                                                    otherLeaveBalance.EducationRemainingBalance -= leaveDuration;
                                                    leaveDuration = 0;
                                                }
                                                else if (leaveType.LeaveTypeName == "Marraige" && leaveDuration <= marraiageRemainingBalance)
                                                {
                                                    otherLeaveBalance.MarraiageRemainingBalance -= leaveDuration;
                                                    leaveDuration = 0;
                                                }
                                                else if (leaveType.LeaveTypeName == "Compassinate" && leaveDuration <= compassinateRemainingBalance)
                                                {
                                                    otherLeaveBalance.CompassinateRemainingBalance -= leaveDuration;
                                                    leaveDuration = 0;
                                                }
                                                else if (leaveType.LeaveTypeName == "Court" && leaveDuration <= courtLeaveRemainingBalance)
                                                {
                                                    otherLeaveBalance.CourtLeaveRemainingBalance -= leaveDuration;
                                                    leaveDuration = 0;
                                                }
                                                else if (leaveType.LeaveTypeName == "Leave With Out Pay" && leaveDuration <= leaveWotPayRemainingBalance)
                                                {
                                                    otherLeaveBalance.LeaveWotPayRemainingBalance -= leaveDuration;
                                                    leaveDuration = 0;
                                                }
                                                request.LeaveRequestDto.SickEndDate = otherLeaveBalance.SickEndDate;
                                                request.LeaveRequestDto.SickEndDate = otherLeaveBalance.SickStartDate;
                                                await _leaveRequestRepository.Update(leaveRequest);
                                                await _otherLeaveBalanceRepository.Update(otherLeaveBalance);
                                            }
                                            else
                                            {

                                                break;
                                            }
                                        }
                                    }

                                    return Unit.Value;
                                }

                            } } } 

                        
                 
         





*/
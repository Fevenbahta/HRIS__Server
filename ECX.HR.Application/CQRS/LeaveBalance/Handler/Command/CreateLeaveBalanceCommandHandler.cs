using AutoMapper;
using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Application.CQRS.LeaveBalance.Request.Command;
using ECX.HR.Application.DTOs.Employees;
using ECX.HR.Application.DTOs.Leave;
using ECX.HR.Application.DTOs.LeaveBalance;
using ECX.HR.Application.DTOs.LeaveBalance.Validator;
using ECX.HR.Application.Exceptions;

using ECX.HR.Application.Response;
using ECX.HR.Domain;
using Hangfire.Annotations;
using MediatR;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.LeaveBalance.Handler.Command
{
    public class CreateLeaveBalanceCommandHandler : IRequestHandler<CreateLeaveBalanceCommand, BaseCommandResponse>
    {
        BaseCommandResponse response;
        private ILeaveBalanceRepository _LeaveBalanceRepository;
        private readonly LeaveBalanceDto _leaveBalanceDto;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly EmployeeDto _employeeDto;
        private IMapper _mapper;
        public CreateLeaveBalanceCommandHandler(ILeaveBalanceRepository LeaveBalanceRepository, LeaveBalanceDto leaveBalanceDto, IEmployeeRepository employeeRepository,
             EmployeeDto employeeDto, IMapper mapper)
        {
            _LeaveBalanceRepository = LeaveBalanceRepository;
            _leaveBalanceDto = leaveBalanceDto;
            _employeeRepository = employeeRepository;
            _employeeDto = employeeDto;
            _mapper = mapper;
        }
        public async Task<BaseCommandResponse> Handle(CreateLeaveBalanceCommand request, CancellationToken cancellationToken)
        {
            response = new BaseCommandResponse();
            var validator = new LeaveBalanceDtoValidator();
            var validationResult = await validator.ValidateAsync(request.LeaveBalanceDto);

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Creation Faild";
                response.Errors = validationResult.Errors.Select(x => x.ErrorMessage).ToList();
            }

            var LeaveBalance = _mapper.Map<LeaveBalances>(request.LeaveBalanceDto);
            LeaveBalance.Id = Guid.NewGuid();

            var emp = await _employeeRepository.GetById(LeaveBalance.EmpId);

            DateTime employmentStartDate = emp.JoinDate;


            TimeSpan difference = LeaveBalance.EndDate.Subtract(employmentStartDate);

            int daysDifference = difference.Days;



            int daysElapsed = 365;

            LeaveBalance.EndDate = employmentStartDate.AddDays(daysElapsed);

            int yearsOfWork = (DateTime.Now - employmentStartDate).Days / 365;
            int maxLeaveDays = 30;
            int baseLeaveDays = 18;
            int additionalLeavePerYear = 1;

            DateTime currentDate = DateTime.Now;

            int totalDaysInYear = DateTime.IsLeapYear(currentDate.Year) ? 366 : 365;





            TimeSpan timeWorked = currentDate - employmentStartDate;

            int daysWorked = (int)timeWorked.TotalDays;
            int accruedLeave = (int)Math.Round(baseLeaveDays * (double)daysWorked / totalDaysInYear);

            int annualleave = Math.Min(accruedLeave, maxLeaveDays);
            LeaveBalance.AnnualDefaultBalance = annualleave;

            //LeaveBalance.AnnualDefaultBalance = annualleave;
            LeaveBalance.AnnualRemainingBalance = LeaveBalance.AnnualDefaultBalance;
            LeaveBalance.SickDefaultBalance = 180;
            LeaveBalance.SickRemainingBalance = LeaveBalance.SickDefaultBalance;
            LeaveBalance.CompassinateDefaultBalance = 3;
            LeaveBalance.CompassinateRemainingBalance = LeaveBalance.CompassinateDefaultBalance;
            LeaveBalance.LeaveWotPayDefaultBalance = 90;
            LeaveBalance.LeaveWotPayRemainingBalance = LeaveBalance.LeaveWotPayDefaultBalance;
            LeaveBalance.EducationDefaultBalance = 5;
            LeaveBalance.EducationRemainingBalance = LeaveBalance.EducationDefaultBalance;
            LeaveBalance.MarriageDefaultBalance = 3;
            LeaveBalance.MarraiageRemainingBalance = LeaveBalance.MarriageDefaultBalance;
            LeaveBalance.MaternityDefaultBalance = 120;
            LeaveBalance.MaternityRemainingBalance = LeaveBalance.MarriageDefaultBalance;
            LeaveBalance.PaternityDefaultBalance = 15;
            LeaveBalance.PaternityRemainingBalance = LeaveBalance.PaternityDefaultBalance;
            LeaveBalance.CourtLeaveDefaultBalance = 0;
            LeaveBalance.CourtLeaveRemainingBalance = LeaveBalance.CourtLeaveDefaultBalance;
            LeaveBalance.StartDate = employmentStartDate;

            var data = await _LeaveBalanceRepository.Add(LeaveBalance);






            response.Success = true;
            response.Message = "Creation Successfull";
            //response.Id = (Guid)add;
            return response;
        }

       public async Task generate()
        {
            var Employees = _mapper.Map<Employees>(_employeeDto);
            var employees = await _employeeRepository.GetAll();
            foreach (var employee in employees) {
                var LeaveBalance = _mapper.Map<LeaveBalances>(_leaveBalanceDto);
                var existingLeaveBalance = await _LeaveBalanceRepository.GetById(LeaveBalance.Id);
                TimeSpan differences = existingLeaveBalance.EndDate.Subtract(existingLeaveBalance.StartDate);

                DateTime employmentStartDate = existingLeaveBalance.EndDate.AddDays(1);

                int yearsOfWork = (DateTime.Now - employmentStartDate).Days / 365;
                int maxLeaveDays = 30;
                int baseLeaveDays = 18;
                int additionalLeavePerYear = 1;

                DateTime currentDate = DateTime.Now;

                int totalDaysInYear = DateTime.IsLeapYear(currentDate.Year) ? 366 : 365;

                TimeSpan timeWorked = currentDate - employmentStartDate;

                int daysWorked = (int)timeWorked.TotalDays;

                int accruedLeave = (int)Math.Round(maxLeaveDays * (double)daysWorked / totalDaysInYear);

                int annualleave = Math.Min(accruedLeave, maxLeaveDays);

                TimeSpan timeWorkeds = currentDate - (existingLeaveBalance.EndDate.AddDays(1));

                int daysWorkeds = (int)timeWorkeds.TotalDays;

                int totalbaseLeaveDays = baseLeaveDays + Math.Min(yearsOfWork - 1, maxLeaveDays - baseLeaveDays) * additionalLeavePerYear;
                int accruedLeaves = (int)Math.Round(totalbaseLeaveDays * (double)daysWorkeds / totalDaysInYear);

                int annualleaves = Math.Min(accruedLeaves, maxLeaveDays);


                

                int daysDifferences = differences.Days;
                if (daysDifferences > 365 && existingLeaveBalance.Status == 0)
                {
                    int days = 1;
                    var newLeaveBalance = new LeaveBalances
                    {
                        Id = Guid.NewGuid(),
                        EmpId = existingLeaveBalance.EmpId,
                        StartDate = existingLeaveBalance.EndDate.AddDays(days),
                        EndDate = existingLeaveBalance.EndDate.AddDays(days).AddDays(365),
                        AnnualDefaultBalance = existingLeaveBalance.AnnualRemainingBalance + annualleaves,
                        AnnualRemainingBalance = existingLeaveBalance.AnnualRemainingBalance + annualleaves,
                        SickDefaultBalance = 180,
                        SickRemainingBalance = 180,
                        CompassinateDefaultBalance = 3,
                        CompassinateRemainingBalance = 3,
                        LeaveWotPayDefaultBalance = 90,
                        LeaveWotPayRemainingBalance = 90,
                        EducationDefaultBalance = 5,
                        EducationRemainingBalance = 5,
                        MarriageDefaultBalance = 3,
                        MarraiageRemainingBalance = 3,
                        MaternityDefaultBalance = 120,
                        MaternityRemainingBalance = 120,
                        PaternityDefaultBalance = 15,
                        PaternityRemainingBalance = 15,
                        CourtLeaveDefaultBalance = 0,
                        CourtLeaveRemainingBalance = 0,
                      
                       


                    };
                    existingLeaveBalance.Status = 1;
                    var data1 = await _LeaveBalanceRepository.Add(newLeaveBalance);


                } }

        }
    } }
    

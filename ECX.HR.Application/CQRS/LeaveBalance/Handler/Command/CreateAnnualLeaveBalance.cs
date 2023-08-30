using AutoMapper;
using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Application.CQRS.LeaveBalance.Request.Command;
using ECX.HR.Application.DTOs.LeaveBalance.Validator;
using ECX.HR.Application.Response;
using ECX.HR.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.LeaveBalance.Handler.Command
{
    public  class CreateAnnualLeaveBalance : IRequestHandler<CreateAnnualLeaveBalanceCommand, BaseCommandResponse>
    {
        private readonly ILeaveBalanceRepository _leaveBalanceRepository;
        private readonly IMapper _mapper;
        private readonly IEmployeeRepository _employeeRepository;

        public CreateAnnualLeaveBalance(ILeaveBalanceRepository leaveBalanceRepository, IMapper mapper, IEmployeeRepository employeeRepository)
        {
            _leaveBalanceRepository = leaveBalanceRepository;
            _mapper = mapper;
            _employeeRepository = employeeRepository;
        }

    public async Task<BaseCommandResponse> Handle(CreateAnnualLeaveBalanceCommand request, CancellationToken cancellationToken)
        {
            BaseCommandResponse response = new BaseCommandResponse();
            var validator = new LeaveBalanceDtoValidator();
            var validationResult = await validator.ValidateAsync(request.LeaveBalanceDto);

            if (!validationResult.IsValid)
            {
                response.Success = false;
                response.Message = "Creation Failed";
                response.Errors = validationResult.Errors.Select(x => x.ErrorMessage).ToList();
                return response;
            }

            var leaveAnnualBalance = _mapper.Map<AnnualLeaveBalances>(request.LeaveBalanceDto);
            leaveAnnualBalance.Id = Guid.NewGuid();

            var employee = await _employeeRepository.GetById(leaveAnnualBalance.EmpId);

            DateTime employmentStartDate = employee.JoinDate;
            DateTime currentDate = DateTime.Now;
            int daysElapsed = 365;
            var ed = employmentStartDate.AddDays(daysElapsed);

            TimeSpan difference = ed.Subtract(employmentStartDate);
            int daysDifference = difference.Days;




            int yearsOfWork = (currentDate - employmentStartDate).Days / 365;
            int maxLeaveDays = 30;
            int baseLeaveDay = 18 + (yearsOfWork-1);

            int baseLeaveDays = Math.Min(baseLeaveDay, 30);

            int totalDaysInYear = DateTime.IsLeapYear(currentDate.Year) ? 366 : 365;

            TimeSpan timeWorked = currentDate - employmentStartDate.AddYears(yearsOfWork);


            int daysWorkedInYear = (int)timeWorked.TotalDays;
            int accruedLeave = (int)Math.Round(baseLeaveDays * (double)daysWorkedInYear / totalDaysInYear);

            int annualLeave = Math.Min(accruedLeave, maxLeaveDays);

            leaveAnnualBalance.AnnualDefaultBalance = annualLeave;
            leaveAnnualBalance.AnnualRemainingBalance = leaveAnnualBalance.AnnualDefaultBalance;
            leaveAnnualBalance.PreviousYearAnnualBalance = 0;
            leaveAnnualBalance.PreviousTwoYear = 0;
            leaveAnnualBalance.TotalRemaining = annualLeave;
            leaveAnnualBalance.TotalRequest = 0;




            int previousYear = currentDate.Year - 1;
            Decimal previousYearBalance = 0;
            if (yearsOfWork == 1)
            {
                leaveAnnualBalance.StartDate = employmentStartDate.AddYears(yearsOfWork);
                leaveAnnualBalance.EndDate = leaveAnnualBalance.StartDate.AddDays(360).AddDays(1);
                leaveAnnualBalance.PreviousYearAnnualBalance= leaveAnnualBalance.AnnualRemainingBalance;
                leaveAnnualBalance.PreviousTwoYear = 0;
                leaveAnnualBalance.AnnualRemainingBalance = leaveAnnualBalance.PreviousYearAnnualBalance + leaveAnnualBalance.AnnualDefaultBalance;
               
                // Get the previous year's annual balance from the entity 
                previousYearBalance = leaveAnnualBalance.AnnualRemainingBalance;
               
               // previousYearBalance = baseLeaveDays - 1;

            }
           else if(yearsOfWork > 1)
            {
                leaveAnnualBalance.StartDate = employmentStartDate.AddYears(yearsOfWork);
                leaveAnnualBalance.EndDate = leaveAnnualBalance.StartDate.AddDays(360).AddDays(1);
                leaveAnnualBalance.PreviousTwoYear = leaveAnnualBalance.PreviousYearAnnualBalance;
                leaveAnnualBalance.PreviousYearAnnualBalance = leaveAnnualBalance.AnnualRemainingBalance;
                leaveAnnualBalance.AnnualRemainingBalance = leaveAnnualBalance.PreviousYearAnnualBalance + leaveAnnualBalance.PreviousTwoYear;


            }
            else
            {
                leaveAnnualBalance.StartDate = employmentStartDate;
                leaveAnnualBalance.EndDate = leaveAnnualBalance.StartDate.AddDays(360).AddDays(1);
            }

            await _leaveBalanceRepository.Add(leaveAnnualBalance);

            response.Success = true;
            response.Message = "Creation Successful";
            return response;
        }
    }
}

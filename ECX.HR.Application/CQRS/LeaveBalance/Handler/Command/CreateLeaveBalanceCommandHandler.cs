using AutoMapper;
using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Application.CQRS.LeaveBalance.Request.Command;
using ECX.HR.Application.DTOs.LeaveBalance;
using ECX.HR.Application.DTOs.LeaveBalance.Validator;
using ECX.HR.Application.Response;
using ECX.HR.Domain;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.LeaveBalance.Handler.Command
{
    public class CreateLeaveBalanceHandler : IRequestHandler<CreateLeaveBalanceCommand, BaseCommandResponse>
    {
        private readonly ILeaveBalanceRepository _leaveBalanceRepository;
        private readonly IMapper _mapper;
        private readonly IEmployeeRepository _employeeRepository;

        public CreateLeaveBalanceHandler(ILeaveBalanceRepository leaveBalanceRepository, IMapper mapper, IEmployeeRepository employeeRepository)
        {
            _leaveBalanceRepository = leaveBalanceRepository;
            _mapper = mapper;
            _employeeRepository = employeeRepository;
        }

        public async Task<BaseCommandResponse> Handle(CreateLeaveBalanceCommand request, CancellationToken cancellationToken)
        {
            BaseCommandResponse response = new BaseCommandResponse();

            // Validate the leave balance DTO 
            var validator = new LeaveBalanceDtoValidator();
            var validationResult = await validator.ValidateAsync(request.LeaveBalanceDto);

            if (!validationResult.IsValid)
            {
                response.Success = false;
                response.Message = "Creation Failed";
                response.Errors = validationResult.Errors.Select(x => x.ErrorMessage).ToList();
                return response;
            }

            var leaveBalance = _mapper.Map<LeaveBalances>(request.LeaveBalanceDto);
            leaveBalance.Id = Guid.NewGuid();

            var employee = await _employeeRepository.GetById(leaveBalance.EmpId);

            DateTime employmentStartDate = employee.JoinDate;
            DateTime currentDate = DateTime.Now;
            int daysElapsed = 365;
            var ed = employmentStartDate.AddDays(daysElapsed);

            TimeSpan difference = ed.Subtract(employmentStartDate);
            int daysDifference = difference.Days;




            int yearsOfWork = (currentDate - employmentStartDate).Days / 365;
            int maxLeaveDays = 30;
            int baseLeaveDay = 18 + yearsOfWork;

            int baseLeaveDays = Math.Min(baseLeaveDay, 30);

            int totalDaysInYear = DateTime.IsLeapYear(currentDate.Year) ? 366 : 365;

            TimeSpan timeWorked = currentDate - employmentStartDate.AddYears(yearsOfWork); ;
            int daysWorkedInYear = (int)timeWorked.TotalDays;
            int accruedLeave = (int)Math.Round(baseLeaveDays * (double)daysWorkedInYear / totalDaysInYear);

            int annualLeave = Math.Min(accruedLeave, maxLeaveDays);

            leaveBalance.AnnualDefaultBalance = annualLeave;
            leaveBalance.AnnualRemainingBalance = leaveBalance.AnnualDefaultBalance;
            leaveBalance.SickDefaultBalance = 180;
            leaveBalance.SickRemainingBalance = leaveBalance.SickDefaultBalance;
            leaveBalance.CompassinateDefaultBalance = 3;
            leaveBalance.CompassinateRemainingBalance = leaveBalance.CompassinateDefaultBalance;
            leaveBalance.LeaveWotPayDefaultBalance = 90;
            leaveBalance.LeaveWotPayRemainingBalance = leaveBalance.LeaveWotPayDefaultBalance;
            leaveBalance.EducationDefaultBalance = 5;
            leaveBalance.EducationRemainingBalance = leaveBalance.EducationDefaultBalance;
            leaveBalance.MarriageDefaultBalance = 3;
            leaveBalance.MarraiageRemainingBalance = leaveBalance.MarriageDefaultBalance;
            leaveBalance.MaternityDefaultBalance = 120;
            leaveBalance.MaternityRemainingBalance = leaveBalance.MarriageDefaultBalance;
            leaveBalance.PaternityDefaultBalance = 15;
            leaveBalance.PaternityRemainingBalance = leaveBalance.PaternityDefaultBalance;
            leaveBalance.CourtLeaveDefaultBalance = 0;
            leaveBalance.CourtLeaveRemainingBalance = leaveBalance.CourtLeaveDefaultBalance;
            


            // Calculate the previous year's balance 
            int previousYear = currentDate.Year - 1;
            Decimal previousYearBalance = 0;
            if (yearsOfWork >= 1)
            {
                leaveBalance.StartDate = employmentStartDate.AddYears(yearsOfWork);
                leaveBalance.EndDate = leaveBalance.StartDate.AddDays(360).AddDays(1);

                // Get the previous year's annual balance from the entity 
                previousYearBalance = leaveBalance.PreviousYearAnnualBalance;

                previousYearBalance = baseLeaveDays - 1;

            }
            else
            {
                leaveBalance.StartDate = employmentStartDate;
                leaveBalance.EndDate = leaveBalance.StartDate.AddDays(360).AddDays(1);
            }
            // if (previousYearBalance < 1) 
            //     { 
            //         previousYearBalance = 0; 
            //     } 


            leaveBalance.AnnualRemainingBalance += previousYearBalance;

            leaveBalance.PreviousYearAnnualBalance = previousYearBalance;

            await _leaveBalanceRepository.Add(leaveBalance);

            response.Success = true;
            response.Message = "Creation Successful";
            return response;
        }
    }
}
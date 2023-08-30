using AutoMapper;
using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Application.CQRS.LeaveBalance.Request.Command;
using ECX.HR.Application.CQRS.LeaveBalance.Request.Queries;
using ECX.HR.Application.DTOs.LeaveBalance;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.LeaveBalance.Handler.Queries
{
    public class GetLeaveBalanceListRequestHandler : IRequestHandler<GetLeaveBalanceListRequest, List<AnnualLeaveBalanceDto>>
    {
        private ILeaveBalanceRepository _LeaveBalanceRepository;
        private IMapper _mapper;
        public GetLeaveBalanceListRequestHandler(ILeaveBalanceRepository LeaveBalanceRepository, IMapper mapper)
        {
            _LeaveBalanceRepository = LeaveBalanceRepository;
            _mapper = mapper;
        }
        public async Task<List<AnnualLeaveBalanceDto>> Handle(GetLeaveBalanceListRequest request, CancellationToken cancellationToken)
        {
            var leaveBalances = await _LeaveBalanceRepository.GetAll();

            var activeLeaveBalances = leaveBalances.Where(leaveBalance => leaveBalance.Status == 0).ToList();


            var expiredLeaveBalances = await _LeaveBalanceRepository.GetExpiredLeaveBalances();

            foreach (var leaveBalance in expiredLeaveBalances)
            {

                TimeSpan differences = leaveBalance.EndDate.Subtract(leaveBalance.StartDate);

                DateTime employmentStartDate = leaveBalance.EndDate.AddDays(1);

                int yearsOfWork = (DateTime.Now - employmentStartDate).Days / 365;
                int maxLeaveDays = 30;
                int baseLeaveDays = 18 + yearsOfWork;
                int additionalLeavePerYear = 1;

                DateTime currentDate = DateTime.Now;

                int totalDaysInYear = DateTime.IsLeapYear(currentDate.Year) ? 366 : 365;

                TimeSpan timeWorkeds = currentDate - (leaveBalance.EndDate.AddDays(1));

                int daysWorkeds = (int)timeWorkeds.TotalDays;

                int totalbaseLeaveDays = baseLeaveDays + Math.Min(yearsOfWork - 1, maxLeaveDays - baseLeaveDays) * additionalLeavePerYear;
                int accruedLeaves = (int)Math.Round(totalbaseLeaveDays * (double)daysWorkeds / totalDaysInYear);

                int annualleaves = Math.Min(accruedLeaves, maxLeaveDays);
                int daysDifferences = differences.Days;
                int days = 1;

                var updatedDto = _mapper.Map<AnnualLeaveBalanceDto>(leaveBalance);
                var annualRemaining = leaveBalance.PreviousYearAnnualBalance + leaveBalance.PreviousTwoYear;
                updatedDto.EmpId = leaveBalance.EmpId;
                updatedDto.StartDate = leaveBalance.EndDate.AddDays(days);
                updatedDto.EndDate = leaveBalance.EndDate.AddDays(days).AddDays(365);
                updatedDto.AnnualDefaultBalance = annualleaves;
                updatedDto.PreviousYearAnnualBalance = leaveBalance.AnnualRemainingBalance;
                updatedDto.PreviousTwoYear = leaveBalance.PreviousYearAnnualBalance;
                updatedDto.AnnualRemainingBalance = annualRemaining;

                await _LeaveBalanceRepository.Update(leaveBalance);

            }
            return _mapper.Map<List<AnnualLeaveBalanceDto>>(activeLeaveBalances);
        }
    }
}
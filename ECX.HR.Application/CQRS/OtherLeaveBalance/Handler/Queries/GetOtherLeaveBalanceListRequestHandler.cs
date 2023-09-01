using AutoMapper;
using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Application.CQRS.LeaveBalance.Request.Command;
using ECX.HR.Application.CQRS.OtherLeaveBalance.Handler.Command;
using ECX.HR.Application.CQRS.OtherLeaveBalance.Request.Command;
using ECX.HR.Application.CQRS.OtherLeaveBalance.Request.Queries;
using ECX.HR.Application.DTOs.LeaveBalance;
using ECX.HR.Domain;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace ECX.HR.Application.CQRS.OtherLeaveBalance.Handler.Queries
{
    public class GetOtherLeaveBalanceListRequestHandler : IRequestHandler<GetOtherLeaveBalanceListRequest, List<OtherLeaveBalanceDto>>
    {
        private IOtherLeaveBalanceRepository _otherLeaveBalanceRepository;
        private IMapper _mapper;
        private readonly ILeaveBalanceRepository _LeaveBalanceRepository;

        private readonly IServiceScopeFactory _serviceScopeFactory;
        public GetOtherLeaveBalanceListRequestHandler(IOtherLeaveBalanceRepository OtherLeaveBalanceRepository, IMapper mapper, ILeaveBalanceRepository LeaveBalanceRepository)
        {
            _otherLeaveBalanceRepository = OtherLeaveBalanceRepository;
            _mapper = mapper;
            _LeaveBalanceRepository = LeaveBalanceRepository;
        }
        public async Task<List<OtherLeaveBalanceDto>> Handle(GetOtherLeaveBalanceListRequest request, CancellationToken cancellationToken)
        {
            var OtherLeaveBalances = await _otherLeaveBalanceRepository.GetAll();





            var expiredOtherLeaveBalances = await _otherLeaveBalanceRepository.GetExpiredOtherLeaveBalances();
            foreach (var otherLeaveBalance in expiredOtherLeaveBalances)
            {
                DateTime employmentStartDate = otherLeaveBalance.EndDate.AddDays(1);

                DateTime currentDate = DateTime.Now;

                int totalDaysInYear = DateTime.IsLeapYear(currentDate.Year) ? 366 : 365;

                int days = 1;

                var newleaveBalance = _mapper.Map<OtherLeaveBalanceDto>(otherLeaveBalance);

                newleaveBalance.EmpId = otherLeaveBalance.EmpId;
                newleaveBalance.StartDate = otherLeaveBalance.EndDate.AddDays(days);
                newleaveBalance.EndDate = otherLeaveBalance.EndDate.AddDays(days).AddDays(365);

                newleaveBalance.SickDefaultBalance = otherLeaveBalance.SickDefaultBalance;
                newleaveBalance.SickRemainingBalance = otherLeaveBalance.SickRemainingBalance;
                newleaveBalance.CompassinateDefaultBalance = otherLeaveBalance.CompassinateDefaultBalance;
                newleaveBalance.CompassinateRemainingBalance = otherLeaveBalance.CompassinateRemainingBalance;
                newleaveBalance.LeaveWotPayDefaultBalance = 90;
                newleaveBalance.LeaveWotPayRemainingBalance = 90;
                newleaveBalance.EducationDefaultBalance = 5;
                newleaveBalance.EducationRemainingBalance = 5;
                newleaveBalance.MarriageDefaultBalance = otherLeaveBalance.MarriageDefaultBalance;
                newleaveBalance.MarraiageRemainingBalance = otherLeaveBalance.MarraiageRemainingBalance;
                newleaveBalance.MaternityDefaultBalance = otherLeaveBalance.MaternityDefaultBalance;
                newleaveBalance.MaternityRemainingBalance = otherLeaveBalance.MarraiageRemainingBalance;
                newleaveBalance.PaternityDefaultBalance = otherLeaveBalance.PaternityDefaultBalance;
                newleaveBalance.PaternityRemainingBalance = otherLeaveBalance.PaternityRemainingBalance;
                newleaveBalance.CourtLeaveDefaultBalance = otherLeaveBalance.CourtLeaveDefaultBalance;
                newleaveBalance.CourtLeaveRemainingBalance = otherLeaveBalance.CourtLeaveRemainingBalance;
                newleaveBalance.AbortionLeaveRemainingBalance = otherLeaveBalance.AbortionLeaveRemainingBalance;
                newleaveBalance.AbortionLeaveDefaultBalance=otherLeaveBalance.AbortionLeaveDefaultBalance;


                await _LeaveBalanceRepository.Update(newleaveBalance);

                Console.WriteLine($"Updated leave balance with ID {otherLeaveBalance.Id}");
            }

            foreach (var otherLeaveBalance in OtherLeaveBalances)
            {

                var newotherleavebalance = _mapper.Map<OtherLeaveBalanceDto>(otherLeaveBalance);




                DateTime employmentStartDate = otherLeaveBalance.StartDate;

                int daysElapsed = 365;
                var ed = employmentStartDate.AddDays(daysElapsed);


                DateTime currentDate = DateTime.Now;


                int totalDaysInYear = DateTime.IsLeapYear(currentDate.Year) ? 366 : 365;

                if (otherLeaveBalance.SickEndDate <= currentDate)
                {
                    newotherleavebalance.SickEndDate = DateTime.MinValue;
                    newotherleavebalance.SickStartDate = DateTime.MinValue;

                    newotherleavebalance.SickRemainingBalance = 180;
                    newotherleavebalance.SickRemainingBalance = 180;
                }


                if (otherLeaveBalance.CompassinateRemainingBalance == 0)
                {
                    newotherleavebalance.CompassinateRemainingBalance = 3;
                    newotherleavebalance.CompassinateDefaultBalance = 3;
                }
                if (otherLeaveBalance.AbortionLeaveRemainingBalance== 0)
                {
                    newotherleavebalance.AbortionLeaveRemainingBalance = 30;
                    newotherleavebalance.AbortionLeaveDefaultBalance = 30;
                }

                if (otherLeaveBalance.MarraiageRemainingBalance == 0)
                {
                    newotherleavebalance.MarriageDefaultBalance = 3;
                    newotherleavebalance.MarraiageRemainingBalance = 3;
                }
                if (otherLeaveBalance.MaternityRemainingBalance == 0)
                {
                    newotherleavebalance.MaternityDefaultBalance = 120;
                    newotherleavebalance.MaternityRemainingBalance = 120;
                }
                if (otherLeaveBalance.PaternityRemainingBalance == 0)
                {
                    newotherleavebalance.PaternityRemainingBalance = 7;
                    newotherleavebalance.PaternityRemainingBalance = 7;
                }


                if (otherLeaveBalance.CourtLeaveRemainingBalance == 0)
                {
                    newotherleavebalance.CourtLeaveDefaultBalance = 0;
                    newotherleavebalance.CourtLeaveRemainingBalance = 0;
                }


                await _LeaveBalanceRepository.Update(newotherleavebalance);
                Console.WriteLine($"Updated leave balance with ID {newotherleavebalance.Id}");
            }



     var activeOtherLeaveBalances = OtherLeaveBalances.Where(OtherLeaveBalance => OtherLeaveBalance.Status == 0).ToList();

            return _mapper.Map<List<OtherLeaveBalanceDto>>(activeOtherLeaveBalances);
        }
    }
}
    
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
        private readonly UpdateOtherLeaveBalanceCommandHandler _updateOtherLeaveBalanceCommandHandler;

        private readonly IServiceScopeFactory _serviceScopeFactory;
        public GetOtherLeaveBalanceListRequestHandler(IOtherLeaveBalanceRepository OtherLeaveBalanceRepository, IMapper mapper, UpdateOtherLeaveBalanceCommandHandler updateOtherLeaveBalanceCommandHandler)
        {
            _otherLeaveBalanceRepository = OtherLeaveBalanceRepository;
            _mapper = mapper;
            _updateOtherLeaveBalanceCommandHandler = updateOtherLeaveBalanceCommandHandler;
        }
        public async Task<List<OtherLeaveBalanceDto>> Handle(GetOtherLeaveBalanceListRequest request, CancellationToken cancellationToken)
        {
            var OtherLeaveBalances = await _otherLeaveBalanceRepository.GetAll();

            var activeOtherLeaveBalances = OtherLeaveBalances.Where(OtherLeaveBalance => OtherLeaveBalance.Status == 0).ToList();




            var expiredOtherLeaveBalances = await _otherLeaveBalanceRepository.GetExpiredOtherLeaveBalances();
            foreach (var otherLeaveBalance in expiredOtherLeaveBalances)
            {
                DateTime employmentStartDate = otherLeaveBalance.EndDate.AddDays(1);

                DateTime currentDate = DateTime.Now;

                int totalDaysInYear = DateTime.IsLeapYear(currentDate.Year) ? 366 : 365;

                int days = 1;

                var updatedDto = _mapper.Map<OtherLeaveBalanceDto>(otherLeaveBalance);

                updatedDto.EmpId = otherLeaveBalance.EmpId;
                updatedDto.StartDate = otherLeaveBalance.EndDate.AddDays(days);
                updatedDto.EndDate = otherLeaveBalance.EndDate.AddDays(days).AddDays(365);

                updatedDto.SickDefaultBalance = otherLeaveBalance.SickDefaultBalance;
                updatedDto.SickRemainingBalance = otherLeaveBalance.SickRemainingBalance;
                updatedDto.CompassinateDefaultBalance = otherLeaveBalance.CompassinateDefaultBalance;
                updatedDto.CompassinateRemainingBalance = otherLeaveBalance.CompassinateRemainingBalance;
                updatedDto.LeaveWotPayDefaultBalance = 90;
                updatedDto.LeaveWotPayRemainingBalance = 90;
                updatedDto.EducationDefaultBalance = 5;
                updatedDto.EducationRemainingBalance = 5;
                updatedDto.MarriageDefaultBalance = otherLeaveBalance.MarriageDefaultBalance;
                updatedDto.MarraiageRemainingBalance = otherLeaveBalance.MarraiageRemainingBalance;
                updatedDto.MaternityDefaultBalance = otherLeaveBalance.MaternityDefaultBalance;
                updatedDto.MaternityRemainingBalance = otherLeaveBalance.MarraiageRemainingBalance;
                updatedDto.PaternityDefaultBalance = otherLeaveBalance.PaternityDefaultBalance;
                updatedDto.PaternityRemainingBalance = otherLeaveBalance.PaternityRemainingBalance;
                updatedDto.CourtLeaveDefaultBalance = otherLeaveBalance.CourtLeaveDefaultBalance;
                updatedDto.CourtLeaveRemainingBalance = otherLeaveBalance.CourtLeaveRemainingBalance;
                updatedDto.AbortionLeaveRemainingBalance = otherLeaveBalance.AbortionLeaveRemainingBalance;
                updatedDto.AbortionLeaveDefaultBalance=otherLeaveBalance.AbortionLeaveDefaultBalance;

                var updateCommand = new UpdateOtherLeaveBalanceCommand
                {
                    OtherLeaveBalanceDto = updatedDto
                };

                await _updateOtherLeaveBalanceCommandHandler.Handle(updateCommand, cancellationToken);

                Console.WriteLine($"Updated leave balance with ID {otherLeaveBalance.Id}");
            }

            foreach (var otherLeaveBalance in OtherLeaveBalances)
            {

                var updatedDtos = _mapper.Map<OtherLeaveBalanceDto>(otherLeaveBalance);




                DateTime employmentStartDate = otherLeaveBalance.StartDate;

                int daysElapsed = 365;
                var ed = employmentStartDate.AddDays(daysElapsed);


                DateTime currentDate = DateTime.Now;


                int totalDaysInYear = DateTime.IsLeapYear(currentDate.Year) ? 366 : 365;

                if (otherLeaveBalance.SickEndDate <= currentDate)
                {
                    updatedDtos.SickEndDate = DateTime.MinValue;
                    updatedDtos.SickStartDate = DateTime.MinValue;

                    updatedDtos.SickRemainingBalance = 180;
                    updatedDtos.SickRemainingBalance = 180;
                }


                if (otherLeaveBalance.CompassinateRemainingBalance == 0)
                {
                    updatedDtos.CompassinateRemainingBalance = 3;
                    updatedDtos.CompassinateDefaultBalance = 3;
                }
                if (otherLeaveBalance.AbortionLeaveRemainingBalance== 0)
                {
                    updatedDtos.AbortionLeaveRemainingBalance = 30;
                    updatedDtos.AbortionLeaveDefaultBalance = 30;
                }

                if (otherLeaveBalance.MarraiageRemainingBalance == 0)
                {
                    updatedDtos.MarriageDefaultBalance = 3;
                    updatedDtos.MarraiageRemainingBalance = 3;
                }
                if (otherLeaveBalance.MaternityRemainingBalance == 0)
                {
                    updatedDtos.MaternityDefaultBalance = 120;
                    updatedDtos.MaternityRemainingBalance = 120;
                }
                if (otherLeaveBalance.PaternityRemainingBalance == 0)
                {
                    updatedDtos.PaternityRemainingBalance = 7;
                    updatedDtos.PaternityRemainingBalance = 7;
                }


                if (otherLeaveBalance.CourtLeaveRemainingBalance == 0)
                {
                    updatedDtos.CourtLeaveDefaultBalance = 0;
                    updatedDtos.CourtLeaveRemainingBalance = 0;
                }



                var updateCommand = new UpdateOtherLeaveBalanceCommand
                {
                    OtherLeaveBalanceDto = updatedDtos
                };

                await _updateOtherLeaveBalanceCommandHandler.Handle(updateCommand, cancellationToken);

                Console.WriteLine($"Updated leave balance with ID {otherLeaveBalance.Id}");
            }





            return _mapper.Map<List<OtherLeaveBalanceDto>>(activeOtherLeaveBalances);
        }
    }
}
    
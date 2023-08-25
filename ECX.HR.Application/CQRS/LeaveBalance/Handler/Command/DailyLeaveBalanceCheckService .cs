using AutoMapper;
using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Application.CQRS.LeaveBalance.Handler.Command;
using ECX.HR.Application.CQRS.LeaveBalance.Request.Command;
using ECX.HR.Application.DTOs.LeaveBalance;
using ECX.HR.Application.Models;
using ECX.HR.Domain;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MyApplication.BackgroundServices
{
    public class DailyFunctionService : BackgroundService
    {
        private readonly UpdateLeaveBalanceCommandHandler _updateLeaveBalanceCommandHandler;
        private readonly ILeaveBalanceRepository _leaveBalanceRepository;
        private readonly IServiceScopeFactory _serviceScopeFactory;

        private IMapper _mapper;

        public DailyFunctionService(

            IServiceScopeFactory serviceScopeFactory
           )
        {
            _serviceScopeFactory = serviceScopeFactory;

        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            using (var scope = _serviceScopeFactory.CreateScope())
            {
                while (!stoppingToken.IsCancellationRequested)
                {

                    var updateLeaveBalanceHandler = scope.ServiceProvider.GetRequiredService<UpdateLeaveBalanceCommandHandler>();
                    var leaveBalanceRepository = scope.ServiceProvider.GetRequiredService<ILeaveBalanceRepository>();
                    var mapper = scope.ServiceProvider.GetRequiredService<IMapper>();

                    var expiredLeaveBalances = await leaveBalanceRepository.GetExpiredLeaveBalances();

                    foreach (var leaveBalance in expiredLeaveBalances)
                    {

                        TimeSpan differences = leaveBalance.EndDate.Subtract(leaveBalance.StartDate);

                        DateTime employmentStartDate = leaveBalance.EndDate.AddDays(1);

                        int yearsOfWork = (DateTime.Now - employmentStartDate).Days / 365;
                        int maxLeaveDays = 30;
                        int baseLeaveDays = 18;
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

                        var updatedDto = mapper.Map<LeaveBalanceDto>(leaveBalance);
                        updatedDto.Status = 1;
                        updatedDto.EmpId = leaveBalance.EmpId;
                        updatedDto.StartDate = leaveBalance.EndDate.AddDays(days);
                        updatedDto.EndDate = leaveBalance.EndDate.AddDays(days).AddDays(365);
                        updatedDto.AnnualDefaultBalance = annualleaves;

                        updatedDto.SickDefaultBalance = 180;
                        updatedDto.SickRemainingBalance = 180;
                        updatedDto.CompassinateDefaultBalance = 3;
                        updatedDto.CompassinateRemainingBalance = 3;
                        updatedDto.LeaveWotPayDefaultBalance = 90;
                        updatedDto.LeaveWotPayRemainingBalance = 90;
                        updatedDto.EducationDefaultBalance = 5;
                        updatedDto.EducationRemainingBalance = 5;
                        updatedDto.MarriageDefaultBalance = 3;
                        updatedDto.MarraiageRemainingBalance = 3;
                        updatedDto.MaternityDefaultBalance = 120;
                        updatedDto.MaternityRemainingBalance = 120;
                        updatedDto.PaternityDefaultBalance = 15;
                        updatedDto.PaternityRemainingBalance = 15;
                        updatedDto.CourtLeaveDefaultBalance = 0;
                        updatedDto.CourtLeaveRemainingBalance = 0;
                        updatedDto.PreviousYearAnnualBalance = leaveBalance.AnnualDefaultBalance;
                        updatedDto.AnnualRemainingBalance = leaveBalance.AnnualDefaultBalance + annualleaves;




                        var updateCommand = new UpdateLeaveBalanceCommand
                        {
                            LeaveBalanceDto = updatedDto
                        };

                        await updateLeaveBalanceHandler.Handle(updateCommand, stoppingToken);

                        Console.WriteLine($"Updated leave balance with ID {leaveBalance.Id}");
                    }
                }

                Console.WriteLine("Working...");

                await Task.Delay(TimeSpan.FromHours(0.016), stoppingToken);
            }

        }
    }
}

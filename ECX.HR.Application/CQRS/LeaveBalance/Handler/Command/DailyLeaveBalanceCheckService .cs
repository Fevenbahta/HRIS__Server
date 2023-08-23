using ECX.HR.Application.CQRS.LeaveBalance.Request.Command;
using ECX.HR.Application.DTOs.LeaveBalance;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

    using Microsoft.Extensions.Hosting;
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    namespace ECX.HR.Application.CQRS.LeaveBalance.Handler.Command
    {
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using ECX.HR.Application.CQRS.LeaveBalance; // Import your namespace
    using global::ECX.HR.Application.Contracts.Persistence;

    namespace ECX.HR.Application.CQRS.LeaveBalance.Handler.Command
    {
        public class DailyLeaveBalanceCheckService : BackgroundService
        {
            private readonly ILeaveBalanceGenerator _leaveBalanceGenerator;

            public DailyLeaveBalanceCheckService(ILeaveBalanceGenerator leaveBalanceGenerator)
            {
                _leaveBalanceGenerator = leaveBalanceGenerator;
            }

            protected override async Task ExecuteAsync(CancellationToken stoppingToken)
            {
                while (!stoppingToken.IsCancellationRequested)
                {
                    // Implement your logic to check and update leave balances here
                    _leaveBalanceGenerator.Generate();

                    // Wait for 24 hours before checking again
                    await Task.Delay(TimeSpan.FromHours(0.016), stoppingToken);
                }
            }
        }
    }

}



using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MyApplication.BackgroundServices
{
    public class DailyFunctionService : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                // Call your daily function here
                Console.WriteLine("Daily function executed.");

                // Wait for 24 hours before the next execution
                await Task.Delay(TimeSpan.FromHours(0.016), stoppingToken);
            }
        }
    }
}

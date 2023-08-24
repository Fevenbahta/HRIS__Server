using AutoMapper;
using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Application.CQRS.LeaveBalance.Handler.Command;
using ECX.HR.Application.DTOs.Employees;
using ECX.HR.Application.DTOs.LeaveBalance;
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

        private ILeaveBalanceRepository _LeaveBalanceRepository;
        private readonly LeaveBalanceDto _leaveBalanceDto;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly EmployeeDto _employeeDto;
        private IMapper _mapper;
        private readonly IServiceProvider _serviceProvider;

        public DailyFunctionService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                using (var scope = _serviceProvider.CreateScope())
                {
                    // Retrieve the necessary services
                    var LeaveBalanceRepository = scope.ServiceProvider.GetRequiredService<ILeaveBalanceRepository>();
                    var leaveBalanceDto = scope.ServiceProvider.GetRequiredService<LeaveBalanceDto>();
                    var employeeRepository = scope.ServiceProvider.GetRequiredService<IEmployeeRepository>();
                    var employeeDto = scope.ServiceProvider.GetRequiredService<EmployeeDto>();
                    var mapper = scope.ServiceProvider.GetRequiredService<IMapper>();

                    // Create a new instance of CreateLeaveBalanceCommandHandler
                    var leaveBalanceHandler = new CreateLeaveBalanceCommandHandler(LeaveBalanceRepository, leaveBalanceDto, employeeRepository, employeeDto, mapper);

                    leaveBalanceHandler.generate(); // Call the generate method
                    Console.WriteLine("workinggggggggg");
                } // Dispose of scoped services at the end of the 'using' block

                await Task.Delay(TimeSpan.FromHours(0.016), stoppingToken); // Delay for one day (24 hours)
            }
        }

    }
}

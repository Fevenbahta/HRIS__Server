
using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Application.Contracts.Persistent;
using ECX.HR.Application.CQRS.LeaveBalance.Handler.Command;
using ECX.HR.Application.CQRS.LeaveBalance.Request.Command;
using ECX.HR.Application.CQRS.OtherLeaveBalance.Handler.Command;
using ECX.HR.Application.DTOs.Employees;
using ECX.HR.Application.DTOs.LeaveBalance;
using ECX.HR.Persistence.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Persistence
{
    public static partial class PersistenceServiceRegistrtion
    {
        public static IServiceCollection ConfigurePersistenceService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ECXHRDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("staggingConnectionString")));
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IAdressRepository, AdressRepository>();
            services.AddScoped<IAllwoanceRepository, AllowanceRepository>();
            services.AddScoped<IBranchRepository, BranchrRepository>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IDepositAutorizationRepository, DepositAutorizationRepository>();
            services.AddScoped<IDivisionRepository, DivisionRepository>();
            services.AddScoped<IEducationLevelRepository, EducationLevelRepository>();
            services.AddScoped<IEducationRepository, EducationRepository>();
            services.AddScoped<IEmergencyContactRepository, EmergencyContactRepository>();
            services.AddScoped<IEmployeePositionRepository, EmployeePositionRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IEmployeeStatusRepository, EmployeeStatusRepository>();
            services.AddScoped<ILevelRepository, LevelRepository>();
            services.AddScoped<IOrganizationalProfileRepository, OrganizationalProfileRepository>();
            services.AddScoped<IPositionRepository, PositionRepository>();
            services.AddScoped<ISalaryRepository, SalaryRepsitory>();
            services.AddScoped<ISpouseRepository, SpouseRepository>();
            services.AddScoped<IStepRepository, StepRepository>();
            services.AddScoped<ISupervisiorRepository, SupervisorRepository>();
            services.AddScoped<ITrainingRepository, TrainingRepository>();
            services.AddScoped<IWorkExperienceRepository, WorkExperienceRepository>();
            services.AddScoped<IAssignSupervisorRepository, AssignSupervisorRepository > ();
            services.AddScoped<ILeaveBalanceRepository,LeaveBalanceRepository>();
            services.AddScoped<IOtherLeaveBalanceRepository, OtherLeaveBalanceRepository>();
            services.AddScoped<ILeaveTypeRepository, LeaveTypeRepository>();
            services.AddScoped<ILeaveRequestRepository, LeaveRequestRepository>();
            services.AddScoped<IPromotionRepository, PromotionRepository>();
            services.AddScoped<IPromotionRelationRepository, PromotionRelationRepository>();
            services.AddScoped<IActingAssigmentRepository, ActingAssigmentRepository>();
            services.AddScoped<ITerminationRepository, TerminationRepository>();

            services.AddScoped<IHolidayRepository, HolidayRepository>();


            services.AddScoped<EmployeeDto>(); // This registers EmployeeDto for dependency injection
            
    
            services.AddScoped<AnnualLeaveBalanceDto>();

            services.AddScoped<UpdateLeaveBalanceCommandHandler>();
            //services.AddScoped<EmployeeDataServices>();
        

            // Inside ConfigureServices method in Startup.cs
            services.AddScoped<UpdateOtherLeaveBalanceCommandHandler>();

            services.AddScoped<IPromotionVacancyRepository, PromotionVacancyRepository>();

            return services;
        }

    }
}

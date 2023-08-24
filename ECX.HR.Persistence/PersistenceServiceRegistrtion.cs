
using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Application.Contracts.Persistent;
using ECX.HR.Application.DTOs.Employees;
using ECX.HR.Persistence.Repositories;
using Hangfire;
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
            services.AddScoped<ILeaveTypeRepository, LeaveTypeRepository>();
            services.AddScoped<ILeaveRequestRepository, LeaveRequestRepository>();
            services.AddScoped<EmployeeDto>(); // This registers EmployeeDto for dependency injection

            
           

            return services;
        }

    }
}

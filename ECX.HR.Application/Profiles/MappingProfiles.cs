using AutoMapper;
using ECX.HR.Application.DTOs.Addresss;
using ECX.HR.Application.DTOs.Allowances.cs;
using ECX.HR.Application.DTOs.Branchs;
using ECX.HR.Application.DTOs.Department;
using ECX.HR.Application.DTOs.DepositAutorizations;
using ECX.HR.Application.DTOs.Division;
using ECX.HR.Application.DTOs.Education;
using ECX.HR.Application.DTOs.EducationLevels;
using ECX.HR.Application.DTOs.EmergencyContacts;
using ECX.HR.Application.DTOs.EmployeePositions;
using ECX.HR.Application.DTOs.Employees;
using ECX.HR.Application.DTOs.OrganizationalProfiles;
using ECX.HR.Application.DTOs.Levels;
using ECX.HR.Application.DTOs.OrganizationalProfiles;
using ECX.HR.Application.DTOs.Positions;
using ECX.HR.Application.DTOs.Salaries;
using ECX.HR.Application.DTOs.Spouses;
using ECX.HR.Application.DTOs.Supervisors;
using ECX.HR.Application.DTOs.Trainings;
using ECX.HR.Application.DTOs.WorkExperiences;
using ECX.HR.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECX.HR.Application.DTOs.EmployeeStatuss;
using ECX.HR.Application.CQRS.Addresss.Request.Queries;
using ECX.HR.Application.CQRS.Employee.Request.Queries;
using ECX.HR.Application.DTOs.Step;
using ECX.HR.Application.DTOs.AssignSupervisor;
using ECX.HR.Application.DTOs.LeaveBalance;
using ECX.HR.Application.DTOs.Leave;
using ECX.HR.Application.DTOs.PromotionVacancy;
using ECX.HR.Application.DTOs.Promotion;
using ECX.HR.Application.DTOs.PromotionRelation;
using ECX.HR.Application.DTOs.ActingAssigment;
using ECX.HR.Application.DTOs.Termination;
using ECX.HR.Application.DTOs.Holiday;
using ECX.HR.Application.CQRS.Attendance;

namespace ECX.HR.Application.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Adress, AddressDto>().ReverseMap();
           
            CreateMap<Allowancee, AllowanceDto>().ReverseMap();
            CreateMap<Branches, BranchDto>().ReverseMap();
            CreateMap<Department, DepartmentDto>().ReverseMap();
            CreateMap<DepositAutorizations, DepositAutorizationDto>().ReverseMap();
            CreateMap<Divisions, DivisionDto>().ReverseMap();
            CreateMap<Educations, EducationDto>().ReverseMap();
            CreateMap<EducationLevels, EducationLevelDto>().ReverseMap();
            CreateMap<EmergencyContacts, EmergencyContactDto>().ReverseMap();
            CreateMap<EmployeePositions, EmployeePositionDto>().ReverseMap();
            CreateMap<Employees, EmployeeDto>().ReverseMap();
            CreateMap<Employees, EmpCreateDto>().ReverseMap();
            CreateMap<EmployeeStatuss, EmployeeStatusDto>().ReverseMap();
            CreateMap<Levels, LevelDto>().ReverseMap();
            CreateMap<OrganizationalProfiles, OrganizationalProfileDto>().ReverseMap();
            CreateMap<Positions, PositionDto>().ReverseMap();
            CreateMap<SalaryTypes, SalaryTypeDto>().ReverseMap();
            CreateMap<Spouses, SpouseDto>().ReverseMap();
            CreateMap<Steps, StepDto>().ReverseMap();
            CreateMap<Supervisors, SupervisorDto>().ReverseMap();
            CreateMap<Trainings, TrainingDto>().ReverseMap();
            CreateMap<WorkExperiences, WorkExperienceDto>().ReverseMap();
            CreateMap<AssignSupervisorss, AssignSupervisorDto>().ReverseMap();
            CreateMap<AnnualLeaveBalances, AnnualLeaveBalanceDto>().ReverseMap();
            CreateMap<OtherLeaveBalances, OtherLeaveBalanceDto>().ReverseMap();
            CreateMap<LeaveTypes, LeaveTypeDto>().ReverseMap();
            CreateMap<LeaveRequests, LeaveRequestDto>().ReverseMap();
            CreateMap<PromotionVacancys, PromotionVacancyDto>().ReverseMap();
            CreateMap<Promotions, PromotionDto>().ReverseMap();
            CreateMap<PromotionRelations, PromotionRelationDto>().ReverseMap();
            CreateMap<ActingAssigments, ActingAssigmentDto>().ReverseMap();
            CreateMap<Terminations, TerminationDto>().ReverseMap();
            CreateMap<Holidays, HolidayDto>().ReverseMap();
            CreateMap<Attendances, AttendanceDto>().ReverseMap();

        }
    }
}

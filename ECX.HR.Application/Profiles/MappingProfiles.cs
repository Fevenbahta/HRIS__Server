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

namespace ECX.HR.Application.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Adress, AdressDetailDto>().ReverseMap();
            CreateMap<Allowance, AllowanceDto>().ReverseMap();
            CreateMap<Branch, BranchDto>().ReverseMap();
            CreateMap<Department, DepartmentDto>().ReverseMap();
            CreateMap<DepositAutorization, DepositAutorizationDto>().ReverseMap();
            CreateMap<Division, DivisionDto>().ReverseMap();
            CreateMap<Education, EducationDto>().ReverseMap();
            CreateMap<EducationLevel, EducationLevelDto>().ReverseMap();
            CreateMap<EmergencyContact, EmergencyContactDto>().ReverseMap();
            CreateMap<EmployeePosition, EmployeePositionDto>().ReverseMap();
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<EmployeeStatus, EmployeeStatusDto>().ReverseMap();
            CreateMap<Level, LevelDto>().ReverseMap();
            CreateMap<OrganizationalProfile, OrganizationalProfileDto>().ReverseMap();
            CreateMap<Position, PositionDto>().ReverseMap();
            CreateMap<Salary, SalaryDto>().ReverseMap();
            CreateMap<Spouses, SpouseDto>().ReverseMap();
            CreateMap<Supervisors, SupervisorDto>().ReverseMap();
            CreateMap<Trainings, TrainingDto>().ReverseMap();
            CreateMap<WorkExperiences, WorkExperienceDto>().ReverseMap();
        }
    }
}

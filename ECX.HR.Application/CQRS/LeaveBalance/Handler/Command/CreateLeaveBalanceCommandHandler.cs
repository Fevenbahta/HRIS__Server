using AutoMapper;
using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Application.CQRS.LeaveBalance.Request.Command;
using ECX.HR.Application.DTOs.Employees;
using ECX.HR.Application.DTOs.Leave;
using ECX.HR.Application.DTOs.LeaveBalance.Validator;
using ECX.HR.Application.Exceptions;

using ECX.HR.Application.Response;
using ECX.HR.Domain;
using MediatR;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.LeaveBalance.Handler.Command
{
    public class CreateLeaveBalanceCommandHandler : IRequestHandler<CreateLeaveBalanceCommand, BaseCommandResponse>
    {
        BaseCommandResponse response;
        private ILeaveBalanceRepository _LeaveBalanceRepository;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly EmployeeDto _employeeDto;
        private IMapper _mapper;
        public CreateLeaveBalanceCommandHandler(ILeaveBalanceRepository LeaveBalanceRepository,IEmployeeRepository employeeRepository,
             EmployeeDto employeeDto, IMapper mapper)
        {
            _LeaveBalanceRepository = LeaveBalanceRepository;
            _employeeRepository = employeeRepository;
            _employeeDto = employeeDto;
            _mapper = mapper;
        }
        public async Task<BaseCommandResponse> Handle(CreateLeaveBalanceCommand request, CancellationToken cancellationToken)
        {
            response = new BaseCommandResponse();
            var validator =new LeaveBalanceDtoValidator();
            var validationResult =await validator.ValidateAsync(request.LeaveBalanceDto);
            
            if(validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Creation Faild";
                response.Errors= validationResult.Errors.Select(x => x.ErrorMessage).ToList();
            }
           
            var LeaveBalance = _mapper.Map<LeaveBalances>(request.LeaveBalanceDto);
            LeaveBalance.Id = Guid.NewGuid();

            var emp = await _employeeRepository.GetById(LeaveBalance.EmpId);
            DateTime employmentStartDate =emp.JoinDate;

            int daysElapsed = 365;
           
           LeaveBalance.EndDate = employmentStartDate.AddDays(daysElapsed);

            int yearsOfWork = (DateTime.Now - employmentStartDate).Days / 365; 
            int maxLeaveDays = 30;
            int baseLeaveDays = 18;
            int additionalLeavePerYear = 1; 
           int totalLeaveDays = baseLeaveDays + Math.Min(yearsOfWork - 1, maxLeaveDays - baseLeaveDays) * additionalLeavePerYear;
            if (yearsOfWork >= 1)
            {
                LeaveBalance.AnnualDefaultBalance = baseLeaveDays + Math.Min(yearsOfWork - 1, maxLeaveDays - baseLeaveDays) * additionalLeavePerYear;
            }
            else
            {
                LeaveBalance.AnnualDefaultBalance = baseLeaveDays;
            }
           
            
            LeaveBalance.AnnualRemainingBalance = LeaveBalance.AnnualDefaultBalance;
            LeaveBalance.SickDefaultBalance = 180;
            LeaveBalance.SickRemainingBalance=LeaveBalance.SickDefaultBalance;
            LeaveBalance.CompassinateDefaultBalance = 3;
            LeaveBalance.CompassinateRemainingBalance = LeaveBalance.CompassinateDefaultBalance;
            LeaveBalance.LeaveWotPayDefaultBalance = 90;
            LeaveBalance.LeaveWotPayRemainingBalance = LeaveBalance.LeaveWotPayDefaultBalance;
            LeaveBalance.EducationDefaultBalance = 5;
            LeaveBalance.EducationRemainingBalance = LeaveBalance.EducationDefaultBalance;
            LeaveBalance.MarriageDefaultBalance = 3;
            LeaveBalance.MarraiageRemainingBalance = LeaveBalance.MarriageDefaultBalance;
            LeaveBalance.MaternityDefaultBalance = 120;
            LeaveBalance.MaternityRemainingBalance = LeaveBalance.MarriageDefaultBalance;
            LeaveBalance.PaternityDefaultBalance = 15;
            LeaveBalance.PaternityRemainingBalance = LeaveBalance.PaternityDefaultBalance;
            LeaveBalance.CourtLeaveDefaultBalance = 0;
            LeaveBalance.CourtLeaveRemainingBalance = LeaveBalance.CourtLeaveDefaultBalance;
        
          

        var add = LeaveBalance.Id;
            var data =await _LeaveBalanceRepository.Add(LeaveBalance);
            response.Success = true;
            response.Message = "Creation Successfull";
            response.Id = (Guid)add;
            return response;
        }
    }
}

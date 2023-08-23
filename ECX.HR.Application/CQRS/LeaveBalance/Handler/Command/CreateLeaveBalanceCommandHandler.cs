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
        private readonly EmployeeDto _employeeDto;
        private IMapper _mapper;
        public CreateLeaveBalanceCommandHandler(ILeaveBalanceRepository LeaveBalanceRepository,
             EmployeeDto employeeDto, IMapper mapper)
        {
            _LeaveBalanceRepository = LeaveBalanceRepository;
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

            DateTime employmentStartDate = _employeeDto.JoinDate;
            int yearsOfWork = (DateTime.Now - employmentStartDate).Days / 365; 
            int maxLeaveDays = 30;
            int baseLeaveDays = 18;
            int additionalLeavePerYear = 1; 
           int totalLeaveDays = baseLeaveDays + Math.Min(yearsOfWork - 1, maxLeaveDays - baseLeaveDays) * additionalLeavePerYear;
          
            LeaveBalance.AnnualDefaultBalance= totalLeaveDays;
            LeaveBalance.SickDefaultBalance = 180;
            LeaveBalance.CompassinateDefaultBalance = 3;
            LeaveBalance.LeaveWotPayDefaultBalance = 90;
            LeaveBalance.EducationDefaultBalance = 5;
            LeaveBalance.MarriageDefaultBalance = 3;
            LeaveBalance.MaternityDefaultBalance = 120;
            LeaveBalance.PaternityDefaultBalance = 15;
            LeaveBalance.CourtLeaveDefaultBalance = 0;
        

        var add = LeaveBalance.Id;
            var data =await _LeaveBalanceRepository.Add(LeaveBalance);
            response.Success = true;
            response.Message = "Creation Successfull";
            response.Id = (Guid)add;
            return response;
        }
    }
}

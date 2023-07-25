using AutoMapper;
using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Application.Contracts.Persistent;
using ECX.HR.Application.CQRS.Employee.Request.Command;

using ECX.HR.Application.DTOs.Employees.Validator;
using ECX.HR.Application.Exceptions;

using ECX.HR.Application.Response;
using ECX.HR.Domain;
using MediatR;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.Employee.Handler.Command
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, BaseCommandResponse>
    {
        BaseCommandResponse response;
        private IEmployeeRepository _EmployeeRepository;
        private IMapper _mapper;
        public CreateEmployeeCommandHandler(IEmployeeRepository EmployeeRepository, IMapper mapper)
        {
            _EmployeeRepository = EmployeeRepository;
            _mapper = mapper;
        }
        public async Task<BaseCommandResponse> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            response = new BaseCommandResponse();
            var validator =new EmployeeDtoValidators();
            var validationResult =await validator.ValidateAsync(request.EmployeeDto);
            
            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Creation Faild";
                response.Errors= validationResult.Errors.Select(x => x.ErrorMessage).ToList();
            }
           
            var Employee = _mapper.Map<Employees>(request.EmployeeDto);
            Employee.EmpId = Guid.NewGuid();
            var emp = Employee.EmpId;
            var data =await _EmployeeRepository.Add(Employee);
            response.Success = true;
            response.Message = "Creation Successfull";
            response.Id = (Guid)emp;


            return response;
        }
    }
}

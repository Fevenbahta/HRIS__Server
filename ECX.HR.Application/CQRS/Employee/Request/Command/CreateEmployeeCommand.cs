
using ECX.HR.Application.DTOs.Employees;
using ECX.HR.Application.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.Employee.Request.Command
{
    public class CreateEmployeeCommand : IRequest<BaseCommandResponse>
    {
        public EmployeeDto EmployeeDto { get; set; }
    }
}

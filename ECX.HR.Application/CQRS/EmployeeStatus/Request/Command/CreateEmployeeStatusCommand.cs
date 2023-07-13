using ECX.HR.Application.DTOs.EmployeeStatus;
using ECX.HR.Application.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.EmployeeStatus.Request.Command
{
    public class CreateEmployeeStatusCommand : IRequest<BaseCommandResponse>
    {
        public EmployeeStatusDto EmployeeStatusDto { get; set; }
    }
}

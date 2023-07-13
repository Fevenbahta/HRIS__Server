using ECX.HR.Application.DTOs.EmployeeStatus;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.EmployeeStatus.Request.Command
{
    public class UpdateEmployeeStatusCommand :IRequest<Unit>
    {
        public EmployeeStatusDto EmployeeStatusDto { get; set; }
    }
}

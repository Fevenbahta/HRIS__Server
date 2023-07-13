using ECX.HR.Application.DTOs.Salary;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.Salary.Request.Command
{
    public class UpdateSalaryCommand :IRequest<Unit>
    {
        public SalaryDto SalaryDto { get; set; }
    }
}

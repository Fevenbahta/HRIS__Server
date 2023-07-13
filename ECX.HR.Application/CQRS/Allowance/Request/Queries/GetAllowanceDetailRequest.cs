using ECX.HR.Application.DTOs.Allowance;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.Allowance.Request.Queries
{
    public class GetAllowanceDetailRequest :IRequest<AllowanceDto>
    {
        public int Id { get; set; }
    }
}

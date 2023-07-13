using ECX.HR.Application.DTOs.DepositAutorization;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.DepositAutorization.Request.Queries
{
    public class GetDepositAutorizationDetailRequest :IRequest<DepositAutorizationDto>
    {
        public int Id { get; set; }
    }
}

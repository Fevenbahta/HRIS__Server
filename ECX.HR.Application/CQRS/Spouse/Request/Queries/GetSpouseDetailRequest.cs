using ECX.HR.Application.DTOs.Spouse;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.Spouse.Request.Queries
{
    public class GetSpouseDetailRequest :IRequest<SpouseDto>
    {
        public int Id { get; set; }
    }
}

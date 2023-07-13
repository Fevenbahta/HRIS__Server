using ECX.HR.Application.DTOs.EmployeePosition;

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.EmployeePosition.Request.Queries
{
    public class GetDepartmentListRequest :IRequest<List<DepartmentDto>>
    {
       
    }
}

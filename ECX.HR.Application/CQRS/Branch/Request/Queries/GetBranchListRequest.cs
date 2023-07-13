﻿using ECX.HR.Application.DTOs.Branch;

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.Branch.Request.Queries
{
    public class GetBranchListRequest :IRequest<List<BranchDto>>
    {
       
    }
}

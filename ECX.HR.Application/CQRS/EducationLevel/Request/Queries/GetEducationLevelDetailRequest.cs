﻿using ECX.HR.Application.DTOs.EducationLevel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.EducationLevel.Request.Queries
{
    public class GetEducationLevelDetailRequest :IRequest<EducationLevelDto>
    {
        public int Id { get; set; }
    }
}

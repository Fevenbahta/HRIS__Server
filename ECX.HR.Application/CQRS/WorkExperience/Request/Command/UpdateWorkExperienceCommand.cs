﻿using ECX.HR.Application.DTOs.WorkExperience;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.WorkExperience.Request.Command
{
    public class UpdateWorkExperienceCommand :IRequest<Unit>
    {
        public WorkExperienceDto WorkExperienceDto { get; set; }
    }
}
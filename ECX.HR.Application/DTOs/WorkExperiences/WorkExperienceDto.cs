﻿using ECX.HR.Application.DTOs.Common;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.DTOs.WorkExperiences
{
    public class WorkExperienceDto : BaseDtos
    {
        public Guid EmpId { get; set; }
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string PostionHeld { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public double Salary { get; set; }
        public string ReasonTermination { get; set; }

    }
}

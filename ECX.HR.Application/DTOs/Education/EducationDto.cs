﻿using ECX.HR.Application.DTOs.Common;
using ECX.HR.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.DTOs.Education
{
    public class EducationDto : BaseDtos
    {
        public Guid EmpId { get; set; }
        public Guid id { get; set; }
        public string NameOfInstitute { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string FieldOfStudy { get; set; }


        public string EductionName { get; set; }

       
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Domain
{
    public  class EmployeePosition 
    {
        public int id { get; set; }
        public string DivisionId { get; set; }
        public string StepId { get; set; }
        public string BranchId { get; set; }
        public string position { get; set; }
        public string Status { get; set; }
        public DateTime StartDate { get; set; } 
        public DateTime EndDate { get; set;}

    }
}

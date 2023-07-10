﻿using ECX.HR.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Domain
{
    public class Allowance :BaseDomainEntity
    {
        public int Id { get; set; }
        public string AllowanceType { get; set; }
        public string Position { get; set; }
        public string Step { get; set; }
        public bool Rate { get; set; }
        public double RatePercent { get; set; }
    }
}

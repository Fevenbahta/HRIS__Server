﻿using ECX.HR.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Domain
{
    public class SalaryTypes :BaseDomainEntity
    {
       
        public Guid Id { get; set; }
        public string Description { get; set; }
        
    }
}

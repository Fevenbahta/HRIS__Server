﻿using ECX.HR.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.DTOs.EmployeeStatuss
{
    public class EmployeeStatusDto : BaseDtos
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}

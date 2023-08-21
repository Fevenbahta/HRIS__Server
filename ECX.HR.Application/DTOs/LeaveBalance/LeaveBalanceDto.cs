﻿using ECX.HR.Application.DTOs.Common;
using ECX.HR.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.DTOs.LeaveBalance
{
    public class LeaveBalanceDto : BaseDtos
    {
        public int PId { get; set; }
        public Guid Id { get; set; }
        public Guid? EmpId { get; set; }
        public Guid LeaveTypeId { get; set; }
        public Decimal DefaultBalance { get; set; }
        public Decimal RemainingBalance { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int IsExpired { get; set; }

        public int Status { get; set; }
    }
}

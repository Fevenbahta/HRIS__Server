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
        public Guid EmpId { get; set; }
        public Decimal AnnualDefaultBalance { get; set; }
        public Decimal AnnualRemainingBalance { get; set; }
        public Decimal PreviousYearAnnualBalance { get; set; }
    
        public Decimal SickDefaultBalance { get; set; }
        public Decimal SickRemainingBalance { get; set; }
        public Decimal MaternityDefaultBalance { get; set; }
        public Decimal MaternityRemainingBalance { get; set; }
        public Decimal PaternityDefaultBalance { get; set; }
        public Decimal PaternityRemainingBalance { get; set; }
        public Decimal CompassinateDefaultBalance { get; set; }
        public Decimal CompassinateRemainingBalance { get; set; }
        public Decimal EducationDefaultBalance { get; set; }
        public Decimal EducationRemainingBalance { get; set; }
        public Decimal MarriageDefaultBalance { get; set; }
        public Decimal MarraiageRemainingBalance { get; set; }
        public Decimal LeaveWotPayDefaultBalance { get; set; }
        public Decimal LeaveWotPayRemainingBalance { get; set; }
        public Decimal CourtLeaveDefaultBalance { get; set; }
        public Decimal CourtLeaveRemainingBalance { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime SickEndDate { get; set; }

        public DateTime CurrentYear { get; set; }
        public int IsExpired { get; set; }
        public int Status { get; set; }
    }
}

using ECX.HR.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.CQRS.Attendance
{
    public class AttendanceDto : BaseDtos
    {


        public int PId { get; set; }
        public string AttendanceId { get; set; }
   
        public Guid? EmpId { get; set; }

        public DateTime? date { get; set; }
        public string? TimeTable { get; set; }

        public TimeSpan? OnDuty { get; set; }

        public TimeSpan? OffDuty { get; set; }

        public TimeSpan? ClockIn { get; set; }

        public TimeSpan? ClockOut { get; set; }

        public string? Department { get; set; }
        public Decimal? Normall { get; set; }
        public Decimal? RealTime { get; set; }
        public TimeSpan? Late { get; set; }
        public TimeSpan? Early { get; set; }
        public int? Status { get; set; }
        public string? AttendanceStatus { get; set; }
        public Decimal? TotalLE { get; set; }
        public Decimal? AbsentDays { get; set; }
        public string? LeaveType { get; set; }
    }
}

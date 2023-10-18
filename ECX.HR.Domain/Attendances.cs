using ECX.HR.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Domain
{
    public class Attendances : BaseDomainEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PId { get; set; }
        [Key]

        public Guid Id { get; set; }
        [ForeignKey("Employees")]
        public Guid? EmpId { get; set; }
        public string EmployeeName { get; set; }
        public DateTime date { get; set; }
        public string TimeTable { get; set; }
        public TimeOnly OnDuty {  get; set; }
        public TimeOnly OffDuty { get; set; }
        public TimeOnly ClockIn { get; set; }
        public TimeOnly ClockOut { get; set; }
        public string Department { get; set; }
        public Decimal Normall { get; set; }
        public Decimal RealTime { get; set; }
        public Decimal Late { get; set; }
        public int Status { get; set; }
        public string AttendanceStatus { get; set; }
        public Decimal AbsentDays { get ; set; }    
        public string LeaveType { get; set; }

    }
}

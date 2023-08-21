using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using ECX.HR.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace ECX.HR.Domain
{
    public class LeaveBalances :BaseDomainEntity
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PId { get; set; }
        
        [Key]
      
        public Guid Id { get; set; }
        [ForeignKey("Employees")]
        public Guid? EmpId { get; set; }
        [ForeignKey("LeaveType")]
        public Guid LeaveTypeId { get; set; }
        public Decimal DefaultBalance { get; set; }
        public Decimal RemainingBalance { get; set; }
        public DateTime StartDate { get; set; }  
        public DateTime EndDate { get; set; }

        public int IsExpired { get; set; }   
     
        public int Status { get; set; }
        public virtual Employees Employees { get; set; }
    }
}

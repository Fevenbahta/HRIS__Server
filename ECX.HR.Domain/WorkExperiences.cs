using ECX.HR.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Domain
{
    public class WorkExperiences : BaseDomainEntity
    {
        
        public Guid EmpId { get; set; }
        public Guid Id { get; set; }
        public string CompanyName { get; set; }
        public string PostionHeld { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public double Salary { get; set; }
        public string ReasonTermination { get; set; }
        public virtual Employees Employees { get; set; }


    }
}

using ECX.HR.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Domain
{
    public class Training :BaseDomainEntity
    {
        
        public Guid EmpId { get; set; }
        public int id { get; set; }
        public Employee Employee { get; set; }
        public string TypeOfTraining { get; set; }
        public DateTime From { get; set; }  
        public DateTime To { get; set; }

        public virtual Employee Employees { get; set; }


    }
}

using ECX.HR.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Domain
{
    public class EmergencyContact :BaseDomainEntity
    {
        
        public Guid EmpId { get; set; }
        public int id { get; set; }
        public Employees Employee { get; set; }
        public string Name { get; set; }    
        public string Town { get; set; }
        public string Region { get; set; }
      
        public string SubCity { get; set; }
        public string Kebele { get; set; }
        public string HouseNo { get; set; }
        public int PhoneNumber { get; set; }
        
        public string Relationship { get; set; }

        public virtual Employees Employees { get; set; }
        
    }
}

using ECX.HR.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Domain
{
    public class Spouse :BaseDomainEntity
    {
       
        public Guid EmpId { get; set; }
        public Employees Employee { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Relationship { get; set; }
        public virtual Employees Employees { get; set; } 

    }
}

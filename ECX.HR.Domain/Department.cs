using ECX.HR.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Domain
{
    public class Department :BaseDomainEntity
    {
        public Guid DepartmentId { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Divisions> Divisions { get; set; }    
       
    }
}

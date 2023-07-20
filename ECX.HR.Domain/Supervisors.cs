using ECX.HR.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Domain
{
    public class Supervisors : BaseDomainEntity
    {
        public Guid Id { get; set; }
        public Guid EmpId { get; set; }
       
        public string SupervisorLevel { get; set; }
        
    }
}

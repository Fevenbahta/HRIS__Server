using ECX.HR.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Domain
{
    public class Education : BaseDomainEntity
    {
        
        public Guid EmpId { get; set; }
        public Guid id { get; set; }
        public string NameOfInstitute { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string FieldOfStudy { get; set; }

        
        public string EductionName { get; set; }

        public virtual Employees Employees { get; set; }
    }
}

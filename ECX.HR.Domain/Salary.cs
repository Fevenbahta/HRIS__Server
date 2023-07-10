using ECX.HR.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Domain
{
    public class Salary :BaseDomainEntity
    {
        [ForeignKey("Employeee")]
        public Guid EmpId { get; set; }
        public int Id { get; set; }
        public Employee Employee { get; set; }
        public string step { get; set; }
        public string Currency { get; set; }
        public string BasicSalary { get; set; }
    }
}

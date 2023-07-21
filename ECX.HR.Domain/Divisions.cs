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
    public class Divisions : BaseDomainEntity
    {
        public int PId { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid DivisionId { get; set; }
        public Guid DepartmentId { get; set; }
        public virtual Department Departments { get; set; }
        public string Description { get; set; }
        public ICollection<Positions> Positions { get; set; }
        public int Status { get; set; }
    }
}

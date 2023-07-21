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
    public class Steps : BaseDomainEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Description { get; set; }
        public decimal Salary { get; set; }
        [ForeignKey("SalaryTypes")]
        public Guid SalaryTypeId { get; set; }
   
        public Guid LevelId { get; set; }
        public virtual Levels Levels { get; set; }
    }
}

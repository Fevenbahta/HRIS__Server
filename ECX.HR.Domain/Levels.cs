using ECX.HR.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ECX.HR.Domain
{
    public class Levels : BaseDomainEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid LevelId { get; set; }
        [ForeignKey("Position")]
        public Guid PositionId { get; set; }
       
           
        public string Description { get; set; }

        public ICollection<Steps> Steps { get; set;}
    }
}

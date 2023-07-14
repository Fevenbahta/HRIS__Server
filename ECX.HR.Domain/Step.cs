using ECX.HR.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Domain
{
    public class Step : BaseDomainEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Guid LevelId { get; set; }
        public virtual Levels Levels { get; set; }

    }
}

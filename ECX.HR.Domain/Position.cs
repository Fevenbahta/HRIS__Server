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
    public class Position :BaseDomainEntity
    {
        
        public Guid PositionId { get; set; }
        public Guid DivisionId { get; set; }
        public virtual Division Divisions { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}

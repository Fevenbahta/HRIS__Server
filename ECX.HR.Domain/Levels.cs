using ECX.HR.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace ECX.HR.Domain
{
    public class Levels :BaseDomainEntity
    {
        [ForeignKey("Position")]
        public int posId { get; set; }
        public Positions position { get; set; }
        public Guid LevelID { get; set; }    
        public string name { get; set; }

        public ICollection<Step> Steps { get; set;}
    }
}

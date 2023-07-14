using ECX.HR.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Domain
{
    public class Branches : BaseDomainEntity
    {
        public int Id { get; set; }
        public string name { get; set; }
         public string city { get; set; }

    }
}

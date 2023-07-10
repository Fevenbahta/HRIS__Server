using ECX.HR.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Domain
{
    public class Supervisor : BaseDomainEntity
    {
        public int Id { get; set; }
        public string AdId { get; set; }
        public string Name { get; set; }

        public string SupervisorLevel { get; set; }
    }
}

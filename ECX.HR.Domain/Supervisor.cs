using ECX.HR.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Domain
{
    public class Supervisor : BaseDomainEntity
    {
        public int Id { get; set; }
        [ForeignKey("Division")]
        public Guid DivisionId { get; set; }
        public string Name { get; set; }

        public string FirstSupervisor { get; set; }
        public string SecondSupervisor { get; set; }
    }
}

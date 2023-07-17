using ECX.HR.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.DTOs.Supervisors
{
    public class SupervisorDto : BaseDtos
    {
        public Guid Id { get; set; }
        public string AdId { get; set; }
        public string Name { get; set; }

        public string SupervisorLevel { get; set; }
    }
}

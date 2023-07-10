using ECX.HR.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Domain
{
    public class EducationLevel : BaseDomainEntity

    {
        public int id { get; set; }
        public string EducationName { get; set; }
    }
}

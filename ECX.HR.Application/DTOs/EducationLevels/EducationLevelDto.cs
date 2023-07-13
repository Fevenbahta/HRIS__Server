using ECX.HR.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.DTOs.EducationLevels
{
    public class EducationLevelDto : BaseDtos {
        public int id { get; set; }
        public string EducationName { get; set; }
    }
}

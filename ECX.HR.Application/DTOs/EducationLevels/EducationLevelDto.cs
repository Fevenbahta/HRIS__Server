using ECX.HR.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.DTOs.EducationLevels
{
    public class EducationLevelDto : BaseDtos {
       
        public Guid Id { get; set; }
        public string EducationName { get; set; }
        public int Status { get; set; }
    }
}

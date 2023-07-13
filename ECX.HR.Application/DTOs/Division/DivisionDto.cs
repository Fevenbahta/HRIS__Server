using ECX.HR.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.DTOs.Division
{
    public class DivisionDto : BaseDtos
    {
        public Guid DivisionId { get; set; }
        public string Name { get; set; }
        public Guid DepartmentId { get; set; }
       
    }
}

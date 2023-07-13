using ECX.HR.Application.DTOs.Common;
using ECX.HR.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.DTOs.Salaries
{
    public class SalaryDto : BaseDtos
    {
        public Guid EmpId { get; set; }
        public int Id { get; set; }
        
        public string step { get; set; }
        public string Currency { get; set; }
        public string BasicSalary { get; set; }
    }
}

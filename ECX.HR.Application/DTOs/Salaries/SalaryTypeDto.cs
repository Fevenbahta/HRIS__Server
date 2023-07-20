using ECX.HR.Application.DTOs.Common;
using ECX.HR.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.DTOs.Salaries
{
    public class SalaryTypeDto : BaseDtos
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
    }
}

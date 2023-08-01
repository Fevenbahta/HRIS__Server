using ECX.HR.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.DTOs.Allowances.cs
{
    public class AllowanceDto : BaseDtos
    {
       
        public Guid Id { get; set; }
        public string AllowanceType { get; set; }
        public string Position { get; set; }
        public string Step { get; set; }
        public bool Rate { get; set; }
        public double RatePercent { get; set; }
        public int Status { get; set; }
    }
}

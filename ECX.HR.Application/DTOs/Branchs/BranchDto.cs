using ECX.HR.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.DTOs.Branchs
{
    public class BranchDto : BaseDtos
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string city { get; set; }
    }
}

using ECX.HR.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.DTOs.Positions
{
    public class PositionDto : BaseDtos
    {
        public Guid PositionId { get; set; }
        public Guid DivisionId { get; set; }
       
        public string Name { get; set; }
        public string Description { get; set; }
    }
}

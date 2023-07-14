using ECX.HR.Application.DTOs.Common;
using ECX.HR.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.DTOs.Levels
{
    public class LevelDto : BaseDtos
    {
        public int posId { get; set; }
       
        public Guid LevelID { get; set; }
        public string Name { get; set; }
    }
}

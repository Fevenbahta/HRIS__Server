using ECX.HR.Application.DTOs.Common;
using ECX.HR.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.DTOs.Step

{
   public class StepDto: BaseDtos
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Guid LevelId { get; set; }
      
    }
}


﻿using ECX.HR.Application.DTOs.Common;
using ECX.HR.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.DTOs.Trainings
{
    public class TrainingDto : BaseDtos
    {
        public Guid EmpId { get; set; }
        public Guid Id { get; set; }
        public string TypeOfTraining { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}

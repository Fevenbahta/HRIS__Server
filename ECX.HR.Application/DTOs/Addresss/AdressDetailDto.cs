﻿using ECX.HR.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.DTOs.Addresss
{
    public class AdressDetailDto : BaseDtos
    {
        public Guid EmpId { get; set; }
        public int Id { get; set; }
        public string Region { get; set; }
        public string Town { get; set; }
        public string SubCity { get; set; }
        public string Kebele { get; set; }
        public string HouseNo { get; set; }
        public string PhoneNumber { get; set; }
        public int PostCode { get; set; }
        public string Email { get; set; }
    }
}

using ECX.HR.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.DTOs.Addresss
{
    public class AdressDetailDto : BaseDtos
    {

        public int PId { get; set; }
        public Guid Id { get; set; }
        public Guid EmpId { get; set; }
        public string Region { get; set; }
        public string Town { get; set; }
        public string SubCity { get; set; }
        public string Kebele { get; set; }
        public string HouseNo { get; set; }
        public string PhoneNumber { get; set; }
        public int PostCode { get; set; }
        public string Email { get; set; }
        public int Status { get; set; }
    }
}

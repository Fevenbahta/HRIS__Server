using ECX.HR.Application.DTOs.Common;
using ECX.HR.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.DTOs.Addresss
{
    public class AddressDto : BaseDtos
    {
        public Guid EmpId { get; set; }
        public int Id { get; set; }
        public string Region { get; set; }
        public string Town { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}

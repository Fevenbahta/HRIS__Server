using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using ECX.HR.Domain.Common;

namespace ECX.HR.Domain
{
    public class Adress :BaseDomainEntity
    {
        [ForeignKey("Employee")]
        public Guid EmpId { get; set; }
        public Employee Employee { get; set; }

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

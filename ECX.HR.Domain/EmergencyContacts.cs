﻿using ECX.HR.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Domain
{
    public class EmergencyContacts :BaseDomainEntity
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PId { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [ForeignKey("Employee")]
        public Guid EmpId { get; set; }
        
        public string Name { get; set; }    
        public string Town { get; set; }
        public string Region { get; set; }
      
        public string SubCity { get; set; }
        public string Kebele { get; set; }
        public string HouseNo { get; set; }
        public int PhoneNumber { get; set; }
        
        public string Relationship { get; set; }
        public int Status { get; set; }

        public virtual Employees Employees { get; set; }
       

    }
}

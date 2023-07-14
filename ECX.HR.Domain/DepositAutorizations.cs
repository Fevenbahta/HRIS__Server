using ECX.HR.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Domain
{
    public class DepositAutorizations :BaseDomainEntity
    {
        [ForeignKey("Employeee")]
        public Guid EcxId { get; set; }
        public Guid Id { get; set; }
        public string Bank { get; set; }
        public string BankBranch { get; set;}
        public int BankAccount { get; set; }
        public string TinNumber { get; set; }

    }
}

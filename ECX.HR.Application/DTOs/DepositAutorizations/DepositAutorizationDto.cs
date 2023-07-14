using ECX.HR.Application.DTOs.Common;
using ECX.HR.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.DTOs.DepositAutorizations
{
    public class DepositAutorizationDto : BaseDtos
    {
        public Guid EcxId { get; set; }
        public Guid Id { get; set; }
        public string Bank { get; set; }
        public string BankBranch { get; set; }
        public int BankAccount { get; set; }
        public string TinNumber { get; set; }
    }
}

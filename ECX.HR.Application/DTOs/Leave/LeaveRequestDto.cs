using ECX.HR.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.DTOs.Leave
{
    public class LeaveRequestDto : BaseDtos
    {
        public int PId { get; set; }
      
        public Guid leaveRequestId { get; set; }

       
        public Guid EmpId { get; set; }

       
        public Guid leaveTypeId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime ApproveDate { get; set; }
        public string ApprovedBy { get; set; }
        public string LeaveStatus { get; set; }

        public int Status { get; set; }
    }
}

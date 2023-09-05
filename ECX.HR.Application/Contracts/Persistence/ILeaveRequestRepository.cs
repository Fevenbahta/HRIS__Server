using ECX.HR.Application.Contracts.Persistent;
using ECX.HR.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Application.Contracts.Persistence
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequests>
    {
        Task<List<LeaveRequests>> GetByEmpId(Guid id);
        Task<List<LeaveRequests>> GetByStatus(string leaveStatus);
        

    }
}

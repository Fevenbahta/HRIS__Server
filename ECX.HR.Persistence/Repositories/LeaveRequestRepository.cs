using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Persistence.Repositories
{
    public class LeaveRequestRepository : GenericRepository<LeaveRequests>, ILeaveRequestRepository
    {
        private readonly ECXHRDbContext _context;

        public LeaveRequestRepository(ECXHRDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<List<LeaveRequests>> GetByEmpId(Guid empId)
        {
            return await _context.Set<LeaveRequests>()
                     .Where(T => T.EmpId == empId)
                   .ToListAsync();
        }
    }
}

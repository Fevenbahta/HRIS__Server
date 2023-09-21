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

        DateTime currentDate = DateTime.Now;
        public async Task<List<LeaveRequests>> GetByEmpId(Guid empId)
        {
            DateTime currentDate = DateTime.Now;
            return await _context.Set<LeaveRequests>()
                     .Where(T => T.EmpId == empId && T.StartDate.Year >= currentDate.Year-2)
                   .ToListAsync();
        }
        public async Task<List<LeaveRequests>> GetByStatus(string status, string supervisor)
        {
            return await _context.Set<LeaveRequests>()
                     .Where(T => T.LeaveStatus == status && T.Supervisor == supervisor && T.StartDate.Year >= currentDate.Year - 1)
                   .ToListAsync();
        }
        public async Task<List<LeaveRequests>> GetAllByStatus(string status)
        {
            DateTime currentDate = DateTime.Now;
            return await _context.Set<LeaveRequests>()
                     .Where(T => T.LeaveStatus == status && T.StartDate.Year >= currentDate.Year - 2)
                   .ToListAsync();
        }
    }
}

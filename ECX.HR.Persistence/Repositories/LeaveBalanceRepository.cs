
using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Application.Models;
using ECX.HR.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Persistence.Repositories
{
    public class LeaveBalanceRepository : GenericRepository<LeaveBalances>, ILeaveBalanceRepository
    {
        private readonly ECXHRDbContext _context;

        public LeaveBalanceRepository(ECXHRDbContext context) : base(context)
        {
            _context = context;
        }
     
        public async Task<List<LeaveBalances>> GetByEmpId(Guid empId)
        {
            return await _context.Set<LeaveBalances>()
                     .Where(T =>T.EmpId == empId)
                   .ToListAsync();
        }

    }
}
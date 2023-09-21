using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Domain;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
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
        public async Task<List<LeaveRequests>> GetByStatus(string status)
        {
            return await _context.Set<LeaveRequests>()
                     .Where(T => T.LeaveStatus == status)
                   .ToListAsync();
        }


        public async Task<List<Employees>> GetLeaveData(Guid employeeid)
        {
            try
            {
                // Create a SqlParameter for the employeeId
                SqlParameter param = new SqlParameter("@EmployeeId", SqlDbType.UniqueIdentifier)
                {
                    Value = employeeid
                };

                // Call the stored procedure using FromSqlRaw
                var employeeData = await _context.Employee
                    .FromSqlRaw("EXEC GetLeaveDatas @EmployeeId", param)
                    .ToListAsync();

                return employeeData;
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately
                throw ex;
            }
        }
    }
}

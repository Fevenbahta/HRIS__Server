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
    public class EmployeeRepository : GenericRepository<Employees>, IEmployeeRepository
    {
        private readonly ECXHRDbContext _context;

        public EmployeeRepository(ECXHRDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<List<Employees>> GetByEcxId(string ecxId)
        {
            return await _context.Set<Employees>()
                     .Where(T => T.EcxId == ecxId)
                     .ToListAsync();
        }
        //public async Task<List<EmergencyContacts>> GetByEmpId(Guid empId)
        //{
        //    return await _context.Set<EmergencyContacts>()
        //             .Where(T => T.EmpId == empId)
        //       
        //}

    }
}

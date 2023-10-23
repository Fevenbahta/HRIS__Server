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
    public class AttendanceRepository : GenericRepository<Attendances>, IAttendanceRepository
    {
        private readonly ECXHRDbContext _context;

        public AttendanceRepository(ECXHRDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Attendances> GetById(string id)
        {
           // throw new NotImplementedException();
            return await _context.Set<Attendances>().FindAsync(id);
        }
       
    }
}

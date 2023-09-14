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
    public class PromotionRelationRepository : GenericRepository<PromotionRelations>, IPromotionRelationRepository
    {
        private readonly ECXHRDbContext _context;

        public PromotionRelationRepository(ECXHRDbContext context) : base(context)
        {
           _context = context;
        }
        public async Task<List<PromotionRelations>> GetByEmpId(Guid empId)
        {
            return await _context.Set<PromotionRelations>()
                     .Where(T => T.EmpId == empId)
                   .ToListAsync();
        }

        public async Task<List<PromotionRelations>> GetByStatus(string status)
        {
            return await _context.Set<PromotionRelations>()
                     .Where(T => T.PromotionStatus == status)
                   .ToListAsync();
        }
    }
}

using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Domain;
using ECX.HR.Persistence.Migrations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Persistence.Repositories
{
    public class FileRepository : GenericRepository<Files>, IFileRepository
    {
        private readonly ECXHRDbContext _context;

        public FileRepository(ECXHRDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<Files> GetByFile(string File)
        {
            return await _context.Set<Files>()
                    .FirstOrDefaultAsync(file => file.File == File);

        }
    }
}

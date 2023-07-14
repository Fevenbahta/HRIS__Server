using ECX.HR.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Persistence.Repositories
{
    public class DepositAutorizationRepository : GenericRepository<DepositAutorizations>
    {
        private readonly ECXHRDbContext _context;

        public DepositAutorizationRepository(ECXHRDbContext context) : base(context)
        {
          _context = context;
        }
    }
}

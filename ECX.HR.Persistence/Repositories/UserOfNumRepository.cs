using ECX.HR.Application.Contracts.Persistence;
using ECX.HR.Domain;
using ECXHR_Service.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Persistence.Repositories
{
    public class UserOfNumRepository : GenericRepository<UserOfNum>, IUserOfNumRepository
    {
        private readonly ECXHRDbContext _context;

        public UserOfNumRepository(ECXHRDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<List<UserOfNum>> GetUserOfNum(int USERID)
        {
            return await _context.GetUserOfNumFromSourceDatabase(USERID);

        }
    }

}

using ECX.HR.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.HR.Persistence
{
    public  class EmployeeDataServices
    {
        private readonly ECXHRDbContext _dbContext;

        public EmployeeDataServices(ECXHRDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<WorkExperiences> GetEmployeeWorkExperiences(Guid employeeId)
        {
            var parameter = new SqlParameter("@EmployeeId", SqlDbType.UniqueIdentifier)
            {
                Value = employeeId
            };

            var workExperiences = _dbContext.WorkExperiences
                .FromSqlRaw("EXEC GetEmployeeData @EmployeeId", parameter)
                .ToList();

            return workExperiences;
        }

    }
}

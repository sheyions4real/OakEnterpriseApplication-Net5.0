using LeaveManagement.Contracts;
using LeaveManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Repositories
{
    public class EmployeeProfileRepository : GenericRepository<EmployeeProfile>, IEmployeeProfileRepository
    {
        public ApplicationDbContext context;
        public EmployeeProfileRepository(ApplicationDbContext context ) : base(context)
        {
            this.context = context;
        }

     

        public async Task<EmployeeProfile> GetEmployeeProfile(string id)
        {
            return await context.Staff.FindAsync(id);
        }
    }
}

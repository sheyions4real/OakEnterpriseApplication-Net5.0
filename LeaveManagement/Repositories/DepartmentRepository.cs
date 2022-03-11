using LeaveManagement.Contracts;
using LeaveManagement.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Repositories
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        public ApplicationDbContext context;
        public DepartmentRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

      

        public async Task<string> GetDepartmentName(string id)
        {
            var dept = await context.Departments.FindAsync(id);
            return dept.Name;

        }
    }
}

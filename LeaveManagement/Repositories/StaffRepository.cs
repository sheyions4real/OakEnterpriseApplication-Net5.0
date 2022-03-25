using LeaveManagement.Contracts;
using LeaveManagement.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Repositories
{
    public class EmployeeProfileRepository : GenericRepository<EmployeeProfile>, IEmployeeProfileRepository
    {
        public ApplicationDbContext context;
        private readonly UserManager<Employee> userManager;

        public EmployeeProfileRepository(ApplicationDbContext context, UserManager<Employee> userManager ) : base(context)
        {
            this.context = context;
            this.userManager = userManager;
        }

     

        public async Task<EmployeeProfile> GetEmployeeProfile(string id)
        {
            return await context.Staff.FindAsync(id);
        }

        public async Task<List<Employee>> GetUsersInRole(string role)
        {
            var users = await userManager.GetUsersInRoleAsync(role);
            return users.ToList();
        }
    }
}

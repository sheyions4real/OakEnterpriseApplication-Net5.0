using AutoMapper;
using AutoMapper.QueryableExtensions;
using LeaveManagement.Application.Contracts;
using LeaveManagement.Common.Models;
using LeaveManagement.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Application.Repositories
{
    public class EmployeeProfileRepository : GenericRepository<EmployeeProfile>, IEmployeeProfileRepository
    {
        public ApplicationDbContext context;
        private readonly UserManager<Employee> userManager;
        private readonly IMapper mapper;

        public EmployeeProfileRepository(ApplicationDbContext context, UserManager<Employee> userManager, IMapper mapper ) : base(context)
        {
            this.context = context;
            this.userManager = userManager;
            this.mapper = mapper;
        }

     

        public async Task<EmployeeProfileVM> GetEmployeeProfile(string id)
        {
            return mapper.Map<EmployeeProfileVM>(await context.Staff.FindAsync(id));
        }

        public async Task<List<EmployeeProfileVM>> GetUsersInRole(string role)
        {
            var users = mapper.Map<List<EmployeeProfileVM>>(await userManager.GetUsersInRoleAsync(role));
            return users.ToList();
        }
    }
}

using LeaveManagement.Configurations.Entities;
using LeaveManagement.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeaveManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext<Employee>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // seeding the identity roles for the application
        // this method is called when EF is creating the database
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // setup configuration for the role
            builder.ApplyConfiguration(new RoleSeedConfiguration());        // the file that contains the role infomation to be seeded    
            builder.ApplyConfiguration(new UserSeedConfiguration());        // this file will seed the first admin user
            builder.ApplyConfiguration(new UserRoleConfiguration());        // this will assign the role to the seeded user
            builder.ApplyConfiguration(new DepartmentSeedConfiguration());
            builder.ApplyConfiguration(new EmployeeProfileSeedConfiguration());// this well create the departments

            builder.Entity<UserByRoles>(
                userByRoles =>
                {
                    userByRoles.HasNoKey();
                    userByRoles.ToView("GetSystemUsers");
                });
        
        }


        // specifies the tables you want to create
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<EmployeeProfile> Staff { get; set; }
        public DbSet<LeaveManagement.Models.LeaveAllocationEditVM> LeaveAllocationEditVM { get; set; }
        
      
        




    }
}

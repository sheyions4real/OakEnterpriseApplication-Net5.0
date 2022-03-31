using LeaveManagement.Common.Models;
using LeaveManagement.Data.Configurations.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LeaveManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext<Employee>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // for database auditing.. this method will run anytime th savechangesasync method is called
        // implement some things before saving

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {

            // track the entries and check the data entry class type or model that it want to execute to the database
            // this will filter the change tracker to only when its add and update operation
            foreach (var entry in base.ChangeTracker.Entries<BaseEntity>().Where(q => q.State == EntityState.Added || q.State == EntityState.Modified))
            {
                entry.Entity.DateModified = DateTime.Now;
                // check if the operation is adding to db and then set the dateCreated
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.DateCreated = DateTime.Now;
                }
            }


            //    foreach (var entry in base.ChangeTracker.Entries<BaseEntity>())
            //{
                
            //    entry.Entity.DateModified = DateTime.Now;
            //    // check if the operation is adding to db and then set the dateCreated
            //    if(entry.State == EntityState.Added)
            //    {
            //            entry.Entity.DateCreated = DateTime.Now;
            //    }
           // }
           
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
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

            //builder.Entity<UserByRoles>(
            //    userByRoles =>
            //    {
            //        userByRoles.HasNoKey();
            //        userByRoles.ToView("GetSystemUsers");
            //    });
        
        }


        // specifies the tables you want to create
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<EmployeeProfile> Staff { get; set; }

        public DbSet<LeaveRequest> LeaveRequests { get; set; }

        public DbSet<PublicHolidays> PublicHolidays { get; set; }

       // public DbSet<EmployeeProfileVM> EmployeePr { get; set; }




    }
}

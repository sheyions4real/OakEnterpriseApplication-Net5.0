using LeaveManagement.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                    new Employee
                    {
                        Id =  "435f3413-2f18-426f-9f20-944aad0r4623",
                        Email = "admin@oakpensions.com",
                        NormalizedEmail = "ADMIN@OAKPENSIONS.COM",
                        UserName = "admin@oakpensions.com",
                        NormalizedUserName = "ADMIN@OAKPENSIONS.COM",
                        Firstname = "System",
                        Lastname = "Admin",
                        PasswordHash = hasher.HashPassword(null, "Password@123"),
                        EmailConfirmed = true
                    },
                    new Employee
                    {
                        Id = "a35a3413-2f18-446f-9f30-944aad3r4633",
                        Email = "mattewo@oakpensions.com",
                        NormalizedEmail = "MATTEWO@OAKPENSIONS.COM",
                        UserName = "mattewo@oakpensions.com",
                        NormalizedUserName = "MATTEWO@OAKPENSIONS.COM",
                        Firstname = "System",
                        Lastname = "User",
                        PasswordHash = hasher.HashPassword(null, "Password@123"),
                        EmailConfirmed =true
                    }
                );
        }
    }
}
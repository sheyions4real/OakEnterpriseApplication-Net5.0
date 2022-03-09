using LeaveManagement.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Configurations.Entities
{
    // internal access modifier means its locked to this project
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "835f3213-2f18-426f-9f20-144aad0f962b",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()
                },
                 new IdentityRole
                 {
                     Id = "a25f3213-2f18-426f-9f20-144acd3a962a",
                     Name = Roles.Supervisor,
                     NormalizedName = Roles.Supervisor.ToUpper()
                 },
                  new IdentityRole
                  {
                      Id = "c35a3213-2f18-426f-9f20-144bad0r962c",
                      Name = Roles.Group_Head,
                      NormalizedName = "GROUP HEAD"
                  },
                   new IdentityRole
                   {
                       Id = "535f3313-2f38-226f-9a20-174aad0r9625",
                       Name = Roles.HR,
                       NormalizedName = Roles.HR + " MANAGER"
                   },
                   new IdentityRole
                   {
                       Id = "135f3213-2f18-426f-9f20-144aad019621",
                       Name = Roles.User,
                       NormalizedName = Roles.User.ToUpper()
                   }
            );
        }
    }
}
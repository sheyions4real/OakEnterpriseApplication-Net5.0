using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace LeaveManagement.Data.Configurations.Entities
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<Microsoft.AspNetCore.Identity.IdentityUserRole<string>> builder)
        {
            builder.HasData(
                    new IdentityUserRole<string>
                    {
                        RoleId = "835f3213-2f18-426f-9f20-144aad0f962b",       // the administrator rold guid
                        UserId = "435f3413-2f18-426f-9f20-944aad0r4623"         // the seeded user guid
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = "135f3213-2f18-426f-9f20-144aad019621",       // the administrator rold guid
                        UserId = "a35a3413-2f18-446f-9f30-944aad3r4633"         // the seeded user guid
                    }
                ); ;
        }
    }
}
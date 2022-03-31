using LeaveManagement.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Data.Configurations.Entities
{
    internal class EmployeeProfileSeedConfiguration : IEntityTypeConfiguration<EmployeeProfile>
    {
        public void Configure(EntityTypeBuilder<EmployeeProfile> builder)
        {
            builder.HasData(
                    new EmployeeProfile
                    {
                        Id = "a35a3413-2f18-446f-9f30-944aad3r4633",
                        Lastname = "Omagene",
                        Firstname = "Sheyi",
                        Othernames = "Matthew",
                        Gender = "Male",
                        DepartmentID= "235f3413-2f18-426f-9f20-944aad3a4623",
                        TaxID = "",
                        Status = 1,
                        Email= "mattewo@oakpensions.com"
                    },
                    new EmployeeProfile
                    {
                        Id = "9f6b8d6e-aeb6-4cc4-94d9-06267b8f5410",
                        Lastname = "Modungwo",
                        Firstname = "Ijeoma",
                        Othernames = "",
                        Gender = "Female",
                        DepartmentID = "235f3413-2f18-426f-9f20-944aad3a4623",
                        TaxID = "",
                        Status = 1,
                        Email = "ijeomam@oakpensions.com"
                    }, new EmployeeProfile
                    {
                        Id = "a4116b98-ccf0-400f-887d-06f2b4c4ed5a",
                        Lastname = "Olanipekun",
                        Firstname = "Razaq",
                        Othernames = "",
                        Gender = "Male",
                        DepartmentID = "235f3413-2f18-426f-9f20-944aad3a4623",
                        TaxID = "",
                        Status = 1,
                        Email = "razaqo@oakpensions.com"
                    }
                );
        }

       
    }
}
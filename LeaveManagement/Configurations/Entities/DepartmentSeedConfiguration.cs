using LeaveManagement.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Configurations.Entities
{
    public class DepartmentSeedConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasData(
                 new Department
                 {
                     Id = "235f3413-2f18-426f-9f20-944aad3a4623",
                     Name = "ICT",
                     Description = "Technology Solution Center",
                     Number_Of_Staff =3,
                     Units ="IT Support, Network/Security and Application/Database",
                     Number_Of_Units = 3,
                     HOD = "Jide Olaniyan",
                     DateCreated = new DateTime(2006,06,01),
                     DateModified = new DateTime(2022, 03, 09)
                 },
                    new Department
                    {
                        Id = "135f3413-2f18-426f-9f20-944aa1314623",
                        Name = "Operations",
                        Description = "Operations Department",
                        Number_Of_Staff = 12,
                        Units = "Contribution, Reconcilation, Schedules and Registrations",
                        Number_Of_Units = 4,
                        HOD = "Iyabo Aremu",
                        DateCreated = new DateTime(2006, 06, 01),
                        DateModified = new DateTime(2022, 03, 09)
                    },
                       new Department
                       {
                           Id = "335f3413-2f18-426f-9f20-944aad323623",
                           Name = "Benefit",
                           Description = "Benefit Administration Department",
                           Number_Of_Staff = 7,
                           Units = "Documentation, Processing and Payment",
                           Number_Of_Units = 3,
                           HOD = "Nnezi Oke",
                           DateCreated = new DateTime(2006, 06, 01),
                           DateModified = new DateTime(2022, 03, 09)
                       },
                          new Department
                          {
                              Id = "435f3413-2f18-426f-9f20-944aa4344643",
                              Name = "FINCON",
                              Description = "Financial Control Department",
                              Number_Of_Staff = 6,
                              Units = "Fin Invest and Fund Account",
                              Number_Of_Units = 2,
                              HOD = "Benedict Azuh",
                              DateCreated = new DateTime(2006, 06, 01),
                              DateModified = new DateTime(2022, 03, 09)
                          },
                             new Department
                             {
                                 Id = "535f3413-5f18-426f-9f20-944aad334523",
                                 Name = "Customer Care",
                                 Description = "Customer Service Center",
                                 Number_Of_Staff = 9,
                                 Units = "Call Center and Customer Service",
                                 Number_Of_Units = 2,
                                 HOD = "Josephine Buyengum",
                                 DateCreated = new DateTime(2006, 06, 01),
                                 DateModified = new DateTime(2022, 03, 09)
                             },
                                new Department
                                {
                                    Id = "a35f3413-5f18-426f-6f20-944aa6314623",
                                    Name = "HR/Admin",
                                    Description = "Human Resources and Administration",
                                    Number_Of_Staff = 5,
                                    Units = "HR and Admin",
                                    Number_Of_Units = 2,
                                    HOD = "Henry Christopher",
                                    DateCreated = new DateTime(2006, 06, 01),
                                    DateModified = new DateTime(2022, 03, 09)
                                },
                                   new Department
                                   {
                                       Id = "435f3413-2f18-426f-9f20-544aad364623",
                                       Name = "BDRM",
                                       Description = "Business Development and Relationship Management",
                                       Number_Of_Staff = 50,
                                       Units = "Business Development and Relationship Management",
                                       Number_Of_Units = 2,
                                       HOD = "Akinwumi Odunewu",
                                       DateCreated = new DateTime(2006, 06, 01),
                                       DateModified = new DateTime(2022, 03, 09)
                                   },
                                    new Department
                                    {
                                        Id = "a35f3413-2f18-42af-9f20-94aaad394623",
                                        Name = "Investment",
                                        Description = "Investment Department",
                                        Number_Of_Staff = 6,
                                        Units = "Investment and Investment Research",
                                        Number_Of_Units = 2,
                                        HOD = "Bola Ibrahim",
                                        DateCreated = new DateTime(2006, 06, 01),
                                        DateModified = new DateTime(2022, 03, 09)
                                    },
                                     new Department
                                     {
                                         Id = "535f3413-2f18-456f-9f20-944aad544623",
                                         Name = "Internal Audit",
                                         Description = "Internal Control",
                                         Number_Of_Staff = 5,
                                         Units = "Internal Control and Internal Audit",
                                         Number_Of_Units = 2,
                                         HOD = "Adebusuyi Adebayo",
                                         DateCreated = new DateTime(2006, 06, 01),
                                         DateModified = new DateTime(2022, 03, 09)
                                     }
                                     ,
                                     new Department
                                     {
                                         Id = "a35f3413-2fa8-426f-9f20-944aad3r4623",
                                         Name = "Compliance",
                                         Description = "Compliance",
                                         Number_Of_Staff = 1,
                                         Units = "Complaince",
                                         Number_Of_Units = 1,
                                         HOD = "Abimbola Adegoke",
                                         DateCreated = new DateTime(2006, 06, 01),
                                         DateModified = new DateTime(2022, 03, 09)
                                     },
                                     new Department
                                     {
                                         Id = "b35f3413-2f18-4b6f-9f20-944bbd334623",
                                         Name = "Legal",
                                         Description = "Legal",
                                         Number_Of_Staff = 1,
                                         Units = "Legal",
                                         Number_Of_Units = 1,
                                         HOD = "Alamin Shekoni",
                                         DateCreated = new DateTime(2006, 06, 01),
                                         DateModified = new DateTime(2022, 03, 09)
                                     }, 
                                     new Department
                                     {
                                         Id = "a35f3413-2f68-426f-9f20-944bad3r46ac",
                                         Name = "ED Office",
                                         Description = "ED Office",
                                         Number_Of_Staff = 1,
                                         Units = "ED Office",
                                         Number_Of_Units = 1,
                                         HOD = "Abdulwahab Ige",
                                         DateCreated = new DateTime(2006, 06, 01),
                                         DateModified = new DateTime(2022, 03, 09)
                                     },
                                      new Department
                                      {
                                          Id = "c35f3413-2318-426f-9e20-944aad3r46c3",
                                          Name = "MD Office",
                                          Description = "MD Office",
                                          Number_Of_Staff = 3,
                                          Units = "MD Office",
                                          Number_Of_Units = 1,
                                          HOD = "Aliyu Abdullahi",
                                          DateCreated = new DateTime(2006, 06, 01),
                                          DateModified = new DateTime(2022, 03, 09)
                                      }
                );
        }
    }
}

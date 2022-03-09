﻿// <auto-generated />
using System;
using LeaveManagement.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LeaveManagement.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220309101407_AddDepartmentTableAndSeedData")]
    partial class AddDepartmentTableAndSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LeaveManagement.Data.Department", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HOD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number_Of_Staff")
                        .HasColumnType("int");

                    b.Property<int>("Number_Of_Units")
                        .HasColumnType("int");

                    b.Property<string>("Units")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = "235f3413-2f18-426f-9f20-944aad3a4623",
                            DateCreated = new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Technology Solution Center",
                            HOD = "Jide Olaniyan",
                            Name = "ICT",
                            Number_Of_Staff = 3,
                            Number_Of_Units = 3,
                            Units = "IT Support, Network/Security and Application/Database"
                        },
                        new
                        {
                            Id = "135f3413-2f18-426f-9f20-944aa1314623",
                            DateCreated = new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Operations Department",
                            HOD = "Iyabo Aremu",
                            Name = "Operations",
                            Number_Of_Staff = 12,
                            Number_Of_Units = 4,
                            Units = "Contribution, Reconcilation, Schedules and Registrations"
                        },
                        new
                        {
                            Id = "335f3413-2f18-426f-9f20-944aad323623",
                            DateCreated = new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Benefit Administration Department",
                            HOD = "Nnezi Oke",
                            Name = "Benefit",
                            Number_Of_Staff = 7,
                            Number_Of_Units = 3,
                            Units = "Documentation, Processing and Payment"
                        },
                        new
                        {
                            Id = "435f3413-2f18-426f-9f20-944aa4344643",
                            DateCreated = new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Financial Control Department",
                            HOD = "Benedict Azuh",
                            Name = "FINCON",
                            Number_Of_Staff = 6,
                            Number_Of_Units = 2,
                            Units = "Fin Invest and Fund Account"
                        },
                        new
                        {
                            Id = "535f3413-5f18-426f-9f20-944aad334523",
                            DateCreated = new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Customer Service Center",
                            HOD = "Josephine Buyengum",
                            Name = "Customer Care",
                            Number_Of_Staff = 9,
                            Number_Of_Units = 2,
                            Units = "Call Center and Customer Service"
                        },
                        new
                        {
                            Id = "a35f3413-5f18-426f-6f20-944aa6314623",
                            DateCreated = new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Human Resources and Administration",
                            HOD = "Henry Christopher",
                            Name = "HR/Admin",
                            Number_Of_Staff = 5,
                            Number_Of_Units = 2,
                            Units = "HR and Admin"
                        },
                        new
                        {
                            Id = "435f3413-2f18-426f-9f20-544aad364623",
                            DateCreated = new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Business Development and Relationship Management",
                            HOD = "Akinwumi Odunewu",
                            Name = "BDRM",
                            Number_Of_Staff = 50,
                            Number_Of_Units = 2,
                            Units = "Business Development and Relationship Management"
                        },
                        new
                        {
                            Id = "a35f3413-2f18-42af-9f20-94aaad394623",
                            DateCreated = new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Investment Department",
                            HOD = "Bola Ibrahim",
                            Name = "Investment",
                            Number_Of_Staff = 6,
                            Number_Of_Units = 2,
                            Units = "Investment and Investment Research"
                        },
                        new
                        {
                            Id = "535f3413-2f18-456f-9f20-944aad544623",
                            DateCreated = new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Internal Control",
                            HOD = "Adebusuyi Adebayo",
                            Name = "Internal Audit",
                            Number_Of_Staff = 5,
                            Number_Of_Units = 2,
                            Units = "Internal Control and Internal Audit"
                        },
                        new
                        {
                            Id = "a35f3413-2fa8-426f-9f20-944aad3r4623",
                            DateCreated = new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Compliance",
                            HOD = "Abimbola Adegoke",
                            Name = "Compliance",
                            Number_Of_Staff = 1,
                            Number_Of_Units = 1,
                            Units = "Complaince"
                        },
                        new
                        {
                            Id = "b35f3413-2f18-4b6f-9f20-944bbd334623",
                            DateCreated = new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Legal",
                            HOD = "Alamin Shekoni",
                            Name = "Legal",
                            Number_Of_Staff = 1,
                            Number_Of_Units = 1,
                            Units = "Legal"
                        },
                        new
                        {
                            Id = "a35f3413-2f68-426f-9f20-944bad3r46ac",
                            DateCreated = new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "ED Office",
                            HOD = "Abdulwahab Ige",
                            Name = "ED Office",
                            Number_Of_Staff = 1,
                            Number_Of_Units = 1,
                            Units = "ED Office"
                        },
                        new
                        {
                            Id = "c35f3413-2318-426f-9e20-944aad3r46c3",
                            DateCreated = new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "MD Office",
                            HOD = "Aliyu Abdullahi",
                            Name = "MD Office",
                            Number_Of_Staff = 3,
                            Number_Of_Units = 1,
                            Units = "MD Office"
                        });
                });

            modelBuilder.Entity("LeaveManagement.Data.Employee", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Confirmed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateConfirmed")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateEmployed")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepartmentID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaxID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "435f3413-2f18-426f-9f20-944aad0r4623",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1d576f2b-71c0-42ad-923a-907e5a43a009",
                            Email = "admin@oakpensions.com",
                            EmailConfirmed = true,
                            Firstname = "System",
                            Lastname = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@OAKPENSIONS.COM",
                            NormalizedUserName = "ADMIN@OAKPENSIONS.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEORP8Sxf8wg2MaOKux35Qx2rxE6O0oqCwUhGsM9GM4B/5qrsuKAn4QSdouEL3z3I2w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1d56b9f2-c066-44fb-8bd6-91bbd1043b3f",
                            TwoFactorEnabled = false,
                            UserName = "admin@oakpensions.com"
                        },
                        new
                        {
                            Id = "a35a3413-2f18-446f-9f30-944aad3r4633",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e4aa188e-abb1-4683-b95e-72ce644b24d3",
                            Email = "mattewo@oakpensions.com",
                            EmailConfirmed = true,
                            Firstname = "System",
                            Lastname = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "MATTHEWO@OAKPENSIONS.COM",
                            NormalizedUserName = "MATTHEWO@OAKPENSIONS.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEClnGiZ8XX6fExueC6itzQS4S9EuPpwkBLvp+P/jyUGD1Ywy0PzlFbu5Di7lEKS4YQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "08e60df9-3c85-446a-b0a6-ad24e59201f8",
                            TwoFactorEnabled = false,
                            UserName = "mattewo@oakpensions.com"
                        });
                });

            modelBuilder.Entity("LeaveManagement.Data.LeaveAllocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LeaveTypeId")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfDays")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LeaveTypeId");

                    b.ToTable("LeaveAllocations");
                });

            modelBuilder.Entity("LeaveManagement.Data.LeaveType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("DefaultDays")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LeaveTypes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "835f3213-2f18-426f-9f20-144aad0f962b",
                            ConcurrencyStamp = "c8ace24c-ebce-4771-a63e-7c5ea1ad63b6",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "a25f3213-2f18-426f-9f20-144acd3a962a",
                            ConcurrencyStamp = "73f0dbb4-a699-424a-937a-0d74387c0a46",
                            Name = "Supervisor",
                            NormalizedName = "SUPERVISOR"
                        },
                        new
                        {
                            Id = "c35a3213-2f18-426f-9f20-144bad0r962c",
                            ConcurrencyStamp = "17caf5bf-c09f-4052-98d9-70af4569ad01",
                            Name = "Group_Head",
                            NormalizedName = "GROUP HEAD"
                        },
                        new
                        {
                            Id = "535f3313-2f38-226f-9a20-174aad0r9625",
                            ConcurrencyStamp = "cc88cb7f-57c6-497c-8ef3-52f3e3bccfb0",
                            Name = "HR",
                            NormalizedName = "HR MANAGER"
                        },
                        new
                        {
                            Id = "135f3213-2f18-426f-9f20-144aad019621",
                            ConcurrencyStamp = "5c052134-b310-4c30-a129-8219fb497674",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "435f3413-2f18-426f-9f20-944aad0r4623",
                            RoleId = "835f3213-2f18-426f-9f20-144aad0f962b"
                        },
                        new
                        {
                            UserId = "a35a3413-2f18-446f-9f30-944aad3r4633",
                            RoleId = "135f3213-2f18-426f-9f20-144aad019621"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("LeaveManagement.Data.LeaveAllocation", b =>
                {
                    b.HasOne("LeaveManagement.Data.LeaveType", "LeaveType")
                        .WithMany()
                        .HasForeignKey("LeaveTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LeaveType");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("LeaveManagement.Data.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("LeaveManagement.Data.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LeaveManagement.Data.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("LeaveManagement.Data.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
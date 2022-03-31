using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveManagement.Data.Migrations
{
    public partial class InitializeDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Othernames = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateEmployed = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Confirmed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateConfirmed = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HOD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number_Of_Staff = table.Column<int>(type: "int", nullable: false),
                    Number_Of_Units = table.Column<int>(type: "int", nullable: false),
                    Units = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeaveTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefaultDays = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PublicHolidays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumOfWorkingDays = table.Column<int>(type: "int", nullable: false),
                    Period = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicHolidays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Othernames = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TaxID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateEmployed = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Confirmed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateConfirmed = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Marital_Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Level_Of_Entry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    branch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rsa_Pin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staff_Departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LeaveAllocations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DaysAllocated = table.Column<int>(type: "int", nullable: false),
                    DaysUsed = table.Column<int>(type: "int", nullable: false),
                    PublicHolidays = table.Column<int>(type: "int", nullable: false),
                    DaysBroughtForward = table.Column<int>(type: "int", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Period = table.Column<int>(type: "int", nullable: false),
                    Start_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    End_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveAllocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveAllocations_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    TotalDaysRequested = table.Column<int>(type: "int", nullable: false),
                    TotalPublicHolidays = table.Column<int>(type: "int", nullable: false),
                    TotalOutstanding = table.Column<int>(type: "int", nullable: false),
                    LeaveYear = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RelieverID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupervisorEmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SupervisorApproval = table.Column<bool>(type: "bit", nullable: true),
                    SupervisorComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HREmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    HRApproval = table.Column<bool>(type: "bit", nullable: true),
                    HRComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroupHeadEmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    GroupHeadApproval = table.Column<bool>(type: "bit", nullable: true),
                    GHComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EDEmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    EDApproval = table.Column<bool>(type: "bit", nullable: true),
                    EDComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MDEmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MDApproval = table.Column<bool>(type: "bit", nullable: true),
                    MDComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_Staff_EDEmployeeId",
                        column: x => x.EDEmployeeId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_Staff_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_Staff_GroupHeadEmployeeId",
                        column: x => x.GroupHeadEmployeeId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_Staff_HREmployeeId",
                        column: x => x.HREmployeeId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_Staff_MDEmployeeId",
                        column: x => x.MDEmployeeId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_Staff_RelieverID",
                        column: x => x.RelieverID,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_Staff_SupervisorEmployeeId",
                        column: x => x.SupervisorEmployeeId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "785f3813-2f18-426f-9820-144aad719899", "f36ab0a3-e146-4246-8518-c783a644b809", "MD", "MD" },
                    { "135f3213-2f18-426f-9f20-144aad019621", "ea6f6e6c-f46a-4e03-aab7-1c684e74a804", "User", "USER" },
                    { "535f3313-2f38-226f-9a20-174aad0r9625", "b6955369-8ee7-4376-afec-8a6447556b6d", "HR", "HR MANAGER" },
                    { "c35a3213-2f18-426f-9f20-144bad0r962c", "2a42c9cb-ca4d-4c1c-bb88-25a99df5882b", "Group Head", "GROUP HEAD" },
                    { "a25f3213-2f18-426f-9f20-144acd3a962a", "a8a0c570-cff0-4db1-a2fe-582a1ac5e7b6", "Supervisor", "SUPERVISOR" },
                    { "835f3213-2f18-426f-9f20-144aad0f962b", "d5612f0b-4c6e-46aa-b8c8-3474cdb16e08", "Administrator", "ADMINISTRATOR" },
                    { "992f3213-2f18-426f-9f30-144aad219289", "be81d4e7-475f-40c7-a4f4-739ae8317af6", "ED", "ED" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Confirmed", "DateConfirmed", "DateCreated", "DateEmployed", "DateModified", "DateOfBirth", "DepartmentID", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Othernames", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxID", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a35a3413-2f18-446f-9f30-944aad3r4633", 0, "eb18f487-fe3b-44f7-aba6-2e2e9f025351", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "mattewo@oakpensions.com", true, "System", "User", false, null, "MATTEWO@OAKPENSIONS.COM", "MATTEWO@OAKPENSIONS.COM", null, "AQAAAAEAACcQAAAAEK15FWa05XytuTVKaFvjrfjy7pTdP/GZ6n67RFpWND7sbAdknCmbIbmn0pt3fEUGAw==", null, false, "92ab9432-91b3-4f63-8155-9ee18904696d", null, false, "mattewo@oakpensions.com" },
                    { "435f3413-2f18-426f-9f20-944aad0r4623", 0, "3bd48f73-a2be-414f-bfa9-0728f78e498e", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin@oakpensions.com", true, "System", "Admin", false, null, "ADMIN@OAKPENSIONS.COM", "ADMIN@OAKPENSIONS.COM", null, "AQAAAAEAACcQAAAAEIM7v0zRN+2LbW7Jgfeu2nfinNT5lmDq2rA2oBe3QFvlbPqMB6tM5+m4dqVlKW/j1A==", null, false, "b8014170-3abe-48b3-b261-f25ab225ed3d", null, false, "admin@oakpensions.com" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "DateCreated", "DateModified", "Description", "HOD", "Name", "Number_Of_Staff", "Number_Of_Units", "Units" },
                values: new object[,]
                {
                    { "c35f3413-2318-426f-9e20-944aad3r46c3", new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "MD Office", "Aliyu Abdullahi", "MD Office", 3, 1, "MD Office" },
                    { "a35f3413-2f68-426f-9f20-944bad3r46ac", new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "ED Office", "Abdulwahab Ige", "ED Office", 1, 1, "ED Office" },
                    { "b35f3413-2f18-4b6f-9f20-944bbd334623", new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Legal", "Alamin Shekoni", "Legal", 1, 1, "Legal" },
                    { "535f3413-2f18-456f-9f20-944aad544623", new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Internal Control", "Adebusuyi Adebayo", "Internal Audit", 5, 2, "Internal Control and Internal Audit" },
                    { "a35f3413-2f18-42af-9f20-94aaad394623", new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Investment Department", "Bola Ibrahim", "Investment", 6, 2, "Investment and Investment Research" },
                    { "435f3413-2f18-426f-9f20-544aad364623", new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Business Development and Relationship Management", "Akinwumi Odunewu", "BDRM", 50, 2, "Business Development and Relationship Management" },
                    { "a35f3413-5f18-426f-6f20-944aa6314623", new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources and Administration", "Henry Christopher", "HR/Admin", 5, 2, "HR and Admin" },
                    { "535f3413-5f18-426f-9f20-944aad334523", new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer Service Center", "Josephine Buyengum", "Customer Care", 9, 2, "Call Center and Customer Service" },
                    { "435f3413-2f18-426f-9f20-944aa4344643", new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Financial Control Department", "Benedict Azuh", "FINCON", 6, 2, "Fin Invest and Fund Account" },
                    { "335f3413-2f18-426f-9f20-944aad323623", new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Benefit Administration Department", "Nnezi Oke", "Benefit", 7, 3, "Documentation, Processing and Payment" },
                    { "135f3413-2f18-426f-9f20-944aa1314623", new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations Department", "Iyabo Aremu", "Operations", 12, 4, "Contribution, Reconcilation, Schedules and Registrations" },
                    { "a35f3413-2fa8-426f-9f20-944aad3r4623", new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Compliance", "Abimbola Adegoke", "Compliance", 1, 1, "Complaince" },
                    { "235f3413-2f18-426f-9f20-944aad3a4623", new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Technology Solution Center", "Jide Olaniyan", "ICT", 3, 3, "IT Support, Network/Security and Application/Database" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "835f3213-2f18-426f-9f20-144aad0f962b", "435f3413-2f18-426f-9f20-944aad0r4623" },
                    { "135f3213-2f18-426f-9f20-144aad019621", "a35a3413-2f18-446f-9f30-944aad3r4633" }
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Id", "AccessFailedCount", "Address1", "Address2", "City", "ConcurrencyStamp", "Confirmed", "Country", "DateConfirmed", "DateEmployed", "DateOfBirth", "DepartmentID", "Email", "EmailConfirmed", "Firstname", "Gender", "Lastname", "Level_Of_Entry", "LockoutEnabled", "LockoutEnd", "Marital_Status", "Mobile_Phone", "NormalizedEmail", "NormalizedUserName", "Othernames", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "Rsa_Pin", "SecurityStamp", "State", "Status", "TaxID", "Title", "TwoFactorEnabled", "UserName", "branch" },
                values: new object[,]
                {
                    { "a35a3413-2f18-446f-9f30-944aad3r4633", 0, null, null, null, "10a88a8e-0e70-4f51-9526-5495d3fd3b9c", null, null, null, null, null, "235f3413-2f18-426f-9f20-944aad3a4623", "mattewo@oakpensions.com", false, "Sheyi", "Male", "Omagene", null, false, null, null, null, null, null, "Matthew", null, null, false, null, null, "db8bde20-1448-44e9-8953-a2c896f362fe", null, 1, "", null, false, null, null },
                    { "9f6b8d6e-aeb6-4cc4-94d9-06267b8f5410", 0, null, null, null, "197e5ef2-d7b4-45e3-9c1c-28eb092d9e42", null, null, null, null, null, "235f3413-2f18-426f-9f20-944aad3a4623", "ijeomam@oakpensions.com", false, "Ijeoma", "Female", "Modungwo", null, false, null, null, null, null, null, "", null, null, false, null, null, "84e5dea5-071b-4f48-94be-d2730dfcd056", null, 1, "", null, false, null, null },
                    { "a4116b98-ccf0-400f-887d-06f2b4c4ed5a", 0, null, null, null, "64cc45d1-3bed-487c-9837-8eaf713d6379", null, null, null, null, null, "235f3413-2f18-426f-9f20-944aad3a4623", "razaqo@oakpensions.com", false, "Razaq", "Male", "Olanipekun", null, false, null, null, null, null, null, "", null, null, false, null, null, "cdecde69-2775-415f-9b56-9c62cd039a3c", null, 1, "", null, false, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveAllocations_LeaveTypeId",
                table: "LeaveAllocations",
                column: "LeaveTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_EDEmployeeId",
                table: "LeaveRequests",
                column: "EDEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_EmployeeId",
                table: "LeaveRequests",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_GroupHeadEmployeeId",
                table: "LeaveRequests",
                column: "GroupHeadEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_HREmployeeId",
                table: "LeaveRequests",
                column: "HREmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_MDEmployeeId",
                table: "LeaveRequests",
                column: "MDEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_RelieverID",
                table: "LeaveRequests",
                column: "RelieverID");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_SupervisorEmployeeId",
                table: "LeaveRequests",
                column: "SupervisorEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_DepartmentID",
                table: "Staff",
                column: "DepartmentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "LeaveAllocations");

            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.DropTable(
                name: "PublicHolidays");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "LeaveTypes");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}

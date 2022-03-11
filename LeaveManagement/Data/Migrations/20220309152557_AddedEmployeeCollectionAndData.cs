using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveManagement.Data.Migrations
{
    public partial class AddedEmployeeCollectionAndData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Othernames",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Staff",
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
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "135f3213-2f18-426f-9f20-144aad019621",
                column: "ConcurrencyStamp",
                value: "dee99b31-2e50-4782-bfe9-7941e4bd4e43");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "535f3313-2f38-226f-9a20-174aad0r9625",
                column: "ConcurrencyStamp",
                value: "b7d21719-8013-4224-8a88-ba15a0d9debc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "835f3213-2f18-426f-9f20-144aad0f962b",
                column: "ConcurrencyStamp",
                value: "91121d47-35a0-4315-8b7c-6e851c847b19");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a25f3213-2f18-426f-9f20-144acd3a962a",
                column: "ConcurrencyStamp",
                value: "3c82f1da-67fb-4b4a-945a-ed1e2006296b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c35a3213-2f18-426f-9f20-144bad0r962c",
                column: "ConcurrencyStamp",
                value: "d36cde27-770c-41ff-a5a4-4e22b3998d20");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "435f3413-2f18-426f-9f20-944aad0r4623",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "521d2bc0-a6b1-4fef-934a-de8a424dc66a", "AQAAAAEAACcQAAAAEKci7jx4upRCFA3mHpsDl3zND5XB8QWzWgt2CrBgtrrS+p+uPW47CsrEOG63rHBZgw==", "1a0cac22-9e45-4406-92b5-19fed36a4089" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a35a3413-2f18-446f-9f30-944aad3r4633",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73d53aef-5473-4b7f-b162-060ddc22f4ba", "AQAAAAEAACcQAAAAEHB1GWd7VGymOpR5vZuQQGR8Mhj0FZIa25I8tj/Sm/jZgBMs4/ytArBWqiP/DteQvA==", "50b8fe7e-06f2-4548-8e59-59308bab8548" });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Id", "AccessFailedCount", "Address1", "Address2", "City", "ConcurrencyStamp", "Confirmed", "Country", "DateConfirmed", "DateEmployed", "DateOfBirth", "DepartmentID", "Email", "EmailConfirmed", "Firstname", "Gender", "Lastname", "Level_Of_Entry", "LockoutEnabled", "LockoutEnd", "Marital_Status", "Mobile_Phone", "NormalizedEmail", "NormalizedUserName", "Othernames", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "Rsa_Pin", "SecurityStamp", "State", "Status", "TaxID", "Title", "TwoFactorEnabled", "UserName", "branch" },
                values: new object[,]
                {
                    { "a35a3413-2f18-446f-9f30-944aad3r4633", 0, null, null, null, "816e8d90-069c-4beb-a3e5-a2828b04821f", null, null, null, null, null, "235f3413-2f18-426f-9f20-944aad3a4623", "mattewo@oakpensions.com", false, "Sheyi", "Male", "Omagene", null, false, null, null, null, null, null, "Matthew", null, null, false, null, null, "af35996d-e949-4e01-89fb-df43139666dc", null, 1, "", null, false, null, null },
                    { "9f6b8d6e-aeb6-4cc4-94d9-06267b8f5410", 0, null, null, null, "f2252024-6daf-4b6a-b466-3653ad09d3bd", null, null, null, null, null, "235f3413-2f18-426f-9f20-944aad3a4623", "ijeomam@oakpensions.com", false, "Ijeoma", "Female", "Modungwo", null, false, null, null, null, null, null, "", null, null, false, null, null, "682252fc-45e2-440b-93fe-e70f31e82751", null, 1, "", null, false, null, null },
                    { "a4116b98-ccf0-400f-887d-06f2b4c4ed5a", 0, null, null, null, "c3f69dcd-31dd-49b6-bebb-123c32c64951", null, null, null, null, null, "235f3413-2f18-426f-9f20-944aad3a4623", "razaqo@oakpensions.com", false, "Razaq", "Male", "Olanipekun", null, false, null, null, null, null, null, "", null, null, false, null, null, "a55d5b76-2d5a-4f5a-9bb9-5c07396f4aba", null, 1, "", null, false, null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropColumn(
                name: "Othernames",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "135f3213-2f18-426f-9f20-144aad019621",
                column: "ConcurrencyStamp",
                value: "2fadbc87-8455-441c-a4b6-cb2344c205f1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "535f3313-2f38-226f-9a20-174aad0r9625",
                column: "ConcurrencyStamp",
                value: "c683b2ef-f7f8-4df4-89ba-f2187fc8fb47");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "835f3213-2f18-426f-9f20-144aad0f962b",
                column: "ConcurrencyStamp",
                value: "9b0336b2-b49e-4445-8524-6057453c6907");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a25f3213-2f18-426f-9f20-144acd3a962a",
                column: "ConcurrencyStamp",
                value: "ccd05bbe-5e5e-41d7-a10d-7a3825faa8d6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c35a3213-2f18-426f-9f20-144bad0r962c",
                column: "ConcurrencyStamp",
                value: "6f827211-3c3c-4561-8ec8-a9d16fad7514");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "435f3413-2f18-426f-9f20-944aad0r4623",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eddfe3a8-922c-4338-904d-ff201996fa70", "AQAAAAEAACcQAAAAELvSNnn/73fYWTIwx0TAax5UypmDXHoFFEvBs7pGel3rsgQJLX8N6J7A/PgRgGAalg==", "dc59d4f8-41a5-46df-b8b5-ff952f27c927" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a35a3413-2f18-446f-9f30-944aad3r4633",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "612db39a-94fb-4104-9c42-94bc0c073c80", "AQAAAAEAACcQAAAAEJiilSTLACiPvzOQrh0atzM4WqjAwGb/1caTpIPsql3cA7+2ygVvR76vrgHbXzZM2g==", "0f770024-286f-44e9-a6a5-8fea411afc8e" });
        }
    }
}

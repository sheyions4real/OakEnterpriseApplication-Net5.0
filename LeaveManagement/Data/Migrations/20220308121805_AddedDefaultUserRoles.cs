using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveManagement.Data.Migrations
{
    public partial class AddedDefaultUserRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "835f3213-2f18-426f-9f20-144aad0f962b", "5d886669-696f-43a6-b15d-9a5f1a570f0b", "Administrator", "ADMINISTRATOR" },
                    { "a25f3213-2f18-426f-9f20-144acd3a962a", "d6affbcd-113b-44f5-a78c-20354a2dc7c9", "Supervisor", "SUPERVISOR" },
                    { "c35a3213-2f18-426f-9f20-144bad0r962c", "1938dd09-eca3-46f9-8b01-6dd38d3e6e96", "Group_Head", "GROUP HEAD" },
                    { "535f3313-2f38-226f-9a20-174aad0r9625", "503de00d-c816-418a-901a-d66c684d23e6", "HR", "HR MANAGER" },
                    { "135f3213-2f18-426f-9f20-144aad019621", "39572d15-72c2-43c1-9bdc-d926a881174a", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Confirmed", "DateConfirmed", "DateEmployed", "DateOfBirth", "DepartmentID", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxID", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "435f3413-2f18-426f-9f20-944aad0r4623", 0, "27aa15c3-6182-48a7-b4bc-4fddd3affe44", null, null, null, null, null, "admin@oakpensions.com", false, "System", "Admin", false, null, "ADMIN@OAKPENSIONS.COM", null, "AQAAAAEAACcQAAAAEJgx9BrW8y+2CZxYgaowsQ1dLSuePxyB2L4z6ueN103UpYzpNfau85XHx87XA5OkVg==", null, false, "611381d0-0444-40a0-ae77-25fcf3b219bf", null, false, null },
                    { "a35a3413-2f18-446f-9f30-944aad3r4633", 0, "13a95a96-b4c7-4ca8-b0a1-766ef74f002f", null, null, null, null, null, "mattewo@oakpensions.com", false, "System", "User", false, null, "MATTHEWO@OAKPENSIONS.COM", null, "AQAAAAEAACcQAAAAEM3SZfPJZ5TswaAJroX0jyuhj4AzDYO0xbHIPuNEWYXulrR3zPAuXWH6vp6EeAQIiQ==", null, false, "365640b8-aaf2-4eac-833b-154beea897e3", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "835f3213-2f18-426f-9f20-144aad0f962b", "435f3413-2f18-426f-9f20-944aad0r4623" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "135f3213-2f18-426f-9f20-144aad019621", "a35a3413-2f18-446f-9f30-944aad3r4633" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "535f3313-2f38-226f-9a20-174aad0r9625");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a25f3213-2f18-426f-9f20-144acd3a962a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c35a3213-2f18-426f-9f20-144bad0r962c");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "835f3213-2f18-426f-9f20-144aad0f962b", "435f3413-2f18-426f-9f20-944aad0r4623" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "135f3213-2f18-426f-9f20-144aad019621", "a35a3413-2f18-446f-9f30-944aad3r4633" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "135f3213-2f18-426f-9f20-144aad019621");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "835f3213-2f18-426f-9f20-144aad0f962b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "435f3413-2f18-426f-9f20-944aad0r4623");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a35a3413-2f18-446f-9f30-944aad3r4633");
        }
    }
}

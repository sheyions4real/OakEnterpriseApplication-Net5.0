using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveManagement.Data.Migrations
{
    public partial class AddedDefaultUserRolesAndUsername : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "135f3213-2f18-426f-9f20-144aad019621",
                column: "ConcurrencyStamp",
                value: "21ac2de6-77e6-4626-b9a9-7effcd5211df");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "535f3313-2f38-226f-9a20-174aad0r9625",
                column: "ConcurrencyStamp",
                value: "75a41fe2-1e5a-4d8d-8789-6c4ad918f2e9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "835f3213-2f18-426f-9f20-144aad0f962b",
                column: "ConcurrencyStamp",
                value: "99a6440c-cdee-49fb-a794-d06fef1b061b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a25f3213-2f18-426f-9f20-144acd3a962a",
                column: "ConcurrencyStamp",
                value: "212361b4-6896-442a-903c-2292afcb3382");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c35a3213-2f18-426f-9f20-144bad0r962c",
                column: "ConcurrencyStamp",
                value: "4ca22531-6ce4-4419-9ddc-0f2168ee0af6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "435f3413-2f18-426f-9f20-944aad0r4623",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "bc667932-b50a-4f72-971a-f12b7b2b0c12", true, "ADMIN@OAKPENSIONS.COM", "AQAAAAEAACcQAAAAEJFWvrWgPFuDBKG4M4qgRG02N7k5TxdALXVE1TI6zs3ZQKID9NNM1NnpHUGGfyoOVA==", "dc0338cb-9f65-4d9d-a10c-634cd8352016", "admin@oakpensions.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a35a3413-2f18-446f-9f30-944aad3r4633",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "16bbbd92-2124-416b-88db-9e96bde46d91", true, "MATTHEWO@OAKPENSIONS.COM", "AQAAAAEAACcQAAAAELTd0OYjs0yoEXL/KNJQUZcrvxny79tWdFY07AuOd7Iqmkqg4HNsRkKBc2dWa1bWbA==", "ab6bdf33-3ae3-4975-818c-9af51fe2da68", "mattewo@oakpensions.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "135f3213-2f18-426f-9f20-144aad019621",
                column: "ConcurrencyStamp",
                value: "39572d15-72c2-43c1-9bdc-d926a881174a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "535f3313-2f38-226f-9a20-174aad0r9625",
                column: "ConcurrencyStamp",
                value: "503de00d-c816-418a-901a-d66c684d23e6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "835f3213-2f18-426f-9f20-144aad0f962b",
                column: "ConcurrencyStamp",
                value: "5d886669-696f-43a6-b15d-9a5f1a570f0b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a25f3213-2f18-426f-9f20-144acd3a962a",
                column: "ConcurrencyStamp",
                value: "d6affbcd-113b-44f5-a78c-20354a2dc7c9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c35a3213-2f18-426f-9f20-144bad0r962c",
                column: "ConcurrencyStamp",
                value: "1938dd09-eca3-46f9-8b01-6dd38d3e6e96");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "435f3413-2f18-426f-9f20-944aad0r4623",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "27aa15c3-6182-48a7-b4bc-4fddd3affe44", false, null, "AQAAAAEAACcQAAAAEJgx9BrW8y+2CZxYgaowsQ1dLSuePxyB2L4z6ueN103UpYzpNfau85XHx87XA5OkVg==", "611381d0-0444-40a0-ae77-25fcf3b219bf", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a35a3413-2f18-446f-9f30-944aad3r4633",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "13a95a96-b4c7-4ca8-b0a1-766ef74f002f", false, null, "AQAAAAEAACcQAAAAEM3SZfPJZ5TswaAJroX0jyuhj4AzDYO0xbHIPuNEWYXulrR3zPAuXWH6vp6EeAQIiQ==", "365640b8-aaf2-4eac-833b-154beea897e3", null });
        }
    }
}

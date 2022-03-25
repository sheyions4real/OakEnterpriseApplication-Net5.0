using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveManagement.Data.Migrations
{
    public partial class UpdatedForeignKeyForStaff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DepartmentID",
                table: "Staff",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "135f3213-2f18-426f-9f20-144aad019621",
                column: "ConcurrencyStamp",
                value: "ac1bc8cf-caaf-414c-956a-192c687a6a18");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "535f3313-2f38-226f-9a20-174aad0r9625",
                column: "ConcurrencyStamp",
                value: "e12553bc-820a-4fba-9f77-a985e81d96b1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "835f3213-2f18-426f-9f20-144aad0f962b",
                column: "ConcurrencyStamp",
                value: "e91b9c89-7163-4378-8871-d55eda597ba1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a25f3213-2f18-426f-9f20-144acd3a962a",
                column: "ConcurrencyStamp",
                value: "28ac9c52-c247-4128-8670-a5d52deb77a2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c35a3213-2f18-426f-9f20-144bad0r962c",
                column: "ConcurrencyStamp",
                value: "be8a57ac-3516-43b9-abed-d401d22709f4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "435f3413-2f18-426f-9f20-944aad0r4623",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe12f40f-6a20-43d9-bdc3-3f6825298169", "AQAAAAEAACcQAAAAEA3Ew7w0TtMlrI6wXyUo2nSWjMOLsAuKiOni6vjOOMlldIc4R6+Jfn8roy6MtOBmBQ==", "b55944d7-b85a-460f-9c7d-816db38650ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a35a3413-2f18-446f-9f30-944aad3r4633",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dec2b985-eb01-4473-b3c9-0dd08f86a19a", "AQAAAAEAACcQAAAAELfsiLDSlovH6ZpY1EWx3SD0Q4q+E0Ra4dWpg1Bh+DtJz7iU5lDjMs3NXnSHUhTW3A==", "4c68e7cd-afeb-486a-afea-805060ac8178" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: "9f6b8d6e-aeb6-4cc4-94d9-06267b8f5410",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7d1d46b5-2cfc-4e44-a4c3-5c5296239b3b", "e8a22228-12d5-42ff-8775-16f9c41e2248" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: "a35a3413-2f18-446f-9f30-944aad3r4633",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bbe3d577-57d3-4e26-9724-6e5293c87972", "d3cc08b4-540c-41be-ab81-6f6edc84e3a9" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: "a4116b98-ccf0-400f-887d-06f2b4c4ed5a",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6226f01e-387a-4f31-bdc4-8eeebbf7a7e3", "d59ecad8-1d4f-4874-9a5f-cb0452572a6f" });

            migrationBuilder.CreateIndex(
                name: "IX_Staff_DepartmentID",
                table: "Staff",
                column: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Departments_DepartmentID",
                table: "Staff",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Departments_DepartmentID",
                table: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_Staff_DepartmentID",
                table: "Staff");

            migrationBuilder.AlterColumn<string>(
                name: "DepartmentID",
                table: "Staff",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Comment",
                table: "LeaveRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "135f3213-2f18-426f-9f20-144aad019621",
                column: "ConcurrencyStamp",
                value: "7a1b0da1-cd8b-46d0-a232-bac6b8b262f9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "535f3313-2f38-226f-9a20-174aad0r9625",
                column: "ConcurrencyStamp",
                value: "056eb236-c78a-43b2-9771-8636c0d3c67c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "835f3213-2f18-426f-9f20-144aad0f962b",
                column: "ConcurrencyStamp",
                value: "22df5392-bde1-4103-9846-7d34296b1733");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a25f3213-2f18-426f-9f20-144acd3a962a",
                column: "ConcurrencyStamp",
                value: "920e63e1-cf56-469d-95cc-a2a86010f025");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c35a3213-2f18-426f-9f20-144bad0r962c",
                column: "ConcurrencyStamp",
                value: "4400bebd-0d05-43bf-87ee-53873a208d73");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "435f3413-2f18-426f-9f20-944aad0r4623",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99f610fb-9700-477c-9c76-f7063ad20304", "AQAAAAEAACcQAAAAENOpXeh4OLoa9i7Jd9UZjJaWXvNlfKe/YPkGZJMoaPV9AF36lWvRWphbTxS721xeAA==", "efe0f333-a940-4ac8-9db5-3240c44e7a11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a35a3413-2f18-446f-9f30-944aad3r4633",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3e2a389-0269-4e5d-a31e-745fe3d3101e", "AQAAAAEAACcQAAAAEHynH9HQJOYHfMFnOEcOvYPPq1UCx5fOZ/t/gxTsHvX07W61PMIcO4a9AgCuLXDj7Q==", "92baece4-fcfa-49cb-8ce3-fa7ee5cae4c9" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: "9f6b8d6e-aeb6-4cc4-94d9-06267b8f5410",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b1de2798-84c2-4b1b-9a5f-b773a5c70d61", "fe84acdb-4948-4276-b1b2-4725876e595e" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: "a35a3413-2f18-446f-9f30-944aad3r4633",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e0426920-8f76-4928-9dbf-48e5f1a64031", "ec97e3a6-b289-4942-aac0-7ba0cbd20983" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: "a4116b98-ccf0-400f-887d-06f2b4c4ed5a",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f8f1e9f0-9afe-4dfe-bf26-b567fa918155", "46618185-2dfb-4c0b-8d8e-2360f8d5ce0d" });
        }
    }
}

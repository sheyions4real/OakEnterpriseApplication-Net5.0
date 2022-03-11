using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveManagement.Data.Migrations
{
    public partial class AddMoreFieldsToLeaveAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NumberOfDays",
                table: "LeaveAllocations",
                newName: "PublicHolidays");

            migrationBuilder.AddColumn<int>(
                name: "DaysAllocated",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DaysBroughtForward",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DaysUsed",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "End_Date",
                table: "LeaveAllocations",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Start_Date",
                table: "LeaveAllocations",
                type: "datetime2",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DaysAllocated",
                table: "LeaveAllocations");

            migrationBuilder.DropColumn(
                name: "DaysBroughtForward",
                table: "LeaveAllocations");

            migrationBuilder.DropColumn(
                name: "DaysUsed",
                table: "LeaveAllocations");

            migrationBuilder.DropColumn(
                name: "End_Date",
                table: "LeaveAllocations");

            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.DropColumn(
                name: "Start_Date",
                table: "LeaveAllocations");

            migrationBuilder.RenameColumn(
                name: "PublicHolidays",
                table: "LeaveAllocations",
                newName: "NumberOfDays");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "135f3213-2f18-426f-9f20-144aad019621",
                column: "ConcurrencyStamp",
                value: "5c052134-b310-4c30-a129-8219fb497674");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "535f3313-2f38-226f-9a20-174aad0r9625",
                column: "ConcurrencyStamp",
                value: "cc88cb7f-57c6-497c-8ef3-52f3e3bccfb0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "835f3213-2f18-426f-9f20-144aad0f962b",
                column: "ConcurrencyStamp",
                value: "c8ace24c-ebce-4771-a63e-7c5ea1ad63b6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a25f3213-2f18-426f-9f20-144acd3a962a",
                column: "ConcurrencyStamp",
                value: "73f0dbb4-a699-424a-937a-0d74387c0a46");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c35a3213-2f18-426f-9f20-144bad0r962c",
                column: "ConcurrencyStamp",
                value: "17caf5bf-c09f-4052-98d9-70af4569ad01");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "435f3413-2f18-426f-9f20-944aad0r4623",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d576f2b-71c0-42ad-923a-907e5a43a009", "AQAAAAEAACcQAAAAEORP8Sxf8wg2MaOKux35Qx2rxE6O0oqCwUhGsM9GM4B/5qrsuKAn4QSdouEL3z3I2w==", "1d56b9f2-c066-44fb-8bd6-91bbd1043b3f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a35a3413-2f18-446f-9f30-944aad3r4633",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4aa188e-abb1-4683-b95e-72ce644b24d3", "AQAAAAEAACcQAAAAEClnGiZ8XX6fExueC6itzQS4S9EuPpwkBLvp+P/jyUGD1Ywy0PzlFbu5Di7lEKS4YQ==", "08e60df9-3c85-446a-b0a6-ad24e59201f8" });
        }
    }
}

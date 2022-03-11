using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveManagement.Data.Migrations
{
    public partial class ChangeToEmployeeProfileCollectionAndData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "135f3213-2f18-426f-9f20-144aad019621",
                column: "ConcurrencyStamp",
                value: "c996299a-57c2-4494-a9ac-4db514af30d8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "535f3313-2f38-226f-9a20-174aad0r9625",
                column: "ConcurrencyStamp",
                value: "b31d30f6-1454-46af-8703-1865e7550c86");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "835f3213-2f18-426f-9f20-144aad0f962b",
                column: "ConcurrencyStamp",
                value: "a7e0370f-ab01-476b-83f4-78be67a247f0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a25f3213-2f18-426f-9f20-144acd3a962a",
                column: "ConcurrencyStamp",
                value: "0ac2cf47-e22a-4119-968a-42cda7b543a9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c35a3213-2f18-426f-9f20-144bad0r962c",
                column: "ConcurrencyStamp",
                value: "12ed929a-a993-4cb4-87fd-86451b3f8d25");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "435f3413-2f18-426f-9f20-944aad0r4623",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45e28b8c-124a-48ef-b3bb-cb13071872a2", "AQAAAAEAACcQAAAAEEX2iN3Cx8SkWThjUIpiDVNJx+uc6IbjZb8wn28nai1SI533GhWrBbp5nO2oQ1VOrA==", "25b8a278-f938-401f-9a54-8677129c074e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a35a3413-2f18-446f-9f30-944aad3r4633",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8bfc0cbb-5c23-4005-8e97-887be0f22c4d", "AQAAAAEAACcQAAAAENUdEa33O2sijsyQc+y+huoYUo/OIUzPI4ZEqdmHErqt9LBTq7QwtOr8U5s/A4SAww==", "dfdcdf7c-2313-4913-aa51-d66afe8fdeb4" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: "9f6b8d6e-aeb6-4cc4-94d9-06267b8f5410",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4154bf64-2134-462d-bcb4-f933a4b2a633", "ba69d2ca-9840-4776-9495-4aef2f961ec0" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: "a35a3413-2f18-446f-9f30-944aad3r4633",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ab1fe58e-3688-4110-b2b7-69efa49f2a29", "57628f73-13ae-482f-8dbd-b9907e15034c" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: "a4116b98-ccf0-400f-887d-06f2b4c4ed5a",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cfb91345-f009-4efb-92c6-d1d9b36d15e6", "f8ec3dda-7ce1-40db-a6be-03f1fb321c82" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: "9f6b8d6e-aeb6-4cc4-94d9-06267b8f5410",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f2252024-6daf-4b6a-b466-3653ad09d3bd", "682252fc-45e2-440b-93fe-e70f31e82751" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: "a35a3413-2f18-446f-9f30-944aad3r4633",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "816e8d90-069c-4beb-a3e5-a2828b04821f", "af35996d-e949-4e01-89fb-df43139666dc" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: "a4116b98-ccf0-400f-887d-06f2b4c4ed5a",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c3f69dcd-31dd-49b6-bebb-123c32c64951", "a55d5b76-2d5a-4f5a-9bb9-5c07396f4aba" });
        }
    }
}

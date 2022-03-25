using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveManagement.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RelieverID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SupervisorEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupervisorApproval = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupervisorComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HREmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HRApproval = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HRComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroupHeadEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroupHeadApproval = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GHComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MDEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MDApproval = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                        onDelete: ReferentialAction.Restrict); // if i delete leave type  all references will be deleted  if set to Cascade
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveManagement.Data.Migrations
{
    public partial class UpdateLeaveRequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "SupervisorApproval",
                table: "LeaveRequests",
                type: "bit",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "MDApproval",
                table: "LeaveRequests",
                type: "bit",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "HRApproval",
                table: "LeaveRequests",
                type: "bit",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "GroupHeadApproval",
                table: "LeaveRequests",
                type: "bit",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "EDApproval",
                table: "LeaveRequests",
                type: "bit",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LeaveYear",
                table: "LeaveRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalDaysRequested",
                table: "LeaveRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalOutstanding",
                table: "LeaveRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalPublicHolidays",
                table: "LeaveRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "135f3213-2f18-426f-9f20-144aad019621",
                column: "ConcurrencyStamp",
                value: "0db49397-c49e-445a-9c35-10217f471609");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "535f3313-2f38-226f-9a20-174aad0r9625",
                column: "ConcurrencyStamp",
                value: "6ca8b4c8-488c-484e-bc59-7a7181563192");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "835f3213-2f18-426f-9f20-144aad0f962b",
                column: "ConcurrencyStamp",
                value: "70d91574-55a7-4b87-ba88-92aadd4c9c54");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a25f3213-2f18-426f-9f20-144acd3a962a",
                column: "ConcurrencyStamp",
                value: "dec4d2a6-1547-4005-8744-eef8f522a2a6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c35a3213-2f18-426f-9f20-144bad0r962c",
                column: "ConcurrencyStamp",
                value: "823fa8a6-6454-47c6-816a-8599cf4987e7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "992f3213-2f18-426f-9f30-144aad219289", "b89e9a83-01b4-4960-b61b-a17747dc6736", "ED", "ED" },
                    { "785f3813-2f18-426f-9820-144aad719899", "e0dc5572-02ad-4dee-9907-63335e6df404", "MD", "MD" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "435f3413-2f18-426f-9f20-944aad0r4623",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1802c4a2-0994-4691-9858-303620a5aaf5", "AQAAAAEAACcQAAAAENtxOCLfUI1xlN+uxo/xMcfxR+eyknD2N2QUDvMQUzZXogjv5ajIRoPnQnlp3IY7fg==", "2e29028f-e66f-4ca6-a5cf-b96905c8417f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a35a3413-2f18-446f-9f30-944aad3r4633",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23bb058f-8870-4363-82a9-f48b27a73a08", "AQAAAAEAACcQAAAAEBAdZ7+5t/gLx9+lVp3FAlungcRrEtbRgo7WIwlXmo3kiWvlrzOnILmFJ6Xv2xGAxw==", "c17a228a-1c42-459e-8595-ee0cd272d8e3" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: "9f6b8d6e-aeb6-4cc4-94d9-06267b8f5410",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cf7506fd-a362-4477-8d1d-00a1e4fbce1f", "b33be573-4255-4bd9-b6c5-6ff615cd60ac" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: "a35a3413-2f18-446f-9f30-944aad3r4633",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "088c4934-e409-4ea8-9fa6-a68f2227237f", "3af56fd1-07b5-4c03-aab4-f537f019aed6" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: "a4116b98-ccf0-400f-887d-06f2b4c4ed5a",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "767f8df5-b77e-4e37-a75a-177f5e76b999", "dc0cc084-76ee-49b4-96fa-41765c0c2fbc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PublicHolidays");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "785f3813-2f18-426f-9820-144aad719899");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "992f3213-2f18-426f-9f30-144aad219289");

            migrationBuilder.DropColumn(
                name: "LeaveYear",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "TotalDaysRequested",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "TotalOutstanding",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "TotalPublicHolidays",
                table: "LeaveRequests");

            migrationBuilder.AlterColumn<string>(
                name: "SupervisorApproval",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MDApproval",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HRApproval",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GroupHeadApproval",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EDApproval",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "135f3213-2f18-426f-9f20-144aad019621",
                column: "ConcurrencyStamp",
                value: "5f4e7397-dc04-4ed5-83e1-077ac2d1d284");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "535f3313-2f38-226f-9a20-174aad0r9625",
                column: "ConcurrencyStamp",
                value: "08e868d1-7d5b-42d4-8f65-2345e8a160a3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "835f3213-2f18-426f-9f20-144aad0f962b",
                column: "ConcurrencyStamp",
                value: "16f39b7c-4ffe-4c71-a5df-144a40dd219f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a25f3213-2f18-426f-9f20-144acd3a962a",
                column: "ConcurrencyStamp",
                value: "cf5e9da4-cb47-4234-83db-3a95b93f6ed1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c35a3213-2f18-426f-9f20-144bad0r962c",
                column: "ConcurrencyStamp",
                value: "2224f3e3-f4b5-4007-9fba-e2da9a3fa5fe");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "435f3413-2f18-426f-9f20-944aad0r4623",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76475ae6-15f8-4706-8b72-b84078c55c40", "AQAAAAEAACcQAAAAEEEcAoCEgmIRCHcv4dZMD7Niu18/Hv1ZC9yVOrW76cmTOhcCKDEU9kJUT86/KWefTA==", "738884b0-df0d-4490-ba6e-6ed23b3584cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a35a3413-2f18-446f-9f30-944aad3r4633",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9798720-3b66-41af-9ce3-5b312854d274", "AQAAAAEAACcQAAAAEEf5Mmbz8J6+/835QRONYxLQKFEdL+KbIFLUjJOdZS40zC67842wS6YAFpifrfeeIg==", "15ee5e07-eeb7-41d0-a544-61b89db59d25" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: "9f6b8d6e-aeb6-4cc4-94d9-06267b8f5410",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "41c0ec8c-8e72-425b-8b89-bcec667fb64b", "febe2b95-e8e5-4ac5-901b-b72e4a5b77f0" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: "a35a3413-2f18-446f-9f30-944aad3r4633",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a6524285-e8b4-4158-8df7-c03b2a12629e", "31d21c7f-79ee-423c-954e-e1e2591774a5" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: "a4116b98-ccf0-400f-887d-06f2b4c4ed5a",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "648c49e2-aebd-46f1-8bb8-7767a9b2d7c9", "83fbed34-9df1-4bc9-bc84-13f3e563c86a" });
        }
    }
}

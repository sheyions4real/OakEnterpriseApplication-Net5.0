using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveManagement.Data.Migrations
{
    public partial class UpdateLeaveRequest2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "135f3213-2f18-426f-9f20-144aad019621",
                column: "ConcurrencyStamp",
                value: "bb8fcc90-c862-4fb2-b24b-9f9f5b140d89");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "535f3313-2f38-226f-9a20-174aad0r9625",
                column: "ConcurrencyStamp",
                value: "92678bb2-abe6-4a03-834f-11bb30b8bb6b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "785f3813-2f18-426f-9820-144aad719899",
                column: "ConcurrencyStamp",
                value: "68a625c1-4eff-4d2d-9b26-2c4b01a326ca");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "835f3213-2f18-426f-9f20-144aad0f962b",
                column: "ConcurrencyStamp",
                value: "15bfdfed-cd0e-451d-9455-e2573e519d35");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "992f3213-2f18-426f-9f30-144aad219289",
                column: "ConcurrencyStamp",
                value: "5701200e-89b4-4e99-bb15-b6696040e825");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a25f3213-2f18-426f-9f20-144acd3a962a",
                column: "ConcurrencyStamp",
                value: "21f52306-890f-4e53-8ed4-68c9ad6217b8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c35a3213-2f18-426f-9f20-144bad0r962c",
                column: "ConcurrencyStamp",
                value: "891b7df1-a2ce-4499-9161-6f07e179c3c1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "435f3413-2f18-426f-9f20-944aad0r4623",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d730912b-f821-4343-86f4-b47a738bfc5f", "AQAAAAEAACcQAAAAEF1CPByIFDbjitISKFRh+22dNVoF+8slF0moqQ8On/0+QAHfj/jzo/2Lt+DQOgq9Wg==", "d71a4fb0-2b73-4814-9113-46a25845d91a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a35a3413-2f18-446f-9f30-944aad3r4633",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aef122d0-8c54-4b1e-9500-56391d4983fb", "MATTEWO@OAKPENSIONS.COM", "MATTEWO@OAKPENSIONS.COM", "AQAAAAEAACcQAAAAEIOUcYoq+ERq+ExArtpShoX+DFOG5znlvww8Utmgq6ypAVw/geXwIpr+Cgcwg+UtCw==", "0e5f9bdb-93b3-465c-a757-61a82740fb3b" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: "9f6b8d6e-aeb6-4cc4-94d9-06267b8f5410",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "133c511c-d7e4-4de0-a994-3255b11ee761", "87b16ea2-3d66-4e73-806c-d9a02c3b3b01" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: "a35a3413-2f18-446f-9f30-944aad3r4633",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "20f83276-b8a4-4160-ba3e-22fead3b942f", "2180de76-2d15-4518-b0a2-a194fd8b4099" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: "a4116b98-ccf0-400f-887d-06f2b4c4ed5a",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c5a15130-c795-4b8b-8810-add9a9fbd834", "26c46509-67b8-4c41-a225-7513025d1b6b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValue: "785f3813-2f18-426f-9820-144aad719899",
                column: "ConcurrencyStamp",
                value: "e0dc5572-02ad-4dee-9907-63335e6df404");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "835f3213-2f18-426f-9f20-144aad0f962b",
                column: "ConcurrencyStamp",
                value: "70d91574-55a7-4b87-ba88-92aadd4c9c54");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "992f3213-2f18-426f-9f30-144aad219289",
                column: "ConcurrencyStamp",
                value: "b89e9a83-01b4-4960-b61b-a17747dc6736");

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
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23bb058f-8870-4363-82a9-f48b27a73a08", "MATTHEWO@OAKPENSIONS.COM", "MATTHEWO@OAKPENSIONS.COM", "AQAAAAEAACcQAAAAEBAdZ7+5t/gLx9+lVp3FAlungcRrEtbRgo7WIwlXmo3kiWvlrzOnILmFJ6Xv2xGAxw==", "c17a228a-1c42-459e-8595-ee0cd272d8e3" });

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
    }
}

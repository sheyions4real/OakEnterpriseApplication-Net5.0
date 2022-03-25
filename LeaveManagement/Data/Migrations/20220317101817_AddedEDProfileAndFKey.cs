using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveManagement.Data.Migrations
{
    public partial class AddedEDProfileAndFKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "135f3213-2f18-426f-9f20-144aad019621",
                column: "ConcurrencyStamp",
                value: "f9c7b9bd-76d8-4590-8b73-c63809ffd676");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "535f3313-2f38-226f-9a20-174aad0r9625",
                column: "ConcurrencyStamp",
                value: "475246df-a65a-4bbc-9f8c-442b6f87b072");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "835f3213-2f18-426f-9f20-144aad0f962b",
                column: "ConcurrencyStamp",
                value: "c99a942e-2485-47cc-a1c1-def741b8b1e1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a25f3213-2f18-426f-9f20-144acd3a962a",
                column: "ConcurrencyStamp",
                value: "cc541337-4426-4d94-96df-1410957148aa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c35a3213-2f18-426f-9f20-144bad0r962c",
                column: "ConcurrencyStamp",
                value: "5913cbc5-db40-4e1a-ba0a-2b816e7d2edc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "435f3413-2f18-426f-9f20-944aad0r4623",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6a36625-db1e-4d1a-bcb9-71d6ddc45520", "AQAAAAEAACcQAAAAECczGDGU5tapdMeJg5oxjhtfXiiVW1Gx0xselKAwhy/POEi6ED4O6E6ucE+eDn1lig==", "1541589b-69a1-4206-bf3c-71f8ccca7725" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a35a3413-2f18-446f-9f30-944aad3r4633",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5044ee16-df65-4cc3-98be-c243a6933b7e", "AQAAAAEAACcQAAAAEOrCAW/72+fMggrgrDMvyKYUiJXnVU01mQdAHyvysVsn59PEPK1waF6CPbTn1TjhDw==", "85aa050b-9286-450f-8a00-a2f7ca9ebc3b" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: "9f6b8d6e-aeb6-4cc4-94d9-06267b8f5410",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "998f5aac-1eae-4a76-8aae-f077ab848fd1", "9541df66-b205-4e40-b4b3-de8426bb6cca" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: "a35a3413-2f18-446f-9f30-944aad3r4633",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e4cae806-975a-424b-a840-2d4dee203200", "d85974d6-d03d-42a8-908e-9e6adddf0005" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: "a4116b98-ccf0-400f-887d-06f2b4c4ed5a",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f8555c8f-f92c-491d-b387-011b362599cc", "4df0175f-26bb-4dbe-857c-31644c4c763b" });
        }
    }
}

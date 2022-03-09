using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveManagement.Data.Migrations
{
    public partial class AddDepartmentTableAndSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateEmployed",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HOD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number_Of_Staff = table.Column<int>(type: "int", nullable: false),
                    Number_Of_Units = table.Column<int>(type: "int", nullable: false),
                    Units = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "DateCreated", "DateModified", "Description", "HOD", "Name", "Number_Of_Staff", "Number_Of_Units", "Units" },
                values: new object[,]
                {
                    { "c35f3413-2318-426f-9e20-944aad3r46c3", new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "MD Office", "Aliyu Abdullahi", "MD Office", 3, 1, "MD Office" },
                    { "a35f3413-2f68-426f-9f20-944bad3r46ac", new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "ED Office", "Abdulwahab Ige", "ED Office", 1, 1, "ED Office" },
                    { "b35f3413-2f18-4b6f-9f20-944bbd334623", new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Legal", "Alamin Shekoni", "Legal", 1, 1, "Legal" },
                    { "a35f3413-2fa8-426f-9f20-944aad3r4623", new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Compliance", "Abimbola Adegoke", "Compliance", 1, 1, "Complaince" },
                    { "a35f3413-2f18-42af-9f20-94aaad394623", new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Investment Department", "Bola Ibrahim", "Investment", 6, 2, "Investment and Investment Research" },
                    { "435f3413-2f18-426f-9f20-544aad364623", new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Business Development and Relationship Management", "Akinwumi Odunewu", "BDRM", 50, 2, "Business Development and Relationship Management" },
                    { "a35f3413-5f18-426f-6f20-944aa6314623", new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources and Administration", "Henry Christopher", "HR/Admin", 5, 2, "HR and Admin" },
                    { "535f3413-5f18-426f-9f20-944aad334523", new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer Service Center", "Josephine Buyengum", "Customer Care", 9, 2, "Call Center and Customer Service" },
                    { "435f3413-2f18-426f-9f20-944aa4344643", new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Financial Control Department", "Benedict Azuh", "FINCON", 6, 2, "Fin Invest and Fund Account" },
                    { "335f3413-2f18-426f-9f20-944aad323623", new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Benefit Administration Department", "Nnezi Oke", "Benefit", 7, 3, "Documentation, Processing and Payment" },
                    { "135f3413-2f18-426f-9f20-944aa1314623", new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations Department", "Iyabo Aremu", "Operations", 12, 4, "Contribution, Reconcilation, Schedules and Registrations" },
                    { "535f3413-2f18-456f-9f20-944aad544623", new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Internal Control", "Adebusuyi Adebayo", "Internal Audit", 5, 2, "Internal Control and Internal Audit" },
                    { "235f3413-2f18-426f-9f20-944aad3a4623", new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Technology Solution Center", "Jide Olaniyan", "ICT", 3, 3, "IT Support, Network/Security and Application/Database" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.AlterColumn<string>(
                name: "DateEmployed",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc667932-b50a-4f72-971a-f12b7b2b0c12", "AQAAAAEAACcQAAAAEJFWvrWgPFuDBKG4M4qgRG02N7k5TxdALXVE1TI6zs3ZQKID9NNM1NnpHUGGfyoOVA==", "dc0338cb-9f65-4d9d-a10c-634cd8352016" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a35a3413-2f18-446f-9f30-944aad3r4633",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16bbbd92-2124-416b-88db-9e96bde46d91", "AQAAAAEAACcQAAAAELTd0OYjs0yoEXL/KNJQUZcrvxny79tWdFY07AuOd7Iqmkqg4HNsRkKBc2dWa1bWbA==", "ab6bdf33-3ae3-4975-818c-9af51fe2da68" });
        }
    }
}

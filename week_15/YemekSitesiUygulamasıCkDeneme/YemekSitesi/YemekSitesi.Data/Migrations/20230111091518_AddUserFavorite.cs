using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YemekSitesi.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddUserFavorite : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "70ad1f2b-14ba-4ff3-9e68-c77dd3e51f5f", "19ca8f79-dbc4-4ae1-b403-7ef547a5cd5f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "02e76745-e297-4ea2-aac6-4b6ce73f5ad0", "2162baf6-99e2-4718-885b-d09259995d57" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02e76745-e297-4ea2-aac6-4b6ce73f5ad0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70ad1f2b-14ba-4ff3-9e68-c77dd3e51f5f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19ca8f79-dbc4-4ae1-b403-7ef547a5cd5f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2162baf6-99e2-4718-885b-d09259995d57");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4991494a-0413-4774-806e-1ba5eee5b2c4", null, "User Rolü", "User", "USER" },
                    { "9cce90fe-d2c7-44b9-93cf-3854f1d225a3", null, "Admin Rolü", "Admin", "ADMİN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b2fed76d-f4a7-487a-9db7-24668c149620", 0, "f5a8a807-28fc-4562-86ee-113f0122935c", new DateTime(1986, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", true, "Ornek", "Erkek", "User", false, null, "USER@GMAIL.COM", "USER", "AQAAAAIAAYagAAAAEAJo0XlyeMm/frYHyRukmSqidMkaEJhVJ6xQcuB5cVeHLBpfk65vh/+PoCIHBe/98w==", null, false, "ebcfd13a-c5e3-401d-b732-6f80560c0b98", false, "user" },
                    { "c8c884c4-7d07-4c96-b89b-61065c1403c2", 0, "de44552b-fbac-47ab-84bd-6896bc70b9f0", new DateTime(1980, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "Sümeyye", "Kadın", "Yüce", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEOCyGEsKuL2JE76Bpbok3sDsnNxe6+fhUVv3CPx0HL+u3RpwLaC3xlBwurt5ntM99A==", null, false, "d1e51554-76ef-4d0e-8ece-65cb3fdb3621", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "4991494a-0413-4774-806e-1ba5eee5b2c4", "b2fed76d-f4a7-487a-9db7-24668c149620" },
                    { "9cce90fe-d2c7-44b9-93cf-3854f1d225a3", "c8c884c4-7d07-4c96-b89b-61065c1403c2" }
                });

            migrationBuilder.InsertData(
                table: "Favorites",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, "c8c884c4-7d07-4c96-b89b-61065c1403c2" },
                    { 2, "b2fed76d-f4a7-487a-9db7-24668c149620" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4991494a-0413-4774-806e-1ba5eee5b2c4", "b2fed76d-f4a7-487a-9db7-24668c149620" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9cce90fe-d2c7-44b9-93cf-3854f1d225a3", "c8c884c4-7d07-4c96-b89b-61065c1403c2" });

            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4991494a-0413-4774-806e-1ba5eee5b2c4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9cce90fe-d2c7-44b9-93cf-3854f1d225a3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2fed76d-f4a7-487a-9db7-24668c149620");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c8c884c4-7d07-4c96-b89b-61065c1403c2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "02e76745-e297-4ea2-aac6-4b6ce73f5ad0", null, "User Rolü", "User", "USER" },
                    { "70ad1f2b-14ba-4ff3-9e68-c77dd3e51f5f", null, "Admin Rolü", "Admin", "ADMİN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "19ca8f79-dbc4-4ae1-b403-7ef547a5cd5f", 0, "1a9e5275-a6a2-43d4-876b-5b102378494e", new DateTime(1980, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "Sümeyye", "Kadın", "Yüce", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEPoxS9uuahwK9EQgXWALKYlPRUccH8q5Z5nZV7pdk92ExvJcq8N35VrpWyk4tOq0Qg==", null, false, "dc6f45fe-467f-435f-a6af-d2ea82263a9b", false, "admin" },
                    { "2162baf6-99e2-4718-885b-d09259995d57", 0, "3e5f86f1-1664-4338-9f44-2e156f1ea626", new DateTime(1986, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", true, "Ornek", "Erkek", "User", false, null, "USER@GMAIL.COM", "USER", "AQAAAAIAAYagAAAAEIuHASItRgMEKaPJgKskRaCMdJqzkmFS0o+f0kqxdBKmXGB3PThPGDZL5FB1WC1ThQ==", null, false, "8c49029b-55b0-4ff1-9bf9-7355d2086646", false, "user" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "70ad1f2b-14ba-4ff3-9e68-c77dd3e51f5f", "19ca8f79-dbc4-4ae1-b403-7ef547a5cd5f" },
                    { "02e76745-e297-4ea2-aac6-4b6ce73f5ad0", "2162baf6-99e2-4718-885b-d09259995d57" }
                });
        }
    }
}

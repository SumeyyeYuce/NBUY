using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShoppingApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddUserCard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "222abfde-18fa-4f4e-8a14-9d9780d2bfe4", "11f8877c-4caa-4e05-990c-dc09f3cbc21a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "da7d03d2-4a71-4393-a077-a680f8fb7db8", "413ebc42-b5a6-45c9-82d6-49f880139b49" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "222abfde-18fa-4f4e-8a14-9d9780d2bfe4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da7d03d2-4a71-4393-a077-a680f8fb7db8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11f8877c-4caa-4e05-990c-dc09f3cbc21a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "413ebc42-b5a6-45c9-82d6-49f880139b49");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "83e0307a-c055-4bc3-90c2-81c360d8b39b", null, "Admin rolü", "Admin", "ADMİN" },
                    { "b1491393-59dd-4da3-b04d-c26c35dcaadd", null, "User rolü", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "933e2901-3df8-4df9-9e47-57499bc71e24", 0, "e5741e5e-e84b-4f17-ad0f-afd5ec048433", new DateTime(1985, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", true, "Kemal", "Erkek", "User", false, null, "USER@GMAIL.COM", "USER", "AQAAAAIAAYagAAAAEJwpz1AQ714121aqKg1AflOOWgebEIlC8Sp8iBou9YqnLXbiMVxZW5bsgcNbumO/hA==", null, false, "75ac04e2-83bc-41a7-8d58-1864f5087aff", false, "user" },
                    { "e0e3f13c-030c-43ca-bbf9-c45b1b31e94c", 0, "fd10cd3f-7503-49d9-894a-8a6170a3320c", new DateTime(1998, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "Deniz", "Kadın", "Admin", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEIDZqUIv02WM/3hBr/c2UGNx9VSICuk+sJk1n+cW2xYp4dwMU64enDXGB0qwiZ588A==", null, false, "7884f12d-f0d6-464f-ae21-d90d5e2fa0e6", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b1491393-59dd-4da3-b04d-c26c35dcaadd", "933e2901-3df8-4df9-9e47-57499bc71e24" },
                    { "83e0307a-c055-4bc3-90c2-81c360d8b39b", "e0e3f13c-030c-43ca-bbf9-c45b1b31e94c" }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, "e0e3f13c-030c-43ca-bbf9-c45b1b31e94c" },
                    { 2, "933e2901-3df8-4df9-9e47-57499bc71e24" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1491393-59dd-4da3-b04d-c26c35dcaadd", "933e2901-3df8-4df9-9e47-57499bc71e24" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "83e0307a-c055-4bc3-90c2-81c360d8b39b", "e0e3f13c-030c-43ca-bbf9-c45b1b31e94c" });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83e0307a-c055-4bc3-90c2-81c360d8b39b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1491393-59dd-4da3-b04d-c26c35dcaadd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "933e2901-3df8-4df9-9e47-57499bc71e24");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0e3f13c-030c-43ca-bbf9-c45b1b31e94c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "222abfde-18fa-4f4e-8a14-9d9780d2bfe4", null, "User rolü", "User", "USER" },
                    { "da7d03d2-4a71-4393-a077-a680f8fb7db8", null, "Admin rolü", "Admin", "ADMİN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "11f8877c-4caa-4e05-990c-dc09f3cbc21a", 0, "59651463-4c6d-44a5-a02c-4148faca8eab", new DateTime(1985, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", true, "Kemal", "Erkek", "User", false, null, "USER@GMAIL.COM", "USER", "AQAAAAIAAYagAAAAEFgSOAAD7RW21370uHORG99tHBjCjNPe6i4ZXZXUOJB1ezjo+CATmMrXsdcuiOjusQ==", null, false, "34719632-5fa3-4290-9f0d-c0b547a1ad10", false, "user" },
                    { "413ebc42-b5a6-45c9-82d6-49f880139b49", 0, "87b09b61-8b45-4009-9878-79275c189a63", new DateTime(1998, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "Deniz", "Kadın", "Admin", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAECsCU6+lSH72cBuCJ6r4oFGwdAmyy1MCbtzZSQG5ZGJFuwtmP/KLZ055p3qTEND4tg==", null, false, "5ec7e2a5-2b7c-4518-80f6-0d1376a419d6", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "222abfde-18fa-4f4e-8a14-9d9780d2bfe4", "11f8877c-4caa-4e05-990c-dc09f3cbc21a" },
                    { "da7d03d2-4a71-4393-a077-a680f8fb7db8", "413ebc42-b5a6-45c9-82d6-49f880139b49" }
                });
        }
    }
}

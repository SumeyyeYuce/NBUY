using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShoppingApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b7aeb3e5-aca8-4b2b-a754-cd509be11bab", "2acf09e4-cdff-4934-a3a5-e26180ce7753" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8c5250d9-a41f-4d70-9a7d-fa1bba7db5a6", "31d2fbf0-c688-4ac5-9c88-28a5f89e53fb" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c5250d9-a41f-4d70-9a7d-fa1bba7db5a6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7aeb3e5-aca8-4b2b-a754-cd509be11bab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2acf09e4-cdff-4934-a3a5-e26180ce7753");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31d2fbf0-c688-4ac5-9c88-28a5f89e53fb");

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cards_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CardItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    CardId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardItems_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CardItems_CardId",
                table: "CardItems",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_CardItems_ProductId",
                table: "CardItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_UserId",
                table: "Cards",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardItems");

            migrationBuilder.DropTable(
                name: "Cards");

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
                    { "8c5250d9-a41f-4d70-9a7d-fa1bba7db5a6", null, "Admin rolü", "Admin", "ADMİN" },
                    { "b7aeb3e5-aca8-4b2b-a754-cd509be11bab", null, "User rolü", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2acf09e4-cdff-4934-a3a5-e26180ce7753", 0, "b4d16c36-5da9-4c69-892d-373d11a74f69", new DateTime(1985, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", true, "Kemal", "Erkek", "User", false, null, "USER@GMAİL.COM", "USER", "AQAAAAIAAYagAAAAEGX23EorTkvP6UiczpUXf3bge4fH1XKjqUkCfMX11iIepf7ESNpB1/iABLZVYbBLdQ==", null, false, "0425da4e-7d65-4dcc-a7b0-0dd7083af7ba", false, "user" },
                    { "31d2fbf0-c688-4ac5-9c88-28a5f89e53fb", 0, "45a52e34-763d-4919-b1a8-0db3b6e60122", new DateTime(1998, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "Deniz", "Kadın", "Admin", false, null, "ADMIN@GMAİL.COM", "ADMIN", "AQAAAAIAAYagAAAAEGajhmAXadUK76ZhSZIJEFKDfKvqStSLKiEFILxaThQ1TpFFYb4ju3ZhcHVP0eXqog==", null, false, "07fab84d-ef1c-4d64-95d7-ab1dabcf0a35", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b7aeb3e5-aca8-4b2b-a754-cd509be11bab", "2acf09e4-cdff-4934-a3a5-e26180ce7753" },
                    { "8c5250d9-a41f-4d70-9a7d-fa1bba7db5a6", "31d2fbf0-c688-4ac5-9c88-28a5f89e53fb" }
                });
        }
    }
}

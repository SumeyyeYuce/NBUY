using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YemekSitesi.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddFavorite : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a075ac2b-3d93-4bc9-b257-bd400d06f05d", "98eb61c0-78fb-44b7-83ad-271f6499edae" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d946c549-a82d-43ec-a1fd-0f2914fa46fd", "fde75564-20a9-4b48-9c12-eb97fffbd814" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a075ac2b-3d93-4bc9-b257-bd400d06f05d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d946c549-a82d-43ec-a1fd-0f2914fa46fd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98eb61c0-78fb-44b7-83ad-271f6499edae");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fde75564-20a9-4b48-9c12-eb97fffbd814");

            migrationBuilder.CreateTable(
                name: "Favorites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Favorites_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FavoriteItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FoodId = table.Column<int>(type: "INTEGER", nullable: false),
                    FavoriteId = table.Column<int>(type: "INTEGER", nullable: false),
                    FavortiteNumber = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavoriteItems_Favorites_FavoriteId",
                        column: x => x.FavoriteId,
                        principalTable: "Favorites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteItems_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteItems_FavoriteId",
                table: "FavoriteItems",
                column: "FavoriteId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteItems_FoodId",
                table: "FavoriteItems",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_UserId",
                table: "Favorites",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoriteItems");

            migrationBuilder.DropTable(
                name: "Favorites");

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
                    { "a075ac2b-3d93-4bc9-b257-bd400d06f05d", null, "Admin Rolü", "Admin", "ADMİN" },
                    { "d946c549-a82d-43ec-a1fd-0f2914fa46fd", null, "User Rolü", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "98eb61c0-78fb-44b7-83ad-271f6499edae", 0, "0d152303-ec6b-4247-9a61-c915a814a500", new DateTime(1980, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "Sümeyye", "Kadın", "Yüce", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEFWjsGJuDORTcjtl3dz3SIOL+7srC7I47+cY55QHvaPAdlBKwz+RG8NO1aZ2yhEr2Q==", null, false, "000c3be7-8692-4b84-b7f4-8f2c5b2a44a8", false, "admin" },
                    { "fde75564-20a9-4b48-9c12-eb97fffbd814", 0, "6d001b10-21cd-414e-9074-577c2ada1216", new DateTime(1986, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", true, "Ornek", "Erkek", "User", false, null, "USER@GMAIL.COM", "USER", "AQAAAAIAAYagAAAAEIBZdP2wZ+DPx62AQFP7P0UlKeCAGrnQKGiOPr7ca/nv8+DjLvlHPSRuftghPJWu4Q==", null, false, "e6ae208e-18ce-447e-8481-fcf8298e100a", false, "user" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "a075ac2b-3d93-4bc9-b257-bd400d06f05d", "98eb61c0-78fb-44b7-83ad-271f6499edae" },
                    { "d946c549-a82d-43ec-a1fd-0f2914fa46fd", "fde75564-20a9-4b48-9c12-eb97fffbd814" }
                });
        }
    }
}

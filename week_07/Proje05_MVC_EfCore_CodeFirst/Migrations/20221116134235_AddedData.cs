using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proje05_MVC_EfCore_CodeFirst.Migrations
{
    public partial class AddedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Desc", "Name" },
                values: new object[] { 1, "Phones", "Phone" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Desc", "Name" },
                values: new object[] { 2, "Computers", "Computer" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Desc", "Name" },
                values: new object[] { 3, "Electronics", "Electronic" });

            migrationBuilder.InsertData(
                table: "Citys",
                columns: new[] { "Id", "Name" },
                values: new object[] { 18, "ÇANAKKALE" });

            migrationBuilder.InsertData(
                table: "Citys",
                columns: new[] { "Id", "Name" },
                values: new object[] { 34, "İSTANBUL" });

            migrationBuilder.InsertData(
                table: "Citys",
                columns: new[] { "Id", "Name" },
                values: new object[] { 35, "izmir" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Desc", "Name", "Price" },
                values: new object[] { 1, 1, "Güzel", "iPHONE", 19000m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Desc", "Name", "Price" },
                values: new object[] { 2, 2, "Güzel", "Dell", 25000m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Desc", "Name", "Price" },
                values: new object[] { 3, 1, "kamera güzel", "SAMSUNG A71", 17000m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Desc", "Name", "Price" },
                values: new object[] { 4, 3, "Heryerde ses", "Pirana x13", 1000m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Citys",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Citys",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Citys",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");
        }
    }
}

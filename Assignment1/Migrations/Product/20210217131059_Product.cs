using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment1.Migrations.Product
{
    public partial class Product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    productId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productName = table.Column<string>(nullable: false),
                    productPrice = table.Column<double>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.productId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "productId", "DateAdded", "productName", "productPrice" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 2, 17, 8, 10, 59, 294, DateTimeKind.Local).AddTicks(6071), "Computer Mouse", 29.989999999999998 },
                    { 2, new DateTime(2021, 2, 17, 8, 10, 59, 296, DateTimeKind.Local).AddTicks(7924), "Computer Headset", 49.990000000000002 },
                    { 3, new DateTime(2021, 2, 17, 8, 10, 59, 296, DateTimeKind.Local).AddTicks(7959), "Computer Montior 28'", 129.99000000000001 },
                    { 4, new DateTime(2021, 2, 17, 8, 10, 59, 296, DateTimeKind.Local).AddTicks(7964), "Computer Keyboard", 59.990000000000002 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}

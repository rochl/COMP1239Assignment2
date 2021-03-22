using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment1.Migrations
{
    public partial class Customer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    customerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerFirstName = table.Column<string>(nullable: false),
                    customerLastName = table.Column<string>(nullable: false),
                    customerAddress = table.Column<string>(nullable: false),
                    customerCity = table.Column<string>(nullable: false),
                    customerState = table.Column<string>(nullable: false),
                    customerPostalCode = table.Column<string>(nullable: false),
                    customerCountry = table.Column<string>(nullable: false),
                    customerEmail = table.Column<string>(nullable: true),
                    customerPhone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.customerId);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "customerId", "customerAddress", "customerCity", "customerCountry", "customerEmail", "customerFirstName", "customerLastName", "customerPhone", "customerPostalCode", "customerState" },
                values: new object[,]
                {
                    { 1, "763 Bay St", "Toronto", "Canada", "k.anothini@gmail.com", "Kailtyn", "Anothini", "444-444-2224", "M5G2R3", "ON" },
                    { 2, "555 College St", "San francico", "USA", "maya.kavi@gmail.com", "Maya", "Kavi", "111-224-1111", "M6G5G4", "CA" },
                    { 3, "789 Rome St", "Los Angeles", "USA", "k.brown@gmail.com", "Katty", "Brown", "333-2224-1111", "M6G5K4", "BC" },
                    { 4, "666 Bay St", "Toronto", "Canada", "g.raz@gmail.com", "Gindy", "Raz", "444-2242-4777", "M5G2R4", "ON" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}

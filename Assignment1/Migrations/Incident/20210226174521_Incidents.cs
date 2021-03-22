using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment1.Migrations.Incident
{
    public partial class Incidents : Migration
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

            migrationBuilder.CreateTable(
                name: "Technicians",
                columns: table => new
                {
                    techId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    techName = table.Column<string>(nullable: false),
                    techEmail = table.Column<string>(nullable: false),
                    techPhone = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technicians", x => x.techId);
                });

            migrationBuilder.CreateTable(
                name: "Incidents",
                columns: table => new
                {
                    incidentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    incidentCustomer = table.Column<string>(nullable: false),
                    incidentProduct = table.Column<string>(nullable: false),
                    incidentTitle = table.Column<string>(nullable: false),
                    incidentDes = table.Column<string>(nullable: false),
                    incidentTech = table.Column<int>(nullable: true),
                    DateOpened = table.Column<DateTime>(nullable: false),
                    DateClosed = table.Column<DateTime>(nullable: false),
                    customerId = table.Column<int>(nullable: true),
                    productId = table.Column<int>(nullable: true),
                    TechniciantechId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidents", x => x.incidentId);
                    table.ForeignKey(
                        name: "FK_Incidents_Technicians_TechniciantechId",
                        column: x => x.TechniciantechId,
                        principalTable: "Technicians",
                        principalColumn: "techId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incidents_Customers_customerId",
                        column: x => x.customerId,
                        principalTable: "Customers",
                        principalColumn: "customerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incidents_Products_productId",
                        column: x => x.productId,
                        principalTable: "Products",
                        principalColumn: "productId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Incidents",
                columns: new[] { "incidentId", "DateClosed", "DateOpened", "TechniciantechId", "customerId", "incidentCustomer", "incidentDes", "incidentProduct", "incidentTech", "incidentTitle", "productId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 2, 26, 12, 45, 20, 958, DateTimeKind.Local).AddTicks(2221), new DateTime(2021, 2, 26, 12, 45, 20, 954, DateTimeKind.Local).AddTicks(6172), null, null, "", "Des for id 1", "", 1, "Could not install 1", null },
                    { 2, new DateTime(2021, 2, 26, 12, 45, 20, 958, DateTimeKind.Local).AddTicks(2928), new DateTime(2021, 2, 26, 12, 45, 20, 958, DateTimeKind.Local).AddTicks(2903), null, null, "", "Des for id 2", "", 3, "Error", null },
                    { 3, new DateTime(2021, 2, 26, 12, 45, 20, 958, DateTimeKind.Local).AddTicks(2964), new DateTime(2021, 2, 26, 12, 45, 20, 958, DateTimeKind.Local).AddTicks(2955), null, null, "", "Des for id 3", "", 2, "Could not install 3", null },
                    { 4, new DateTime(2021, 2, 26, 12, 45, 20, 958, DateTimeKind.Local).AddTicks(2975), new DateTime(2021, 2, 26, 12, 45, 20, 958, DateTimeKind.Local).AddTicks(2970), null, null, "", "Des for id 4", "", 1, "Could not install 4", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_TechniciantechId",
                table: "Incidents",
                column: "TechniciantechId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_customerId",
                table: "Incidents",
                column: "customerId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_productId",
                table: "Incidents",
                column: "productId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Incidents");

            migrationBuilder.DropTable(
                name: "Technicians");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}

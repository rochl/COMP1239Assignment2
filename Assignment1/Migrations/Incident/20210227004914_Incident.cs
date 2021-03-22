using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment1.Migrations.Incident
{
    public partial class Incident : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    DateClosed = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidents", x => x.incidentId);
                });

            migrationBuilder.InsertData(
                table: "Incidents",
                columns: new[] { "incidentId", "DateClosed", "DateOpened", "incidentCustomer", "incidentDes", "incidentProduct", "incidentTech", "incidentTitle" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 2, 26, 19, 49, 14, 266, DateTimeKind.Local).AddTicks(9295), new DateTime(2021, 2, 26, 19, 49, 14, 264, DateTimeKind.Local).AddTicks(4130), "Gindy Raz", "Des for id 1", "Computer Mouse", 1, "Could not install 1" },
                    { 2, new DateTime(2021, 2, 26, 19, 49, 14, 267, DateTimeKind.Local).AddTicks(658), new DateTime(2021, 2, 26, 19, 49, 14, 267, DateTimeKind.Local).AddTicks(637), "Kailtyn Anothini", "Des for id 2", "Computer Mouse", 3, "Error" },
                    { 3, new DateTime(2021, 2, 26, 19, 49, 14, 267, DateTimeKind.Local).AddTicks(764), new DateTime(2021, 2, 26, 19, 49, 14, 267, DateTimeKind.Local).AddTicks(761), "Katty Brown", "Des for id 3", "Computer Headset edit 3", 2, "Could not install 3" },
                    { 4, new DateTime(2021, 2, 26, 19, 49, 14, 267, DateTimeKind.Local).AddTicks(770), new DateTime(2021, 2, 26, 19, 49, 14, 267, DateTimeKind.Local).AddTicks(768), "Maya Kavi", "Des for id 4", "Computer Keyboardd not install 4", 1, "Error 2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Incidents");
        }
    }
}

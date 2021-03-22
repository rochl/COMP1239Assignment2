using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment1.Migrations.Technician
{
    public partial class Technician : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Technicians",
                columns: new[] { "techId", "techEmail", "techName", "techPhone" },
                values: new object[] { 1, "mike@gmail.com", "Mike", "555-777-5533" });

            migrationBuilder.InsertData(
                table: "Technicians",
                columns: new[] { "techId", "techEmail", "techName", "techPhone" },
                values: new object[] { 2, "mike@gmail.com", "Mike2", "555-777-5533" });

            migrationBuilder.InsertData(
                table: "Technicians",
                columns: new[] { "techId", "techEmail", "techName", "techPhone" },
                values: new object[] { 3, "mike@gmail.com", "Mike3", "555-777-5533" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Technicians");
        }
    }
}

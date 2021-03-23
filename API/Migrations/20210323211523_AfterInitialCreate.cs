using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class AfterInitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Mapa",
                schema: "Application",
                table: "Mapa");

            migrationBuilder.RenameTable(
                name: "Mapa",
                schema: "Application",
                newName: "Lokacije");

            migrationBuilder.AddColumn<string>(
                name: "LokacijaUString",
                table: "Lokacije",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipLokacije",
                table: "Lokacije",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lokacije",
                table: "Lokacije",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Lokacije",
                table: "Lokacije");

            migrationBuilder.DropColumn(
                name: "LokacijaUString",
                table: "Lokacije");

            migrationBuilder.DropColumn(
                name: "TipLokacije",
                table: "Lokacije");

            migrationBuilder.EnsureSchema(
                name: "Application");

            migrationBuilder.RenameTable(
                name: "Lokacije",
                newName: "Mapa",
                newSchema: "Application");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mapa",
                schema: "Application",
                table: "Mapa",
                column: "Id");
        }
    }
}

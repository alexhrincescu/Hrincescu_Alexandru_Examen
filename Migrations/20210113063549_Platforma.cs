using Microsoft.EntityFrameworkCore.Migrations;

namespace Hrincescu_Alexandru_Examen.Migrations
{
    public partial class Platforma : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Platforma",
                table: "JocuriVideo",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Platforma",
                table: "JocuriVideo");
        }
    }
}

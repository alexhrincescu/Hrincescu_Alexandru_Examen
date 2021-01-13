using Microsoft.EntityFrameworkCore.Migrations;

namespace Hrincescu_Alexandru_Examen.Migrations
{
    public partial class Notă : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Preţ",
                table: "JocuriVideo",
                type: "decimal(6,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<string>(
                name: "Notă",
                table: "JocuriVideo",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notă",
                table: "JocuriVideo");

            migrationBuilder.AlterColumn<decimal>(
                name: "Preţ",
                table: "JocuriVideo",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,2)");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hrincescu_Alexandru_Examen.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JocuriVideo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titlu = table.Column<string>(nullable: true),
                    DataLansarii = table.Column<DateTime>(nullable: false),
                    Gen = table.Column<string>(nullable: true),
                    Preţ = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JocuriVideo", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JocuriVideo");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace ProAgil.WebAPI.Migrations
{
    public partial class Evento_ImagemUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imagemUrl",
                table: "Eventos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imagemUrl",
                table: "Eventos");
        }
    }
}

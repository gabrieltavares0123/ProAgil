using Microsoft.EntityFrameworkCore.Migrations;

namespace ProAgil.WebAPI.Migrations
{
    public partial class Evento_ImagemUrl_Correcao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "imagemUrl",
                table: "Eventos",
                newName: "ImagemUrl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImagemUrl",
                table: "Eventos",
                newName: "imagemUrl");
        }
    }
}

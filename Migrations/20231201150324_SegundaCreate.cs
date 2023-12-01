using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gabriela_duarte.Migrations
{
    public partial class SegundaCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Discriminator",
                table: "TipoDePagamento",
                newName: "TipoDePagamento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipoDePagamento",
                table: "TipoDePagamento",
                newName: "Discriminator");
        }
    }
}

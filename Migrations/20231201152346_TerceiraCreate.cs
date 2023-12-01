using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gabriela_duarte.Migrations
{
    public partial class TerceiraCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipodePagamentoId",
                table: "TipoDePagamento",
                newName: "TipoDePagamentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipoDePagamentoId",
                table: "TipoDePagamento",
                newName: "TipodePagamentoId");
        }
    }
}

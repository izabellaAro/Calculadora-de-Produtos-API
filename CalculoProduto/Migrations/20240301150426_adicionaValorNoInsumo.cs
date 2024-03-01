using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalculoProduto.Migrations
{
    /// <inheritdoc />
    public partial class adicionaValorNoInsumo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Valor",
                table: "InsumoIndireto",
                type: "double",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Valor",
                table: "InsumoIndireto");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalculoProduto.Migrations
{
    /// <inheritdoc />
    public partial class ajustaEscritaEspecificacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Especificao",
                table: "InsumoIndireto",
                newName: "Especificacao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Especificacao",
                table: "InsumoIndireto",
                newName: "Especificao");
        }
    }
}

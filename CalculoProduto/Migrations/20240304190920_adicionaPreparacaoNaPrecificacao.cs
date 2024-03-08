using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalculoProduto.Migrations
{
    /// <inheritdoc />
    public partial class adicionaPreparacaoNaPrecificacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Preparacao_Precificacao_PrecificacaoId",
                table: "Preparacao");

            migrationBuilder.DropIndex(
                name: "IX_Preparacao_PrecificacaoId",
                table: "Preparacao");

            migrationBuilder.DropColumn(
                name: "PrecificacaoId",
                table: "Preparacao");

            migrationBuilder.AddColumn<int>(
                name: "PreparacaoId",
                table: "Precificacao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Precificacao_PreparacaoId",
                table: "Precificacao",
                column: "PreparacaoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Precificacao_Preparacao_PreparacaoId",
                table: "Precificacao",
                column: "PreparacaoId",
                principalTable: "Preparacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Precificacao_Preparacao_PreparacaoId",
                table: "Precificacao");

            migrationBuilder.DropIndex(
                name: "IX_Precificacao_PreparacaoId",
                table: "Precificacao");

            migrationBuilder.DropColumn(
                name: "PreparacaoId",
                table: "Precificacao");

            migrationBuilder.AddColumn<int>(
                name: "PrecificacaoId",
                table: "Preparacao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Preparacao_PrecificacaoId",
                table: "Preparacao",
                column: "PrecificacaoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Preparacao_Precificacao_PrecificacaoId",
                table: "Preparacao",
                column: "PrecificacaoId",
                principalTable: "Precificacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Multiplos_Itens.Migrations
{
    public partial class RemovendoFkMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Fornecedor_FornecedoresId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_FornecedoresId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "FornecedoresId",
                table: "Produtos");

            migrationBuilder.AddColumn<int>(
                name: "FornecedorId",
                table: "Produtos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_FornecedorId",
                table: "Produtos",
                column: "FornecedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Fornecedor_FornecedorId",
                table: "Produtos",
                column: "FornecedorId",
                principalTable: "Fornecedor",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Fornecedor_FornecedorId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_FornecedorId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "FornecedorId",
                table: "Produtos");

            migrationBuilder.AddColumn<int>(
                name: "FornecedoresId",
                table: "Produtos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_FornecedoresId",
                table: "Produtos",
                column: "FornecedoresId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Fornecedor_FornecedoresId",
                table: "Produtos",
                column: "FornecedoresId",
                principalTable: "Fornecedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

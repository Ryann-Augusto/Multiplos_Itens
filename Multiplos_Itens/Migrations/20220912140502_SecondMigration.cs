using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Multiplos_Itens.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FornecedoresId",
                table: "Produtos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Fornecedor_FornecedoresId",
                table: "Produtos");

            migrationBuilder.DropTable(
                name: "Fornecedor");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_FornecedoresId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "FornecedoresId",
                table: "Produtos");
        }
    }
}

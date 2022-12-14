using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Devs2Blu.ProjetosAula.MVCSQLServerApp2.Web.Migrations
{
    /// <inheritdoc />
    public partial class MigTabelasSistema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categorias",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categorias", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "produtos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    preco = table.Column<double>(type: "float", nullable: false),
                    quantidade = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produtos", x => x.id);
                    table.ForeignKey(
                        name: "FK_produtos_categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "categorias",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "categorias",
                columns: new[] { "id", "nome" },
                values: new object[,]
                {
                    { 1, "Alimentos não perecíveis" },
                    { 2, "Laicínios" },
                    { 3, "Limpeza" },
                    { 4, "Bebidas não alcoólicas" }
                });

            migrationBuilder.InsertData(
                table: "produtos",
                columns: new[] { "id", "CategoriaId", "nome", "preco", "quantidade" },
                values: new object[,]
                {
                    { 1, 1, "Arroz", 10.0, 5 },
                    { 2, 1, "Feijão", 15.0, 15 },
                    { 3, 2, "Queijo", 20.0, 20 },
                    { 4, 2, "Iogurte", 10.0, 5 },
                    { 5, 4, "Suco de Laranja 1L", 5.0, 5 },
                    { 6, 4, "Coca-Cola 2L", 8.0, 30 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_produtos_CategoriaId",
                table: "produtos",
                column: "CategoriaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "produtos");

            migrationBuilder.DropTable(
                name: "categorias");
        }
    }
}

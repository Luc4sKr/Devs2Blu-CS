using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Devs2Blu.Cadastrojogos.Migrations
{
    /// <inheritdoc />
    public partial class InitMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "empresas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empresas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "jogos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    preco = table.Column<double>(type: "float", nullable: false),
                    EmpresaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jogos", x => x.id);
                    table.ForeignKey(
                        name: "FK_jogos_empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "empresas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "empresas",
                columns: new[] { "id", "nome" },
                values: new object[,]
                {
                    { 1, "Activision" },
                    { 2, " Rockstar Games" }
                });

            migrationBuilder.InsertData(
                table: "jogos",
                columns: new[] { "id", "EmpresaId", "nome", "preco" },
                values: new object[,]
                {
                    { 1, 1, "Call of Duty", 80.0 },
                    { 2, 2, "Grand Theft Auto V", 100.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_jogos_EmpresaId",
                table: "jogos",
                column: "EmpresaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "jogos");

            migrationBuilder.DropTable(
                name: "empresas");
        }
    }
}

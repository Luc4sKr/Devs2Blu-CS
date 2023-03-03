using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoNotas.Infra.Data.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateNoteMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "Category", "Description", "Fixed", "TimeNote", "Title", "UserId" },
                values: new object[] { 1, 0, "Quisque velit nisi", true, new DateTime(2023, 3, 2, 21, 22, 8, 381, DateTimeKind.Local).AddTicks(543), "Lorem", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}

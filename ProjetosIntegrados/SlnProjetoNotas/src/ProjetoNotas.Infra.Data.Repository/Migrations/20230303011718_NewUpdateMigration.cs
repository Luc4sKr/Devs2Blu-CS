using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoNotas.Infra.Data.Repository.Migrations
{
    /// <inheritdoc />
    public partial class NewUpdateMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeNote",
                value: new DateTime(2023, 3, 2, 22, 17, 17, 986, DateTimeKind.Local).AddTicks(8337));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeNote",
                value: new DateTime(2023, 3, 2, 21, 22, 8, 381, DateTimeKind.Local).AddTicks(543));
        }
    }
}

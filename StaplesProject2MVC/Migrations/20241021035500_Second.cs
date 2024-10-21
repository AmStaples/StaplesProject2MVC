using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StaplesProject2MVC.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 818);

            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "Id", "Attack", "Defense", "Hp", "Name", "SpAttack", "SpDefense", "Speed" },
                values: new object[,]
                {
                    { 1, 116, 75, 80, "Cinderace", 65, 75, 119 },
                    { 2, 125, 90, 100, "Rillaboom", 60, 70, 85 },
                    { 3, 85, 65, 70, "Inteleon", 125, 65, 120 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "Id", "Attack", "Defense", "Hp", "Name", "SpAttack", "SpDefense", "Speed" },
                values: new object[,]
                {
                    { 812, 125, 90, 100, "Rillaboom", 60, 70, 85 },
                    { 815, 116, 75, 80, "Cinderace", 65, 75, 119 },
                    { 818, 85, 65, 70, "Inteleon", 125, 65, 120 }
                });
        }
    }
}

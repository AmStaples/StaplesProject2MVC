using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StaplesProject2MVC.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hp = table.Column<int>(type: "int", nullable: false),
                    Attack = table.Column<int>(type: "int", nullable: true),
                    Defense = table.Column<int>(type: "int", nullable: false),
                    SpAttack = table.Column<int>(type: "int", nullable: false),
                    SpDefense = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokemons");
        }
    }
}

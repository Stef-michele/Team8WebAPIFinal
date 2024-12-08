using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Team8WebAPIFinal.Migrations
{
    /// <inheritdoc />
    public partial class AddFavoritesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavoriteBreakfastFoods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsHealthy = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteBreakfastFoods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteShows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReleaseYear = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FavoriteCharacter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Creator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteShows", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FavoriteBreakfastFoods",
                columns: new[] { "Id", "Description", "IsHealthy", "Name", "Type" },
                values: new object[] { 3, "A mix of oats, honey, and nuts, often eaten with yogurt.", true, "Granola", "Sweet" });

            migrationBuilder.InsertData(
                table: "FavoriteShows",
                columns: new[] { "Id", "Creator", "FavoriteCharacter", "Genre", "ReleaseYear", "Title" },
                values: new object[] { 1, "Sydney Newman", "Rory Pond", "Sci-Fi", 1963, "Doctor Who" });

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "Id", "Birthdate", "CollegeProgram", "FullName", "YearInProgram" },
                values: new object[] { 15380296, new DateTime(2004, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technologies", "Cadence Hicks", "Sophomore" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoriteBreakfastFoods");

            migrationBuilder.DropTable(
                name: "FavoriteShows");

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 15380296);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Team8WebAPIFinal.Migrations
{
    /// <inheritdoc />
    public partial class Hobbies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 2694253);

            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstimatedHoursPerWeek = table.Column<int>(type: "int", nullable: false),
                    SkillLevel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FavoriteBreakfastFoods",
                columns: new[] { "Id", "Description", "IsHealthy", "Name", "Type" },
                values: new object[] { 4, "Poached eggs and Canadian Bacon on English Muffins with Hollandaise.", false, "Eggs Benedict", "Savory" });

            migrationBuilder.InsertData(
                table: "FavoriteShows",
                columns: new[] { "Id", "Creator", "FavoriteCharacter", "Genre", "ReleaseYear", "Title" },
                values: new object[] { 4, "The Duffer Brothers", "Eleven", "Sci-Fi", 2016, "Stranger Things" });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "Id", "Description", "EstimatedHoursPerWeek", "Name", "SkillLevel" },
                values: new object[] { 4, "Baking cookies, cakes and other desserts", 5, "Baking", "Intermediate" });

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "Id", "Birthdate", "CollegeProgram", "FullName", "YearInProgram" },
                values: new object[] { 4, new DateTime(1988, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Development Certificate", "Stefanie Gay", "Senior" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DeleteData(
                table: "FavoriteBreakfastFoods",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FavoriteShows",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "Id", "Birthdate", "CollegeProgram", "FullName", "YearInProgram" },
                values: new object[] { 2694253, new DateTime(1988, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Development Certificate", "Stefanie Gay", "Senior" });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Team8WebAPIFinal.Migrations
{
    /// <inheritdoc />
    public partial class SeedingInformation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FavoriteShows",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 15380296);

            migrationBuilder.InsertData(
                table: "FavoriteBreakfastFoods",
                columns: new[] { "Id", "Description", "IsHealthy", "Name", "Type" },
                values: new object[] { 2, "Fried pastry dough with cream and fruit inside", false, "Crepe", "Sweet" });

            migrationBuilder.InsertData(
                table: "FavoriteShows",
                columns: new[] { "Id", "Creator", "FavoriteCharacter", "Genre", "ReleaseYear", "Title" },
                values: new object[,]
                {
                    { 2, "Sydney Newman", "Rory Pond", "Sci-Fi", 1963, "Doctor Who" },
                    { 3, "Jenni Konner & Lucia Aniello", "Beth Boland", "Comedy-Drama", 2018, "Good Girls" }
                });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "Id", "Description", "EstimatedHoursPerWeek", "Name", "SkillLevel" },
                values: new object[,]
                {
                    { 2, "Drawing art of new and existing characters on my mobile device", 10, "Digital Art", "Intermediate" },
                    { 3, "Expressing oneself through rhthmic movement, often to music.", 8, "Dancing", "Intermediate" }
                });

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "Id", "Birthdate", "CollegeProgram", "FullName", "YearInProgram" },
                values: new object[,]
                {
                    { 2, new DateTime(2004, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technologies", "Cadence Hicks", "Sophomore" },
                    { 3, new DateTime(2004, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technologies", "Rehmat", "Sophomore" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FavoriteBreakfastFoods",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FavoriteShows",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FavoriteShows",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "FavoriteShows",
                columns: new[] { "Id", "Creator", "FavoriteCharacter", "Genre", "ReleaseYear", "Title" },
                values: new object[] { 1, "Sydney Newman", "Rory Pond", "Sci-Fi", 1963, "Doctor Who" });

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "Id", "Birthdate", "CollegeProgram", "FullName", "YearInProgram" },
                values: new object[] { 15380296, new DateTime(2004, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technologies", "Cadence Hicks", "Sophomore" });
        }
    }
}

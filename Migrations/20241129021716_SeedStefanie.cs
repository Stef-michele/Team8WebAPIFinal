using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Team8WebAPIFinal.Migrations
{
    /// <inheritdoc />
    public partial class SeedStefanie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "Id", "Birthdate", "CollegeProgram", "FullName", "YearInProgram" },
                values: new object[] { 2694253, new DateTime(1988, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Development Certificate", "Stefanie Gay", "Senior" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 2694253);
        }
    }
}

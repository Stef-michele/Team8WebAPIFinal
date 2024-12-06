﻿using Microsoft.EntityFrameworkCore;
using Team8WebAPIFinal.Models;

namespace Team8WebAPIFinal.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<FavoriteShow> FavoriteShows { get; set; }
        public DbSet<FavoriteBreakfastFood> FavoriteBreakfastFoods { get; set; }

        // Seed data inside OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seeding team members
            modelBuilder.Entity<TeamMember>().HasData(
                new TeamMember
                {
                    Id = 2694253,
                    FullName = "Stefanie Gay",
                    Birthdate = new DateTime(1988, 08, 05),
                    CollegeProgram = "Software Development Certificate",
                    YearInProgram = "Senior"
                },
                new TeamMember
                {
                    Id = 15380296,
                    FullName = "Cadence Hicks",
                    Birthdate = new DateTime(2004, 08, 19),
                    CollegeProgram = "Information Technologies",
                    YearInProgram = "Sophomore"
                }
            );

            // Seeding favorite shows
            modelBuilder.Entity<FavoriteShow>().HasData(
                new FavoriteShow
                {
                    Id = 1,
                    ReleaseYear = 1963,
                    Title = "Doctor Who",
                    Genre = "Sci-Fi",
                    FavoriteCharacter = "Rory Pond",
                    Creator = "Sydney Newman"
                }
            );

            // Seeding favorite breakfast foods
            modelBuilder.Entity<FavoriteBreakfastFood>().HasData(
                new FavoriteBreakfastFood
                {
                    Id = 3,
                    Name = "Granola",
                    Type = "Sweet",
                    IsHealthy = true,
                    Description = "A mix of oats, honey, and nuts, often eaten with yogurt."
                }
            );
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Team8WebAPIFinal.Models;

namespace Team8WebAPIFinal.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<FavoriteShow> FavoriteShows { get; set; }
        public DbSet<FavoriteBreakfastFood> FavoriteBreakfastFoods { get; set; }
        public DbSet<Hobbies> Hobbies { get; set; }

        // Seed data inside OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seeding team members
            modelBuilder.Entity<TeamMember>().HasData(
                new TeamMember
                {
                    Id = 4,
                    FullName = "Stefanie Gay",
                    Birthdate = new DateTime(1988, 08, 05),
                    CollegeProgram = "Software Development Certificate",
                    YearInProgram = "Senior"
                },
                new TeamMember
                {
                    Id = 2,
                    FullName = "Cadence Hicks",
                    Birthdate = new DateTime(2004, 08, 19),
                    CollegeProgram = "Information Technologies",
                    YearInProgram = "Sophomore"
                }
                // last data near here. will nee a comma above after adding
            );

            // Seeding favorite shows
            modelBuilder.Entity<FavoriteShow>().HasData(
                new FavoriteShow
                {
                    Id = 2,
                    ReleaseYear = 1963,
                    Title = "Doctor Who",
                    Genre = "Sci-Fi",
                    FavoriteCharacter = "Rory Pond",
                    Creator = "Sydney Newman"
                },
                //Stefanie's entry to this table
                 new FavoriteShow
                 {
                     Id = 4,
                     ReleaseYear = 2016,
                     Title = "Stranger Things",
                     Genre = "Sci-Fi",
                     FavoriteCharacter = "Eleven",
                     Creator = "The Duffer Brothers"
                 }
                 //last data here need comma above after bracket
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
                },

                new FavoriteBreakfastFood
                {
                    Id = 4,
                    Name = "Eggs Benedict",
                    Type = "Savory",
                    IsHealthy = false,
                    Description = "Poached eggs and Canadian Bacon on English Muffins with Hollandaise."
                },

                new FavoriteBreakfastFood
                {
                    Id = 2,
                    Name = "Crepe",
                    Type = "Sweet",
                    IsHealthy = false,
                    Description = "Fried pastry dough with cream and fruit inside"
            );
            //last table Seed
            modelBuilder.Entity<Hobbies>().HasData(
                new Hobbies 
                {
                    Id = 4,
                    Name = "Baking",
                    Description = "Baking cookies, cakes and other desserts",
                    EstimatedHoursPerWeek = 5, 
                    SkillLevel = "Intermediate"
                },

                new Hobbies
                {
                    Id = 2;
                    Name = "Digital Art",
                    Description = "Drawing art of new and existing characters on my mobile device",
                    EstimatedHoursPerWeek = 10,
                    Skilllevel = "Intermediate"
                };


                );
        }
        
    }
}

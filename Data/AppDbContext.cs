using Microsoft.EntityFrameworkCore;
using Team8WebAPIFinal.Models;

namespace Team8WebAPIFinal.Data
{
    public class AppDbContext : DbContext
    {

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<TeamMember> TeamMembers { get; set; }
    
    // Seed data inside OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seeding one team member
            modelBuilder.Entity<TeamMember>().HasData(
                new TeamMember
                {

                    Id = 2694253,
                    FullName = "Stefanie Gay",
                    Birthdate = new DateTime(1988, 08, 05),
                    CollegeProgram = "Software Development Certificate",
                    YearInProgram = "Senior"
                }
               

            );
        }

        
    }
    

}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Team8WebAPIFinal.Data;

#nullable disable

namespace Team8WebAPIFinal.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Team8WebAPIFinal.Models.FavoriteBreakfastFood", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsHealthy")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FavoriteBreakfastFoods");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            Description = "A mix of oats, honey, and nuts, often eaten with yogurt.",
                            IsHealthy = true,
                            Name = "Granola",
                            Type = "Sweet"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Poached eggs and Canadian Bacon on English Muffins with Hollandaise.",
                            IsHealthy = false,
                            Name = "Eggs Benedict",
                            Type = "Savory"
                        });
                });

            modelBuilder.Entity("Team8WebAPIFinal.Models.FavoriteShow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Creator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FavoriteCharacter")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReleaseYear")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FavoriteShows");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Creator = "Sydney Newman",
                            FavoriteCharacter = "Rory Pond",
                            Genre = "Sci-Fi",
                            ReleaseYear = 1963,
                            Title = "Doctor Who"
                        },
                        new
                        {
                            Id = 4,
                            Creator = "The Duffer Brothers",
                            FavoriteCharacter = "Eleven",
                            Genre = "Sci-Fi",
                            ReleaseYear = 2016,
                            Title = "Stranger Things"
                        });
                });

            modelBuilder.Entity("Team8WebAPIFinal.Models.Hobbies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstimatedHoursPerWeek")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkillLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hobbies");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            Description = "Baking cookies, cakes and other desserts",
                            EstimatedHoursPerWeek = 5,
                            Name = "Baking",
                            SkillLevel = "Intermediate"
                        });
                });

            modelBuilder.Entity("Team8WebAPIFinal.Models.TeamMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CollegeProgram")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YearInProgram")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TeamMembers");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            Birthdate = new DateTime(1988, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CollegeProgram = "Software Development Certificate",
                            FullName = "Stefanie Gay",
                            YearInProgram = "Senior"
                        },
                        new
                        {
                            Id = 15380296,
                            Birthdate = new DateTime(2004, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CollegeProgram = "Information Technologies",
                            FullName = "Cadence Hicks",
                            YearInProgram = "Sophomore"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("Domain.Entities.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Joined")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("TEXT");

                    b.Property<string>("Team")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TeamId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PlayerId");

                    b.HasIndex("TeamId");

                    b.ToTable("Player");

                    b.HasData(
                        new
                        {
                            PlayerId = 1,
                            Joined = new DateTime(2022, 1, 8, 20, 40, 23, 905, DateTimeKind.Local).AddTicks(7690),
                            Name = "Trae Young",
                            PhotoPath = "/Photos/nba_anonymous.jpg",
                            Team = "Hawks"
                        },
                        new
                        {
                            PlayerId = 2,
                            Joined = new DateTime(2022, 1, 8, 20, 40, 23, 906, DateTimeKind.Local).AddTicks(200),
                            Name = "Jayson Tatum",
                            PhotoPath = "/Photos/nba_anonymous.jpg",
                            Team = "Celtics"
                        },
                        new
                        {
                            PlayerId = 3,
                            Joined = new DateTime(2022, 1, 8, 20, 40, 23, 906, DateTimeKind.Local).AddTicks(820),
                            Name = "Kevin Durant",
                            PhotoPath = "/Photos/nba_anonymous.jpg",
                            Team = "Nets"
                        },
                        new
                        {
                            PlayerId = 4,
                            Joined = new DateTime(2022, 1, 8, 20, 40, 23, 906, DateTimeKind.Local).AddTicks(890),
                            Name = "Stephen Curry",
                            PhotoPath = "/Photos/nba_anonymous.jpg",
                            Team = "Warriors"
                        },
                        new
                        {
                            PlayerId = 5,
                            Joined = new DateTime(2022, 1, 8, 20, 40, 23, 906, DateTimeKind.Local).AddTicks(910),
                            Name = "Zach LaVine",
                            PhotoPath = "/Photos/nba_anonymous.jpg",
                            Team = "Bulls"
                        },
                        new
                        {
                            PlayerId = 6,
                            Joined = new DateTime(2022, 1, 8, 20, 40, 23, 906, DateTimeKind.Local).AddTicks(920),
                            Name = "LeBron James",
                            PhotoPath = "/Photos/nba_anonymous.jpg",
                            Team = "Lakers"
                        },
                        new
                        {
                            PlayerId = 7,
                            Joined = new DateTime(2022, 1, 8, 20, 40, 23, 906, DateTimeKind.Local).AddTicks(930),
                            Name = "Julius Randle",
                            PhotoPath = "/Photos/nba_anonymous.jpg",
                            Team = "Knicks"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateFounded")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("TEXT");

                    b.HasKey("TeamId");

                    b.ToTable("Team");

                    b.HasData(
                        new
                        {
                            TeamId = 1,
                            City = "Atlanta",
                            DateFounded = new DateTime(2022, 1, 8, 20, 40, 23, 877, DateTimeKind.Local).AddTicks(1270),
                            Name = "Hawks",
                            PhotoPath = "/Photos/nba_anonymous.jpg"
                        },
                        new
                        {
                            TeamId = 2,
                            City = "Boston",
                            DateFounded = new DateTime(2022, 1, 8, 20, 40, 23, 903, DateTimeKind.Local).AddTicks(6370),
                            Name = "Celtics",
                            PhotoPath = "/Photos/nba_anonymous.jpg"
                        },
                        new
                        {
                            TeamId = 3,
                            City = "Brooklyn",
                            DateFounded = new DateTime(2022, 1, 8, 20, 40, 23, 903, DateTimeKind.Local).AddTicks(7360),
                            Name = "Nets",
                            PhotoPath = "/Photos/nba_anonymous.jpg"
                        },
                        new
                        {
                            TeamId = 4,
                            City = "Golden State",
                            DateFounded = new DateTime(2022, 1, 8, 20, 40, 23, 903, DateTimeKind.Local).AddTicks(7430),
                            Name = "Warriors",
                            PhotoPath = "/Photos/nba_anonymous.jpg"
                        },
                        new
                        {
                            TeamId = 5,
                            City = "Chicago",
                            DateFounded = new DateTime(2022, 1, 8, 20, 40, 23, 903, DateTimeKind.Local).AddTicks(7440),
                            Name = "Bulls",
                            PhotoPath = "/Photos/nba_anonymous.jpg"
                        },
                        new
                        {
                            TeamId = 6,
                            City = "Los Angeles",
                            DateFounded = new DateTime(2022, 1, 8, 20, 40, 23, 903, DateTimeKind.Local).AddTicks(7450),
                            Name = "Lakers",
                            PhotoPath = "/Photos/nba_anonymous.jpg"
                        },
                        new
                        {
                            TeamId = 7,
                            City = "New York",
                            DateFounded = new DateTime(2022, 1, 8, 20, 40, 23, 903, DateTimeKind.Local).AddTicks(7470),
                            Name = "Knicks",
                            PhotoPath = "/Photos/nba_anonymous.jpg"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Player", b =>
                {
                    b.HasOne("Domain.Entities.Team", null)
                        .WithMany("Players")
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("Domain.Entities.Team", b =>
                {
                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220314010413_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            Joined = new DateTime(2022, 3, 13, 18, 4, 12, 915, DateTimeKind.Local).AddTicks(3700),
                            Name = "Trae Young",
                            PhotoPath = "/Photos/nba_anonymous.jpg",
                            Team = "Hawks"
                        },
                        new
                        {
                            PlayerId = 2,
                            Joined = new DateTime(2022, 3, 13, 18, 4, 12, 915, DateTimeKind.Local).AddTicks(6100),
                            Name = "Jayson Tatum",
                            PhotoPath = "/Photos/nba_anonymous.jpg",
                            Team = "Celtics"
                        },
                        new
                        {
                            PlayerId = 3,
                            Joined = new DateTime(2022, 3, 13, 18, 4, 12, 915, DateTimeKind.Local).AddTicks(6710),
                            Name = "Kevin Durant",
                            PhotoPath = "/Photos/nba_anonymous.jpg",
                            Team = "Nets"
                        },
                        new
                        {
                            PlayerId = 4,
                            Joined = new DateTime(2022, 3, 13, 18, 4, 12, 915, DateTimeKind.Local).AddTicks(6780),
                            Name = "Stephen Curry",
                            PhotoPath = "/Photos/nba_anonymous.jpg",
                            Team = "Warriors"
                        },
                        new
                        {
                            PlayerId = 5,
                            Joined = new DateTime(2022, 3, 13, 18, 4, 12, 915, DateTimeKind.Local).AddTicks(6800),
                            Name = "Zach LaVine",
                            PhotoPath = "/Photos/nba_anonymous.jpg",
                            Team = "Bulls"
                        },
                        new
                        {
                            PlayerId = 6,
                            Joined = new DateTime(2022, 3, 13, 18, 4, 12, 915, DateTimeKind.Local).AddTicks(6810),
                            Name = "LeBron James",
                            PhotoPath = "/Photos/nba_anonymous.jpg",
                            Team = "Lakers"
                        },
                        new
                        {
                            PlayerId = 7,
                            Joined = new DateTime(2022, 3, 13, 18, 4, 12, 915, DateTimeKind.Local).AddTicks(6820),
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

                    b.Property<string>("Arena")
                        .HasColumnType("TEXT");

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
                            DateFounded = new DateTime(2022, 3, 13, 18, 4, 12, 888, DateTimeKind.Local).AddTicks(160),
                            Name = "Hawks",
                            PhotoPath = "/Photos/nba_anonymous.jpg"
                        },
                        new
                        {
                            TeamId = 2,
                            City = "Boston",
                            DateFounded = new DateTime(2022, 3, 13, 18, 4, 12, 913, DateTimeKind.Local).AddTicks(1750),
                            Name = "Celtics",
                            PhotoPath = "/Photos/nba_anonymous.jpg"
                        },
                        new
                        {
                            TeamId = 3,
                            City = "Brooklyn",
                            DateFounded = new DateTime(2022, 3, 13, 18, 4, 12, 913, DateTimeKind.Local).AddTicks(2880),
                            Name = "Nets",
                            PhotoPath = "/Photos/nba_anonymous.jpg"
                        },
                        new
                        {
                            TeamId = 4,
                            City = "Golden State",
                            DateFounded = new DateTime(2022, 3, 13, 18, 4, 12, 913, DateTimeKind.Local).AddTicks(2950),
                            Name = "Warriors",
                            PhotoPath = "/Photos/nba_anonymous.jpg"
                        },
                        new
                        {
                            TeamId = 5,
                            City = "Chicago",
                            DateFounded = new DateTime(2022, 3, 13, 18, 4, 12, 913, DateTimeKind.Local).AddTicks(2970),
                            Name = "Bulls",
                            PhotoPath = "/Photos/nba_anonymous.jpg"
                        },
                        new
                        {
                            TeamId = 6,
                            City = "Los Angeles",
                            DateFounded = new DateTime(2022, 3, 13, 18, 4, 12, 913, DateTimeKind.Local).AddTicks(2980),
                            Name = "Lakers",
                            PhotoPath = "/Photos/nba_anonymous.jpg"
                        },
                        new
                        {
                            TeamId = 7,
                            City = "New York",
                            DateFounded = new DateTime(2022, 3, 13, 18, 4, 12, 913, DateTimeKind.Local).AddTicks(3000),
                            Name = "Knicks",
                            PhotoPath = "/Photos/nba_anonymous.jpg"
                        });
                });

            modelBuilder.Entity("Domain.Entities.TeamHistory", b =>
                {
                    b.Property<int>("TeamHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("DEFGPct")
                        .HasColumnType("REAL");

                    b.Property<double>("DRB")
                        .HasColumnType("REAL");

                    b.Property<double>("DRTg")
                        .HasColumnType("REAL");

                    b.Property<double>("FTr")
                        .HasColumnType("REAL");

                    b.Property<int>("LossRecord")
                        .HasColumnType("INTEGER");

                    b.Property<double>("MOV")
                        .HasColumnType("REAL");

                    b.Property<double>("NRTg")
                        .HasColumnType("REAL");

                    b.Property<double>("OEFGPct")
                        .HasColumnType("REAL");

                    b.Property<double>("ORB")
                        .HasColumnType("REAL");

                    b.Property<double>("ORTg")
                        .HasColumnType("REAL");

                    b.Property<double>("SOS")
                        .HasColumnType("REAL");

                    b.Property<string>("Season")
                        .HasColumnType("TEXT");

                    b.Property<string>("Team")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TeamId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("ThreePAr")
                        .HasColumnType("REAL");

                    b.Property<int>("WinRecord")
                        .HasColumnType("INTEGER");

                    b.HasKey("TeamHistoryId");

                    b.HasIndex("TeamId");

                    b.ToTable("TeamHistory");

                    b.HasData(
                        new
                        {
                            TeamHistoryId = 1,
                            DEFGPct = 0.51500000000000001,
                            DRB = 78.799999999999997,
                            DRTg = 106.3,
                            FTr = 0.27600000000000002,
                            LossRecord = 19,
                            MOV = 5.79,
                            NRTg = 0.0,
                            OEFGPct = 0.54200000000000004,
                            ORB = 24.5,
                            ORTg = 112.0,
                            SOS = 0.48999999999999999,
                            Season = "2019-2020",
                            Team = "Lakers",
                            ThreePAr = 0.35799999999999998,
                            WinRecord = 52
                        },
                        new
                        {
                            TeamHistoryId = 2,
                            DEFGPct = 0.52300000000000002,
                            DRB = 79.5,
                            DRTg = 109.5,
                            FTr = 0.29899999999999999,
                            LossRecord = 29,
                            MOV = 2.9500000000000002,
                            NRTg = 0.0,
                            OEFGPct = 0.54700000000000004,
                            ORB = 20.300000000000001,
                            ORTg = 112.5,
                            SOS = 0.34999999999999998,
                            Season = "2019-2020",
                            Team = "Heat",
                            ThreePAr = 0.41899999999999998,
                            WinRecord = 44
                        });
                });

            modelBuilder.Entity("Domain.Entities.Player", b =>
                {
                    b.HasOne("Domain.Entities.Team", null)
                        .WithMany("Players")
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("Domain.Entities.TeamHistory", b =>
                {
                    b.HasOne("Domain.Entities.Team", null)
                        .WithMany("TeamHistories")
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("Domain.Entities.Team", b =>
                {
                    b.Navigation("Players");

                    b.Navigation("TeamHistories");
                });
#pragma warning restore 612, 618
        }
    }
}

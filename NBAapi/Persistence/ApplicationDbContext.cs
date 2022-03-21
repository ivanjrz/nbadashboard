using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class ApplicationDbContext : DbContext
    {
        private static bool _created = false;

        public DbSet<Team> Team { get; set; }
        public DbSet<Player> Player { get; set; }
        public DbSet<TeamHistory> TeamHistory { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            if (!_created)
            {
                _created = true;
                Database.EnsureDeleted();
                Database.EnsureCreated();
            }
        }

        #region Model initializers
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Team Initializer
            modelBuilder.Entity<Team>()
                .HasData(
                new Team
                {
                    TeamId = 1,
                    Name = "Hawks",
                    City = "Atlanta",
                    DateFounded = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                },
                new Team
                {
                    TeamId = 2,
                    Name = "Celtics",
                    City = "Boston",
                    DateFounded = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                },
                new Team
                {
                    TeamId = 3,
                    Name = "Nets",
                    City = "Brooklyn",
                    DateFounded = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                },
                new Team
                {
                    TeamId = 4,
                    Name = "Hornets",
                    City = "Charlotte",
                    DateFounded = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                },
                new Team
                {
                    TeamId = 5,
                    Name = "Bulls",
                    City = "Chicago",
                    DateFounded = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                },
                new Team
                {
                    TeamId = 6,
                    Name = "Cavaliers",
                    City = "Cleveland",
                    DateFounded = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                },
                new Team
                {
                    TeamId = 7,
                    Name = "Mavericks",
                    City = "Dallas",
                    DateFounded = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                },

                new Team
                {
                    TeamId = 8,
                    Name = "Nuggets",
                    City = "Denver",
                    DateFounded = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                },
                new Team
                {
                    TeamId = 9,
                    Name = "Pistons",
                    City = "Detroit",
                    DateFounded = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                },
                new Team
                {
                    TeamId = 10,
                    Name = "Warriors",
                    City = "Golden State",
                    DateFounded = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                },
                new Team
                {
                    TeamId = 11,
                    Name = "Rockets",
                    City = "Houston",
                    DateFounded = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                },
                new Team
                {
                    TeamId = 12,
                    Name = "Pacers",
                    City = "Indiana",
                    DateFounded = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                },

                new Team
                {
                    TeamId = 13,
                    Name = "Clippers",
                    City = "Los Angeles",
                    DateFounded = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                },
                new Team
                {
                    TeamId = 14,
                    Name = "Lakers",
                    City = "Los Angeles",
                    DateFounded = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                },
                new Team
                {
                    TeamId = 15,
                    Name = "Grizzlies",
                    City = "Memphis",
                    DateFounded = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                },
                new Team
                {
                    TeamId = 16,
                    Name = "Heat",
                    City = "Miami",
                    DateFounded = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                },
                new Team
                {
                    TeamId = 17,
                    Name = "Bucks",
                    City = "Milwaukee",
                    DateFounded = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                },
                new Team
                {
                    TeamId = 18,
                    Name = "Timberwolves",
                    City = "Minnesota",
                    DateFounded = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                },
                new Team
                {
                    TeamId = 19,
                    Name = "Pelicans",
                    City = "New Orleans",
                    DateFounded = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                },
                new Team
                {
                    TeamId = 20,
                    Name = "Knicks",
                    City = "New York",
                    DateFounded = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                },
                new Team
                {
                    TeamId = 21,
                    Name = "Thunder",
                    City = "Oklahoma City",
                    DateFounded = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                },
                new Team
                {
                    TeamId = 22,
                    Name = "Magic",
                    City = "Orlando",
                    DateFounded = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                },
                new Team
                {
                    TeamId = 23,
                    Name = "76ers",
                    City = "Philadelphia",
                    DateFounded = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                },
                new Team
                {
                    TeamId = 24,
                    Name = "Suns",
                    City = "Phoenix",
                    DateFounded = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                },
                new Team
                {
                    TeamId = 25,
                    Name = "Trail Blazers",
                    City = "Portland",
                    DateFounded = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                },
                new Team
                {
                    TeamId = 26,
                    Name = "Kings",
                    City = "Sacramento",
                    DateFounded = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                },
                new Team
                {
                    TeamId = 27,
                    Name = "Spurs",
                    City = "San Antonio",
                    DateFounded = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                },
                new Team
                {
                    TeamId = 28,
                    Name = "Raptos",
                    City = "Toronto",
                    DateFounded = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                },
                new Team
                {
                    TeamId = 29,
                    Name = "Jazz",
                    City = "Utah",
                    DateFounded = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                },
                new Team
                {
                    TeamId = 30,
                    Name = "Wizards",
                    City = "Washington",
                    DateFounded = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                }
                );
            #endregion Team Initializer

            #region Player Initializer
            modelBuilder.Entity<Player>()
                .HasData(
                new Player
                {
                    PlayerId = 1,
                    Name = "Trae Young",
                    Team = "Hawks",
                    Joined = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                },
                new Player
                {
                    PlayerId = 2,
                    Name = "Jayson Tatum",
                    Team = "Celtics",
                    Joined = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                },
                new Player
                {
                    PlayerId = 3,
                    Name = "Kevin Durant",
                    Team = "Nets",
                    Joined = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                },
                new Player
                {
                    PlayerId = 4,
                    Name = "Stephen Curry",
                    Team = "Warriors",
                    Joined = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                },
                new Player
                {
                    PlayerId = 5,
                    Name = "Zach LaVine",
                    Team = "Bulls",
                    Joined = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                },
                new Player
                {
                    PlayerId = 6,
                    Name = "LeBron James",
                    Team = "Lakers",
                    Joined = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                },
                new Player
                {
                    PlayerId = 7,
                    Name = "Anthony Davis",
                    Team = "Lakers",
                    Joined = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                },
                new Player
                {
                    PlayerId = 8,
                    Name = "Julius Randle",
                    Team = "Knicks",
                    Joined = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                }
                );
            #endregion Player Initializer

            #region Team history intializer
            modelBuilder.Entity<TeamHistory>()
                .HasData(
                new TeamHistory
                {
                    TeamHistoryId = 1,
                    Team = "Lakers",
                    Season = "2019-2020",
                    WinRecord = 52,
                    LossRecord = 19,
                    MOV = 5.79,
                    SOS = 0.49,
                    ORTg = 112,
                    DRTg = 106.3,
                    FTr = 0.276,
                    ThreePAr = 0.358,
                    OEFGPct = 0.542,
                    DEFGPct = 0.515,
                    ORB = 24.5,
                    DRB = 78.8
                },
                new TeamHistory
                {
                    TeamHistoryId = 2,
                    Team = "Heat",
                    Season = "2019-2020",
                    WinRecord = 44,
                    LossRecord = 29,
                    MOV = 2.95,
                    SOS = 0.35,
                    ORTg = 112.5,
                    DRTg = 109.5,
                    FTr = 0.299,
                    ThreePAr = 0.419,
                    OEFGPct = 0.547,
                    DEFGPct = 0.523,
                    ORB = 20.3,
                    DRB = 79.5
                }
                );
            #endregion Team history intializer

        }
        #endregion Model initializers
    }
}

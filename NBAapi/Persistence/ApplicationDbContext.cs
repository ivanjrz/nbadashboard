using System;
using System.Collections.Generic;
using System.IO;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

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

            //Team history intializer
            modelBuilder.Entity<TeamHistory>().HasData(JsonSeasonHistory());

            
        }
        /// <summary>
        /// Returns list of TeamHistory entities for initial data seeding
        /// </summary>
        /// <returns></returns>
        public List<TeamHistory> JsonSeasonHistory()
        {
            var values = new List<TeamHistory>();
            using (StreamReader r = new StreamReader(@"../Persistence/team_season_histories.json"))
            {
                string json = r.ReadToEnd();
                values = JsonConvert.DeserializeObject<List<TeamHistory>>(json);
            }
            return values;
        }

        #endregion Model initializers
    }
}

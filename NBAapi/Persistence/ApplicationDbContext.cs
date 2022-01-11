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

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            if (!_created)
            {
                _created = true;
                Database.EnsureDeleted();
                Database.EnsureCreated();
            }
        }

        #region Required
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Team>()
            //    .Property(b => b.Url)
            //    .IsRequired();
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
                    Name = "Warriors",
                    City = "Golden State",
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
                    Name = "Lakers",
                    City = "Los Angeles",
                    DateFounded = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                },
                new Team
                {
                    TeamId = 7,
                    Name = "Knicks",
                    City = "New York",
                    DateFounded = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                });

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
                    Name = "Julius Randle",
                    Team = "Knicks",
                    Joined = DateTime.Now,
                    PhotoPath = "/Photos/nba_anonymous.jpg"
                }

                );
        }
        #endregion
        
    }
}

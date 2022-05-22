using System;
using Xunit;
using Moq;
using Domain.Repositories;
using Services;
using System.Collections.Generic;
using Presentation.Controllers;
using Contracts;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System.Reflection;
using Domain.Entities;
using Domain.Exceptions;

namespace NBAapiTests
{
    public class TeamServiceTests
    {
        private readonly ServiceManager _sut;
        private readonly Mock<IRepositoryManager> _repoManagerMock = new Mock<IRepositoryManager>();

        public TeamServiceTests()
        {
            _sut = new ServiceManager(_repoManagerMock.Object);
        }

        private static Task<Team> SingleTeamMock()
        {
            return Task.FromResult(new Team
            {
                TeamId = 14,
                Name = "Lakers",
                City = "Los Angeles",
                DateFounded = DateTime.Now,
                PhotoPath = "/Photos/nba_anonymous.jpg"
            });
        }

        public static Task<IEnumerable<Team>> TeamListMock()
        {
            var r = new List<Team>();
            r.Add(new Team()
            {
                TeamId = 2,
                Name = "Celtics",
                City = "Boston",
                DateFounded = DateTime.Now,
                PhotoPath = "/Photos/nba_anonymous.jpg"
            });
            r.Add(new Team()
            {
                TeamId = 3,
                Name = "Nets",
                City = "Brooklyn",
                DateFounded = DateTime.Now,
                PhotoPath = "/Photos/nba_anonymous.jpg"
            });
            r.Add(new Team()
            {
                TeamId = 2,
                Name = "Celtics",
                City = "Boston",
                DateFounded = DateTime.Now,
                PhotoPath = "/Photos/nba_anonymous.jpg"
            });
            r.Add(new Team()
            {
                TeamId = 5,
                Name = "Bulls",
                City = "Chicago",
                DateFounded = DateTime.Now,
                PhotoPath = "/Photos/nba_anonymous.jpg"
            });
            r.Add(new Team()
            {
                TeamId = 14,
                Name = "Lakers",
                City = "Los Angeles",
                DateFounded = DateTime.Now,
                PhotoPath = "/Photos/nba_anonymous.jpg"
            });
            return Task.FromResult((IEnumerable<Team>)r);
        }

        public static Task<Team> GetTeamFromListById(int teamId)
        {
            var r = new List<Team>();
            r.Add(new Team()
            {
                TeamId = 2,
                Name = "Celtics",
                City = "Boston",
                DateFounded = DateTime.Now,
                PhotoPath = "/Photos/nba_anonymous.jpg"
            });
            r.Add(new Team()
            {
                TeamId = 3,
                Name = "Nets",
                City = "Brooklyn",
                DateFounded = DateTime.Now,
                PhotoPath = "/Photos/nba_anonymous.jpg"
            });
            r.Add(new Team()
            {
                TeamId = 5,
                Name = "Bulls",
                City = "Chicago",
                DateFounded = DateTime.Now,
                PhotoPath = "/Photos/nba_anonymous.jpg"
            });
            r.Add(new Team()
            {
                TeamId = 7,
                Name = "Mavericks",
                City = "Dallas",
                DateFounded = DateTime.Now,
                PhotoPath = "/Photos/nba_anonymous.jpg"
            });
            r.Add(new Team()
            {
                TeamId = 14,
                Name = "Lakers",
                City = "Los Angeles",
                DateFounded = DateTime.Now,
                PhotoPath = "/Photos/nba_anonymous.jpg"
            });
            return Task.FromResult(r.FirstOrDefault(x => x.TeamId == teamId));
        }

        [Fact]
        public async Task GetAllAsync_ShouldReturnAllTeams()
        {
            //Arrange
            int totalTeamsExpected = 5;
            int totalTeamsMock = 0;
            _repoManagerMock.Setup(x => x.TeamRepository.GetAllAsync(CancellationToken.None))
                .Returns(TeamListMock());

            //Act
            var teams = await _sut.TeamService.GetAllAsync(CancellationToken.None);
            totalTeamsMock = teams.Count();

            //Assert
            Assert.Equal(totalTeamsExpected, totalTeamsMock);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(14)]
        public async Task GetByIdAsync_ShouldReturnTeam_WhenTeamIdIsValidAsync(int teamId)
        {
            //Arrange
            _repoManagerMock.Setup(x => x.TeamRepository.GetByIdAsync(teamId, CancellationToken.None))
                .Returns(GetTeamFromListById(teamId));

            //Act
            var team = await _sut.TeamService.GetByIdAsync(teamId, CancellationToken.None);

            //Assert
            Assert.Equal(teamId, team.TeamId);
        }

        [Theory]
        [InlineData(40)]
        [InlineData(99)]
        public async Task GetByIdAsync_ShouldNotReturnTeam_WhenTeamIdDoesNotExistAsync(int teamId)
        {
            //Arrange
            string expectedError = string.Format("The team with id: {0} was not found", teamId);
            _repoManagerMock.Setup(x => x.TeamRepository.GetByIdAsync(teamId, CancellationToken.None))
                .Returns(GetTeamFromListById(teamId));

            //Act & Assert 
            await Assert.ThrowsAsync<TeamNotFoundException>(() => _sut.TeamService.GetByIdAsync(teamId, CancellationToken.None));

        }


    }
}

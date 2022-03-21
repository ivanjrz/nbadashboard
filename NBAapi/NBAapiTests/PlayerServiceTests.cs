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

namespace NBAapiTests
{
    public class PlayerServiceTests
    {
        private readonly ServiceManager _sut;
        private readonly Mock<IRepositoryManager> _repoManagerMock = new Mock<IRepositoryManager>();

        //private readonly Mock<ITeamService> _teamServiceMock = new Mock<ITeamService>();
        //private readonly Mock<ITeamHistoryService> _teamHistoryServiceMock = new Mock<ITeamHistoryService>();
        //private readonly Mock<IPlayerService> _playerServiceMock = new Mock<IPlayerService>();

        public PlayerServiceTests()
        {
            _sut = new ServiceManager(_repoManagerMock.Object);
        }

        private static T CreateInstance<T>(BindingFlags bindingFlags, Type[] types, object[] ctorParams)
        {
            var type = typeof(T);
            var constructor = type.GetConstructor(
                bindingFlags,
                null,
                types,
                Array.Empty<ParameterModifier>()) ?? throw new Exception("This didn't work...");

            return (T)constructor.Invoke(ctorParams);
        }

        private static Task<Team> TeamMock()
        {
            return Task.FromResult( new Team
            {
                TeamId = 14,
                Name = "Lakers",
                City = "Los Angeles",
                DateFounded = DateTime.Now,
                PhotoPath = "/Photos/nba_anonymous.jpg"
            });
        }

        private static Task<Player> PlayerMock()
        {
            return Task.FromResult(new Player()
            {
                PlayerId = 6,
                Name = "LeBron James",
                Team = "Lakers",
                Joined = DateTime.Now,
                PhotoPath = "/Photos/nba_anonymous.jpg"
            });
        }

        private static Task<IEnumerable<Player>> PlayerListMock()
        {
            var r = new List<Player>();
            r.Add(new Player()
            {
                PlayerId = 6,
                Name = "LeBron James",
                Team = "Lakers",
                Joined = DateTime.Now,
                PhotoPath = "/Photos/nba_anonymous.jpg"
            });
            r.Add(new Player()
            {
                PlayerId = 7,
                Name = "Anthony Davis",
                Team = "Lakers",
                Joined = DateTime.Now,
                PhotoPath = "/Photos/nba_anonymous.jpg"
            });
            return Task.FromResult((IEnumerable<Player>)r);
        }

        [Fact]
        public async Task GetAllByTeamNameAsync_ShouldReturnTotalPlayers_WhenTeamIsValidAsync()
        {
            //Arrange
            int totalPlayers = 2;
            string teamName = "Lakers";
            int playerCountFromService = 0;
            _repoManagerMock.Setup(x => x.PlayerRepository.GetAllByTeamNameAsync(teamName, CancellationToken.None))
                .Returns(PlayerListMock());

            //Act
            var players = await _sut.PlayerService.GetAllByTeamNameAsync(teamName, CancellationToken.None);
            playerCountFromService = players.Count();

            //Assert
            Assert.Equal(totalPlayers, playerCountFromService);

        }

        [Fact]
        public async Task GetByIdAsync_ShouldReturnPlayer_WhenPlayerIsValidAsync()
        {
            //Arrange
            int playerId = 6;
            int teamId = 14;
            string teamName = "Lakers";
            string playerName = "LeBron James";
            _repoManagerMock.Setup(x => x.TeamRepository.GetByIdAsync(teamId, CancellationToken.None))
                .Returns(TeamMock());
            _repoManagerMock.Setup(x => x.PlayerRepository.GetByIdAsync(playerId, CancellationToken.None))
                .Returns(PlayerMock());

            //Act
            var players = await _sut.PlayerService.GetByIdAsync(teamId, playerId, CancellationToken.None);

            //Assert
            Assert.Equal(playerId, players.PlayerId);
            Assert.Equal(playerName, players.Name);
            Assert.Equal(teamName, players.Team);

        }
    }
}

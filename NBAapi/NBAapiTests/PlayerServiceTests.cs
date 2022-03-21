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
        //private readonly PlayerService _sut;
        private readonly ServiceManager _ssm;
        private readonly Mock<IRepositoryManager> _repoManagerMock = new Mock<IRepositoryManager>();
        private readonly Mock<IPlayerRepository> _playerRepoMock = new Mock<IPlayerRepository>();

        //private readonly Mock<ITeamService> _teamServiceMock = new Mock<ITeamService>();
        //private readonly Mock<ITeamHistoryService> _teamHistoryServiceMock = new Mock<ITeamHistoryService>();
        //private readonly Mock<IPlayerService> _playerServiceMock = new Mock<IPlayerService>();

        public PlayerServiceTests()
        {
            //_sut = new PlayerService(_repoManagerMock.Object);
            _ssm = new ServiceManager(_repoManagerMock.Object);

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

        private static Task<PlayerDto> MockSingle()
        {
            return Task.FromResult(new PlayerDto()
            {
                PlayerId = 6,
                Name = "LeBron James",
                Team = "Lakers",
                Joined = DateTime.Now,
                PhotoPath = "/Photos/nba_anonymous.jpg"
            });
        }

        private static Task<IEnumerable<PlayerDto>> MockList()
        {
            var r = new List<PlayerDto>();
            r.Add(new PlayerDto()
            {
                PlayerId = 6,
                Name = "LeBron James",
                Team = "Lakers",
                Joined = DateTime.Now,
                PhotoPath = "/Photos/nba_anonymous.jpg"
            });
            r.Add(new PlayerDto()
            {
                PlayerId = 7,
                Name = "Anthony Davis",
                Team = "Lakers",
                Joined = DateTime.Now,
                PhotoPath = "/Photos/nba_anonymous.jpg"
            });
            return Task.FromResult((IEnumerable<PlayerDto>)r);
        }

        private static Task<IEnumerable<Player>> MockPlayerList()
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
                .Returns(MockPlayerList());

            //Act
            var players = await _ssm.PlayerService.GetAllByTeamNameAsync(teamName, CancellationToken.None);
            playerCountFromService = players.Count();

            //Assert
            Assert.Equal(totalPlayers, playerCountFromService);

        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;
using Contracts;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Services;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/player")]
    public class PlayerController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public PlayerController(IServiceManager serviceManager) => _serviceManager = serviceManager;

        [HttpGet]
        public async Task<IActionResult> GetPlayers(CancellationToken cancellationToken)
        {
            var teams = await _serviceManager.PlayerService.GetAllAsync(cancellationToken);

            return Ok(teams);
        }

        [HttpGet("{team}")]
        public async Task<IActionResult> GetTeams(string team, CancellationToken cancellationToken)
        {
            var playersDto = await _serviceManager.PlayerService.GetAllByTeamNameAsync(team, cancellationToken);

            return Ok(playersDto);
        }

        [HttpGet("{playerId:int}")]
        public async Task<IActionResult> GetPlayerById(int teamId, int playerId, CancellationToken cancellationToken)
        {
            var playDto = await _serviceManager.PlayerService.GetByIdAsync(teamId, playerId, cancellationToken);

            return Ok(playDto);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePlayer(int team, [FromBody] CreatePlayerDto playerForCreationDto, CancellationToken cancellationToken)
        {
            var response = await _serviceManager.PlayerService.CreateAsync(team, playerForCreationDto, cancellationToken);

            return CreatedAtAction(nameof(GetPlayerById), new { ownerId = response.Team, playerId = response.PlayerId}, response);
        }

        [HttpDelete("{player:int}")]
        public async Task<IActionResult> DeletePlayer(int teamId, int playerId, CancellationToken cancellationToken)
        {
            await _serviceManager.PlayerService.DeleteAsync(teamId, playerId, cancellationToken);

            return NoContent();
        }

    }
}

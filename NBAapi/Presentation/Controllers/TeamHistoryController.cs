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
    [Route("api/teamhistory")]
    public class TeamHistoryController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public TeamHistoryController(IServiceManager serviceManager) => _serviceManager = serviceManager;

        [HttpGet]
        public async Task<IActionResult> GetHistories(CancellationToken cancellationToken)
        {
            var teams = await _serviceManager.TeamHistoryService.GetAllAsync(cancellationToken);

            return Ok(teams);
        }

        [HttpGet("{team}")]
        public async Task<IActionResult> GetTeams(string team, CancellationToken cancellationToken)
        {
            var teamHistoriesDto = await _serviceManager.TeamHistoryService.GetAllByTeamNameAsync(team, cancellationToken);

            return Ok(teamHistoriesDto);
        }

        [HttpGet("{teamhistory:int}")]
        public async Task<IActionResult> GetHistoryById(int teamId, int playerId, CancellationToken cancellationToken)
        {
            var playDto = await _serviceManager.TeamHistoryService.GetByIdAsync(teamId, playerId, cancellationToken);

            return Ok(playDto);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTeamHistory(int team, [FromBody] CreateTeamHistoryDto historyForCreationDto, CancellationToken cancellationToken)
        {
            var response = await _serviceManager.TeamHistoryService.CreateAsync(team, historyForCreationDto, cancellationToken);

            return CreatedAtAction(nameof(GetHistoryById), new { team = response.Team, playerId = response.TeamHistoryId}, response);
        }

        [HttpDelete("{teamhistory:int}")]
        public async Task<IActionResult> DeleteTeamHistory(int teamId, int teamHistoryId, CancellationToken cancellationToken)
        {
            await _serviceManager.TeamHistoryService.DeleteAsync(teamId, teamHistoryId, cancellationToken);

            return NoContent();
        }

    }
}

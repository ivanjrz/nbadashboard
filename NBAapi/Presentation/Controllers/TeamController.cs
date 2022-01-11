using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Hosting;
using System.Threading;
using System.Threading.Tasks;
using Services;
using Contracts;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/team")]
    public class TeamController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public TeamController(IServiceManager serviceManager) => _serviceManager = serviceManager;

        [HttpGet]
        public async Task<IActionResult> GetTeams(CancellationToken cancellationToken)
        {
            var teams = await _serviceManager.TeamService.GetAllAsync(cancellationToken);

            return Ok(teams);
        }

        [HttpGet("{teamId:int}")]
        public async Task<IActionResult> GetTeamById(int teamId, CancellationToken cancellationToken)
        {
            var teamDto = await _serviceManager.TeamService.GetByIdAsync(teamId, cancellationToken);

            return Ok(teamDto);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTeam([FromBody] CreateTeamDto teamForCreationDto)
        {
            var teamDto = await _serviceManager.TeamService.CreateAsync(teamForCreationDto);

            return CreatedAtAction(nameof(GetTeamById), new { teamId = teamDto.TeamId }, teamDto);
        }

        [HttpPut("{teamId:int}")]
        public async Task<IActionResult> UpdateTeam(int teamId, [FromBody] UpdateTeamDto teamForUpdateDto, CancellationToken cancellationToken)
        {
            await _serviceManager.TeamService.UpdateAsync(teamId, teamForUpdateDto, cancellationToken);

            return NoContent();
        }

        [HttpDelete("{teamId:int}")]
        public async Task<IActionResult> DeleteTeam(int teamId, CancellationToken cancellationToken)
        {
            await _serviceManager.TeamService.DeleteAsync(teamId, cancellationToken);

            return NoContent();
        }
    }
}

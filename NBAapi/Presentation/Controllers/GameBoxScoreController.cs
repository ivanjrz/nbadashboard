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
    [Route("api/gameboxscore")]
    public class GameBoxScoreController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public GameBoxScoreController(IServiceManager serviceManager) => _serviceManager = serviceManager;

        [HttpGet]
        public async Task<IActionResult> GetGameBoxScores(CancellationToken cancellationToken)
        {
            var gbsDto = await _serviceManager.GameBoxScoreService.GetAllAsync(cancellationToken);

            return Ok(gbsDto);
        }

        [HttpGet("{gameId:double}")]
        public async Task<IActionResult> GetGameBoxScoreById(double gameId, CancellationToken cancellationToken)
        {
            var gbsDto = await _serviceManager.GameBoxScoreService.GetByIdAsync(gameId, cancellationToken);

            return Ok(gbsDto);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePlayer([FromBody] CreateGameBoxScoreDto GBSToCreateDto, CancellationToken cancellationToken)
        {
            var response = await _serviceManager.GameBoxScoreService.CreateAsync(GBSToCreateDto, cancellationToken);

            return CreatedAtAction(nameof(GetGameBoxScoreById), new { gameId = response.NBA_API_GameId}, response);
        }

        [HttpDelete("{gameId:double}")]
        public async Task<IActionResult> DeleteGameBoxScore(double gameId, CancellationToken cancellationToken)
        {
            await _serviceManager.GameBoxScoreService.DeleteAsync(gameId, cancellationToken);

            return NoContent();
        }

    }
}

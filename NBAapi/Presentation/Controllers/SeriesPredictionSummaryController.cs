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
    [Route("api/seriesprediction")]
    public class SeriesPredictionSummaryController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public SeriesPredictionSummaryController(IServiceManager serviceManager) => _serviceManager = serviceManager;

        [HttpGet]
        public async Task<IActionResult> GetSeries(CancellationToken cancellationToken)
        {
            var teams = await _serviceManager.SeriesPredictionSummaryService.GetAllAsync(cancellationToken);

            return Ok(teams);
        }

        [HttpGet("{seriesPredictionSummaryId:int}")]
        public async Task<IActionResult> GetSeriesById(int seriesPredictionSummaryId, CancellationToken cancellationToken)
        {
            var teamDto = await _serviceManager.SeriesPredictionSummaryService.GetByIdAsync(seriesPredictionSummaryId, cancellationToken);

            return Ok(teamDto);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSeries([FromBody] SeriesPredictionSummaryDto seriesForCreationDto)
        {
            var teamDto = await _serviceManager.SeriesPredictionSummaryService.CreateAsync(seriesForCreationDto);

            return CreatedAtAction(nameof(GetSeriesById), new { seriesId = teamDto.TeamId }, teamDto);
        }

        [HttpDelete("{seriesPredictionSummaryId:int}")]
        public async Task<IActionResult> DeleteSeries(int seriesPredictionSummaryId, CancellationToken cancellationToken)
        {
            await _serviceManager.SeriesPredictionSummaryService.DeleteAsync(seriesPredictionSummaryId, cancellationToken);

            return NoContent();
        }
    }
}

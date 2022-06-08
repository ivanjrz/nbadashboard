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
    [Route("api/prediction")]
    public class SinglePredictionController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public SinglePredictionController(IServiceManager serviceManager) => _serviceManager = serviceManager;


        [HttpGet]
        public async Task<IActionResult> GetPredictions(CancellationToken cancellationToken)
        {
            var preds = await _serviceManager.SinglePredictionService.GetAllAsync(cancellationToken);

            return Ok(preds);
        }


        [HttpGet("{seriesId:int}")]
        public async Task<IActionResult> GetSeries(int seriesId, CancellationToken cancellationToken)
        {
            var predsDto = await _serviceManager.SinglePredictionService.GetAllBySeriesIdAsync(seriesId, cancellationToken);

            return Ok(predsDto);
        }

    }
}

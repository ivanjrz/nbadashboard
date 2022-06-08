using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    internal sealed class SinglePredictionRepository : ISinglePredictionRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public SinglePredictionRepository(ApplicationDbContext dbContext) => _dbContext = dbContext;

        public async Task<IEnumerable<SinglePrediction>> GetAllAsync(CancellationToken cancellationToken = default) =>
            await _dbContext.SinglePrediction.ToListAsync(cancellationToken);

        public async Task<IEnumerable<SinglePrediction>> GetAllBySeriesIdAsync(int seriesId, CancellationToken cancellationToken = default) =>

            await _dbContext.SinglePrediction.Where(x => x.SeriesPredictionSummaryId == seriesId).ToListAsync(cancellationToken);
    }
}

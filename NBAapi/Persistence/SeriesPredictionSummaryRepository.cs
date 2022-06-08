using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    internal sealed class SeriesPredictionSummaryRepository : ISeriesPredictionSummaryRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public SeriesPredictionSummaryRepository(ApplicationDbContext dbContext) => _dbContext = dbContext;

        public async Task<IEnumerable<SeriesPredictionSummary>> GetAllAsync(CancellationToken cancellationToken = default) =>
            await _dbContext.SeriesPredictionSummary.Include(x => x.Predictions).ToListAsync(cancellationToken);

        public async Task<SeriesPredictionSummary> GetByIdAsync(int seriesId, CancellationToken cancellationToken = default) =>
            await _dbContext.SeriesPredictionSummary.Include(x => x.Predictions).FirstOrDefaultAsync(x => x.SeriesPredictionSummaryId == seriesId, cancellationToken);

        public void Insert(SeriesPredictionSummary series) => _dbContext.SeriesPredictionSummary.Add(series);

        public void Remove(SeriesPredictionSummary series) => _dbContext.SeriesPredictionSummary.Remove(series);
    }
}

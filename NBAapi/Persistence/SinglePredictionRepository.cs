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

        public async Task<IEnumerable<SinglePrediction>> GetAllBySeriesAsync(int teamId, CancellationToken cancellationToken = default) =>
            await _dbContext.SinglePrediction.Where(x => x.TeamId == teamId).ToListAsync(cancellationToken);

        public async Task<IEnumerable<SinglePrediction>> GetAllAsync(CancellationToken cancellationToken = default) =>
            await _dbContext.SinglePrediction.ToListAsync(cancellationToken);

        public async Task<SinglePrediction> GetByIdAsync(int singleId, CancellationToken cancellationToken = default) =>
            await _dbContext.SinglePrediction.FirstOrDefaultAsync(x => x.SinglePredictionId == singleId, cancellationToken);

        public void Insert(SinglePrediction single) => _dbContext.SinglePrediction.Add(single);

        public void Remove(SinglePrediction single) => _dbContext.SinglePrediction.Remove(single);
    }
}

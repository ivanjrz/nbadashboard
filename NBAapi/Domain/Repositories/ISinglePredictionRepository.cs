using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Repositories
{
    public interface ISinglePredictionRepository
    {
        Task<IEnumerable<SinglePrediction>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<IEnumerable<SinglePrediction>> GetAllBySeriesIdAsync(int seriesId, CancellationToken cancellationToken = default);
    }
}

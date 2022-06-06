using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Repositories
{
    public interface ISinglePredictionRepository
    {
        Task<IEnumerable<SinglePrediction>> GetAllBySeriesAsync(int seriesId, CancellationToken cancellationToken = default);
        Task<IEnumerable<SinglePrediction>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<SinglePrediction> GetByIdAsync(int singlePredictionId, CancellationToken cancellationToken = default);

        void Insert(SinglePrediction single);
        void Remove(SinglePrediction single);
    }
}

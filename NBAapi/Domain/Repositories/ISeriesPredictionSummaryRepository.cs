using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Repositories
{
    public interface ISeriesPredictionSummaryRepository
    {
        Task<IEnumerable<SeriesPredictionSummary>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<SeriesPredictionSummary> GetByIdAsync(int seriesId, CancellationToken cancellationToken = default);

        void Insert(SeriesPredictionSummary series);
        void Remove(SeriesPredictionSummary series);
    }
}

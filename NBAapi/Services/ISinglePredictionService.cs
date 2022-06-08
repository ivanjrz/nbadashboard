using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Contracts;

namespace Services
{
    public interface ISinglePredictionService
    {
        Task<IEnumerable<SinglePredictionDto>> GetAllAsync(CancellationToken cancellationToken);
        Task<IEnumerable<SinglePredictionDto>> GetAllBySeriesIdAsync(int seriesId, CancellationToken cancellationToken = default);
    }
}
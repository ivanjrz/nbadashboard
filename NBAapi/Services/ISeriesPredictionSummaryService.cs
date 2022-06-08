using System.Threading;
using System.Threading.Tasks;
using Contracts;

namespace Services
{
    public interface ISeriesPredictionSummaryService
    {
        Task<SeriesPredictionSummaryDto> CreateAsync(SeriesPredictionSummaryDto seriesCreationDto, CancellationToken cancellationToken = default);
        Task DeleteAsync(int Id, CancellationToken cancellationToken = default);
        Task<System.Collections.Generic.IEnumerable<SeriesPredictionSummaryDto>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<SeriesPredictionSummaryDto> GetByIdAsync(int Id, CancellationToken cancellationToken = default);
    }
}
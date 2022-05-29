using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Contracts;

namespace Services
{
    public interface IGameBoxScoreService
    {
        Task<GameBoxScoreDto> CreateAsync(CreateGameBoxScoreDto GBSToCreate, CancellationToken cancellationToken = default);
        Task DeleteAsync(double gbs, CancellationToken cancellationToken = default);
        Task<GameBoxScoreDto> GetByIdAsync(double gameId, CancellationToken cancellationToken);
        Task<IEnumerable<GameBoxScoreDto>> GetAllAsync(CancellationToken cancellationToken);
    }
}
using System.Threading;
using System.Threading.Tasks;
using Contracts;

namespace Services
{
    public interface ITeamHistoryService
    {
        Task<TeamHistoryDto> CreateAsync(int teamId, CreateTeamHistoryDto TeamHistoryForCreationDto, CancellationToken cancellationToken = default);
        Task DeleteAsync(int teamId, int teamHistoryId, CancellationToken cancellationToken = default);
        Task<System.Collections.Generic.IEnumerable<TeamHistoryDto>> GetAllByTeamIdAsync(string team, CancellationToken cancellationToken = default);
        Task<TeamHistoryDto> GetByIdAsync(int teamId, int playerId, CancellationToken cancellationToken);
        Task<System.Collections.Generic.IEnumerable<TeamHistoryDto>> GetAllAsync(CancellationToken cancellationToken);
    }
}
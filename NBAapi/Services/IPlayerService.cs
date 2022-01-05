using System.Threading;
using System.Threading.Tasks;

namespace Services
{
    public interface IPlayerService
    {
        Task<PlayerDto> CreateAsync(int teamId, PlayerForCreationDto PlayerForCreationDto, CancellationToken cancellationToken = default);
        Task DeleteAsync(int teamId, int playerId, CancellationToken cancellationToken = default);
        Task<System.Collections.Generic.IEnumerable<PlayerDto>> GetAllByTeamIdAsync(int Id, CancellationToken cancellationToken = default);
        Task<PlayerDto> GetByIdAsync(int teamId, int playerId, CancellationToken cancellationToken);
    }
}
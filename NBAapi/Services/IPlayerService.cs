using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Contracts;

namespace Services
{
    public interface IPlayerService
    {
        Task<PlayerDto> CreateAsync(int teamId, CreatePlayerDto PlayerForCreationDto, CancellationToken cancellationToken = default);
        Task DeleteAsync(int teamId, int playerId, CancellationToken cancellationToken = default);
        Task<IEnumerable<PlayerDto>> GetAllByTeamNameAsync(string team, CancellationToken cancellationToken = default);
        Task<PlayerDto> GetByIdAsync(int teamId, int playerId, CancellationToken cancellationToken);
        Task<IEnumerable<PlayerDto>> GetAllAsync(CancellationToken cancellationToken);
    }
}
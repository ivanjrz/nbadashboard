using System.Threading;
using System.Threading.Tasks;
using Contracts;

namespace Services
{
    public interface ITeamService
    {
        Task<TeamDto> CreateAsync(CreateTeamDto teamForCreationDto, CancellationToken cancellationToken = default);
        Task DeleteAsync(int Id, CancellationToken cancellationToken = default);
        Task<System.Collections.Generic.IEnumerable<TeamDto>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<TeamDto> GetByIdAsync(int Id, CancellationToken cancellationToken = default);
        Task UpdateAsync(int Id, UpdateTeamDto teamForUpdateDto, CancellationToken cancellationToken = default);
    }
}
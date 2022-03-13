using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Repositories
{
    public interface ITeamHistoryRepository
    {
        Task<IEnumerable<TeamHistory>> GetAllByTeamIdAsync(string team, CancellationToken cancellationToken = default);
        Task<IEnumerable<TeamHistory>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<TeamHistory> GetByIdAsync(int teamHistoryId, CancellationToken cancellationToken = default);

        void Insert(TeamHistory team);
        void Update(TeamHistory team);
        void Remove(TeamHistory team);
    }
}

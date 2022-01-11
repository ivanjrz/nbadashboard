using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Repositories
{
    public interface ITeamRepository
    {
        Task<IEnumerable<Team>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<Team> GetByIdAsync(int teamId, CancellationToken cancellationToken = default);

        void Insert(Team team);
        //void Update(Team team);
        void Remove(Team team);
    }
}

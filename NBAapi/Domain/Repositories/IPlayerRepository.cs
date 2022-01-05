using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Repositories
{
    public interface IPlayerRepository
    {
        Task<IEnumerable<Player>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<Player> GetByIdAsync(int teamId, CancellationToken cancellationToken = default);

        void Insert(Player team);
        void Update(Player team);
        void Remove(Player team);
    }
}

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Repositories
{
    public interface IGameBoxScoreRepository
    {
        Task<IEnumerable<GameBoxScore>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<GameBoxScore> GetByIdAsync(double gameId, CancellationToken cancellationToken = default);

        void Insert(GameBoxScore gbs);
        void Remove(GameBoxScore gbs);
    }
}

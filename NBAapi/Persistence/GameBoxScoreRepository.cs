using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    internal sealed class GameBoxScoreRepository : IGameBoxScoreRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public GameBoxScoreRepository(ApplicationDbContext dbContext) => _dbContext = dbContext;

        public async Task<IEnumerable<GameBoxScore>> GetAllAsync(CancellationToken cancellationToken = default) =>
            await _dbContext.GameBoxScore.ToListAsync(cancellationToken);

        public async Task<GameBoxScore> GetByIdAsync(double gameId, CancellationToken cancellationToken = default) =>
            await _dbContext.GameBoxScore.FirstOrDefaultAsync(x => x.NBA_API_GameId == gameId, cancellationToken);

        public void Insert(GameBoxScore gbs) => _dbContext.GameBoxScore.Add(gbs);

        public void Remove(GameBoxScore gbs) => _dbContext.GameBoxScore.Remove(gbs);
    }
}

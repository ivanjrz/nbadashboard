using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    internal sealed class PlayerRepository : IPlayerRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public PlayerRepository(ApplicationDbContext dbContext) => _dbContext = dbContext;

        public async Task<IEnumerable<Player>> GetAllAsync(CancellationToken cancellationToken = default) =>
            await _dbContext.Player.ToListAsync(cancellationToken);

        public async Task<IEnumerable<Player>> GetAllByTeamIdAsync(string team, CancellationToken cancellationToken = default) =>
            await _dbContext.Player.Where(x => x.Team == team).ToListAsync(cancellationToken);

        public async Task<Player> GetByIdAsync(int playerId, CancellationToken cancellationToken = default) =>
            await _dbContext.Player.FirstOrDefaultAsync(x => x.PlayerId == playerId, cancellationToken);

        public void Insert(Player account) => _dbContext.Player.Add(account);

        public void Remove(Player account) => _dbContext.Player.Remove(account);

    }
}

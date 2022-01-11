using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    internal sealed class TeamRepository : ITeamRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public TeamRepository(ApplicationDbContext dbContext) => _dbContext = dbContext;

        public async Task<IEnumerable<Team>> GetAllAsync(CancellationToken cancellationToken = default) =>
            await _dbContext.Team.Include(x => x.Players).ToListAsync(cancellationToken);

        public async Task<Team> GetByIdAsync(int teamId, CancellationToken cancellationToken = default) =>
            await _dbContext.Team.Include(x => x.Players).FirstOrDefaultAsync(x => x.TeamId == teamId, cancellationToken);

        public void Insert(Team owner) => _dbContext.Team.Add(owner);

        public void Remove(Team owner) => _dbContext.Team.Remove(owner);
    }
}

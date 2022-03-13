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
    internal sealed class TeamHistoryRepository : ITeamHistoryRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public TeamHistoryRepository(ApplicationDbContext dbContext) => _dbContext = dbContext;

        public async Task<IEnumerable<TeamHistory>> GetAllAsync(CancellationToken cancellationToken = default) =>
            await _dbContext.TeamHistory.ToListAsync(cancellationToken);

        public async Task<IEnumerable<TeamHistory>> GetAllByTeamIdAsync(string team, CancellationToken cancellationToken = default) =>
            await _dbContext.TeamHistory.Where(x => x.Team == team).ToListAsync(cancellationToken);

        public async Task<TeamHistory> GetByIdAsync(int teamHistoryId, CancellationToken cancellationToken = default) =>
            await _dbContext.TeamHistory.FirstOrDefaultAsync(x => x.TeamHistoryId == teamHistoryId, cancellationToken);

        public void Insert(TeamHistory team) => _dbContext.TeamHistory.Add(team);

        public void Update(TeamHistory team) => _dbContext.TeamHistory.Update(team);

        public void Remove(TeamHistory team) => _dbContext.TeamHistory.Remove(team);

    }
}

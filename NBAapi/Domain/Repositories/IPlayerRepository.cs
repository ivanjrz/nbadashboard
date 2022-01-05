﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Repositories
{
    public interface IPlayerRepository
    {
        Task<IEnumerable<Player>> GetAllByTeamIdAsync(int teamId, CancellationToken cancellationToken = default);
        Task<Player> GetByIdAsync(int playerId, CancellationToken cancellationToken = default);

        void Insert(Player play);
        void Update(Player play);
        void Remove(Player play);
    }
}

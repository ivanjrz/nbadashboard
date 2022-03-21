﻿using System;
namespace Domain.Repositories
{
    public interface IRepositoryManager
    {
        ITeamRepository TeamRepository { get; }

        IPlayerRepository PlayerRepository { get; }

        ITeamHistoryRepository TeamHistoryRepository { get; }

        IUnitOfWork UnitOfWork { get; }
    }
}
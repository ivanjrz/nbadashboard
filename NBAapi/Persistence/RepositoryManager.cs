﻿using System;
using Domain.Repositories;

namespace Persistence
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly Lazy<ITeamRepository> _lazyTeamRepository;
        private readonly Lazy<IPlayerRepository> _lazyPlayerRepository;
        private readonly Lazy<IUnitOfWork> _lazyUnitOfWork;

        public RepositoryManager(ApplicationDbContext dbContext)
        {
            _lazyTeamRepository = new Lazy<ITeamRepository>(() => new TeamRepository(dbContext));
            _lazyPlayerRepository = new Lazy<IPlayerRepository>(() => new PlayerRepository(dbContext));
            _lazyUnitOfWork = new Lazy<IUnitOfWork>(() => new UnitOfWork(dbContext));
        }

        public ITeamRepository TeamRepository => _lazyTeamRepository.Value;

        public IPlayerRepository PlayerRepository => _lazyPlayerRepository.Value;

        public IUnitOfWork UnitOfWork => _lazyUnitOfWork.Value;
    }
}

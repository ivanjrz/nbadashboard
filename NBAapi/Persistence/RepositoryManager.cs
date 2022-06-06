using System;
using Domain.Repositories;

namespace Persistence
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly Lazy<ITeamRepository> _lazyTeamRepository;
        private readonly Lazy<ITeamHistoryRepository> _lazyTeamHistoryRepository;
        private readonly Lazy<IPlayerRepository> _lazyPlayerRepository;
        private readonly Lazy<IGameBoxScoreRepository> _gbsRepository;
        private readonly Lazy<ISinglePredictionRepository> _singlePredictionRepository;
        private readonly Lazy<ISeriesPredictionSummaryRepository> _seriesPredictionRepository;

        private readonly Lazy<IUnitOfWork> _lazyUnitOfWork;

        public RepositoryManager(ApplicationDbContext dbContext)
        {
            _lazyTeamRepository = new Lazy<ITeamRepository>(() => new TeamRepository(dbContext));
            _lazyTeamHistoryRepository = new Lazy<ITeamHistoryRepository>(() => new TeamHistoryRepository(dbContext));
            _lazyPlayerRepository = new Lazy<IPlayerRepository>(() => new PlayerRepository(dbContext));
            _gbsRepository = new Lazy<IGameBoxScoreRepository>(() => new GameBoxScoreRepository(dbContext));
            _singlePredictionRepository = new Lazy<ISinglePredictionRepository>(() => new SinglePredictionRepository(dbContext));
            _seriesPredictionRepository = new Lazy<ISeriesPredictionSummaryRepository>(() => new SeriesPredictionSummaryRepository(dbContext));
            _lazyUnitOfWork = new Lazy<IUnitOfWork>(() => new UnitOfWork(dbContext));
        }

        public ITeamRepository TeamRepository => _lazyTeamRepository.Value;

        public ITeamHistoryRepository TeamHistoryRepository => _lazyTeamHistoryRepository.Value;

        public IPlayerRepository PlayerRepository => _lazyPlayerRepository.Value;

        public IGameBoxScoreRepository GameBoxScoreRepository => _gbsRepository.Value;

        public ISinglePredictionRepository SinglePredictionRepository => _singlePredictionRepository.Value;

        public ISeriesPredictionSummaryRepository SeriesPredictionRepository => _seriesPredictionRepository.Value;

        public IUnitOfWork UnitOfWork => _lazyUnitOfWork.Value;
    }
}

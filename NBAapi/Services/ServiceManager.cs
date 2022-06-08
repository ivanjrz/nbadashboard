using System;
using Domain.Repositories;

namespace Services
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<ITeamService> _lazyTeamService;
        private readonly Lazy<IPlayerService> _lazyPlayerService;
        private readonly Lazy<ITeamHistoryService> _lazyTeamHistoryService;
        private readonly Lazy<IGameBoxScoreService> _lazyGBSService;
        private readonly Lazy<ISeriesPredictionSummaryService> _lazySeriesPrediction;
        private readonly Lazy<ISinglePredictionService> _lazySinglePrediction;

        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _lazyTeamService = new Lazy<ITeamService>(() => new TeamService(repositoryManager));
            _lazyPlayerService = new Lazy<IPlayerService>(() => new PlayerService(repositoryManager));
            _lazyTeamHistoryService = new Lazy<ITeamHistoryService>(() => new TeamHistoryService(repositoryManager));
            _lazyGBSService = new Lazy<IGameBoxScoreService>(() => new GameBoxScoreService(repositoryManager));
            _lazySeriesPrediction = new Lazy<ISeriesPredictionSummaryService>(() => new SeriesPredictionSummaryService(repositoryManager));
            _lazySinglePrediction = new Lazy<ISinglePredictionService>(() => new SinglePredictionService(repositoryManager));
        }
        public ITeamService TeamService => _lazyTeamService.Value;
        public IPlayerService PlayerService => _lazyPlayerService.Value;
        public ITeamHistoryService TeamHistoryService => _lazyTeamHistoryService.Value;
        public IGameBoxScoreService GameBoxScoreService => _lazyGBSService.Value;
        public ISeriesPredictionSummaryService SeriesPredictionSummaryService => _lazySeriesPrediction.Value;
        public ISinglePredictionService SinglePredictionService => _lazySinglePrediction.Value;
    }
}

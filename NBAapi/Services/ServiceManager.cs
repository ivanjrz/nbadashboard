using System;
using Domain.Repositories;

namespace Services
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<ITeamService> _lazyTeamService;
        private readonly Lazy<IPlayerService> _lazyPlayerService;
        private readonly Lazy<ITeamHistoryService> _lazyTeamHistoryService;
        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _lazyTeamService = new Lazy<ITeamService>(() => new TeamService(repositoryManager));
            _lazyPlayerService = new Lazy<IPlayerService>(() => new PlayerService(repositoryManager));
            _lazyTeamHistoryService = new Lazy<ITeamHistoryService>(() => new TeamHistoryService(repositoryManager));
        }
        public ITeamService TeamService => _lazyTeamService.Value;
        public IPlayerService PlayerService => _lazyPlayerService.Value;
        public ITeamHistoryService TeamHistoryService => _lazyTeamHistoryService.Value;
    }
}

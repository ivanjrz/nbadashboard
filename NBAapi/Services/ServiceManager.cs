using System;
using Domain.Repositories;

namespace Services
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<ITeamService> _lazyTeamService;
        private readonly Lazy<IPlayerService> _lazyPlayerService;
        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _lazyTeamService = new Lazy<ITeamService>(() => new TeamService(repositoryManager));
            _lazyPlayerService = new Lazy<IPlayerService>(() => new PlayerService(repositoryManager));
        }
        public ITeamService TeamService => _lazyTeamService.Value;
        public IPlayerService PlayerService => _lazyPlayerService.Value;
    }
}

using System;
namespace Services
{
    public interface IServiceManager
    {
        ITeamService TeamService { get; }

        IPlayerService PlayerService { get; }
    }
}

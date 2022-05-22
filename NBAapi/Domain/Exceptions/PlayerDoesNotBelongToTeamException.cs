using System;
namespace Domain.Exceptions
{
    public class PlayerDoesNotBelongToTeamException : NotFoundException
    {
        public PlayerDoesNotBelongToTeamException(int playerId, int teamId) : base($"The player with id: {playerId} does not belong to team {teamId}")
        { }
    }
}

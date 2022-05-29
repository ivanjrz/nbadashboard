using System;
namespace Domain.Exceptions
{
    public sealed class GameBoxScoreNotFoundException : NotFoundException
    {
        public GameBoxScoreNotFoundException(double gameId) : base($"The Game with id: {gameId} was not found")
        { }
        
    }
}

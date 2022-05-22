using System;
namespace Domain.Exceptions
{
    public sealed class TeamNotFoundException : NotFoundException
    {
        public TeamNotFoundException(int teamId) : base($"The team with id: {teamId} was not found")
        { }
        
    }
}

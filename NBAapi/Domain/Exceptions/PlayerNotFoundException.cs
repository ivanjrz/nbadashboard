using System;
namespace Domain.Exceptions
{
    public class PlayerNotFoundException : NotFoundException
    {
        public PlayerNotFoundException(int id) : base($"The player with id: {id} was not found")
        { }
    }
}

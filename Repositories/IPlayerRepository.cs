using GraphQLDemo.Models;
using System.Collections.Generic;

namespace GraphQLDemo.Repositories
{
    public interface IPlayerRepository
    {
        IEnumerable<Player> GetPlayers();
    }
}

using GraphQLDemo.DbContexts;
using GraphQLDemo.Models;
using System;
using System.Collections.Generic;

namespace GraphQLDemo.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly PlayerContext _context;

        public PlayerRepository(PlayerContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IEnumerable<Player> GetPlayers()
        {
            return _context.Players;
        }
    }
}

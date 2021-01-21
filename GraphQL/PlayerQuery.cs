using GraphQL.Types;
using GraphQLDemo.Repositories;

namespace GraphQLDemo.GraphQL
{
    public class PlayerQuery : ObjectGraphType
    {
        public PlayerQuery(IPlayerRepository _playerRepository)
        {
            Field<ListGraphType<PlayerType>>(
                "players",
                resolve: ctx => _playerRepository.GetPlayers()
            );
        }
    }
}

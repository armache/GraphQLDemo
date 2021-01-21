using GraphQL.Types;
using GraphQLDemo.Models;

namespace GraphQLDemo.GraphQL
{
    public class PlayerType : ObjectGraphType<Player>
    {
        public PlayerType()
        {
            Field(a => a.PlayerId, nullable: true);
            Field(a => a.FirstName);
            Field(a => a.LastName);
        }
    }
}

using GraphQL.Types;
using System;

namespace GraphQLDemo.GraphQL
{
    public class PlayerSchema : Schema
    {
        public PlayerSchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = (PlayerQuery)serviceProvider.GetService(typeof(PlayerQuery));
        }
    }
}

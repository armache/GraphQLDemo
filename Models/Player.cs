using System;

namespace GraphQLDemo.Models
{
    public class Player
    {
        public Guid? PlayerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
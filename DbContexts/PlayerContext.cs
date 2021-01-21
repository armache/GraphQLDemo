using GraphQLDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace GraphQLDemo.DbContexts
{
    public class PlayerContext : DbContext
    {
        public PlayerContext()
        {

        }

        public PlayerContext(DbContextOptions<PlayerContext> options) : base(options)
        {

        }

        public DbSet<Player> Players { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=PlayersDB;Trusted_Connection=True;",
                builder => builder.EnableRetryOnFailure());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>().HasData(
                new Player
                {
                    PlayerId = Guid.NewGuid(),
                    FirstName = "Sergio",
                    LastName = "Ramos"
                },
                new Player
                {
                    PlayerId = Guid.NewGuid(),
                    FirstName = "Karim",
                    LastName = "Benzema"
                });
        }
    }
}

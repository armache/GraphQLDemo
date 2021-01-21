using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using GraphQLDemo.DbContexts;
using GraphQLDemo.GraphQL;
using GraphQLDemo.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GraphQLDemo
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<PlayerQuery>();
            services.AddSingleton<PlayerSchema>();
            services.AddSingleton<PlayerContext>();
            services.AddSingleton<DbContextOptions<PlayerContext>>();
            services.AddSingleton<IPlayerRepository, PlayerRepository>();

            services
                .AddGraphQL((options, provider) =>
                {
                    options.EnableMetrics = false;
                })
                .AddSystemTextJson(deserializerSettings => { }, serializerSettings => { })
                .AddGraphTypes(typeof(PlayerSchema));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseGraphQL<PlayerSchema>();
            app.UseGraphQLPlayground(new GraphQLPlaygroundOptions());
        }
    }
}

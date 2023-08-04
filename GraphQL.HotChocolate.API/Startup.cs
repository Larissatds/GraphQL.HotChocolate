using GraphQL.HotChocolate.API.Schema.Mutations;
using GraphQL.HotChocolate.API.Schema.Queries;
using GraphQL.HotChocolate.API.Schema.Subscriptions;

namespace GraphQL.HotChocolate.API
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddGraphQLServer()
                .AddQueryType<Query>()
                .AddMutationType<Mutation>()
                .AddSubscriptionType<Subscription>();

            services.AddGraphQLServer().AddInMemorySubscriptions();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) 
        { 
            if(env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseWebSockets();

            app.UseEndpoints(endpoints => 
            {
                endpoints.MapGraphQL();
            });
        }
    }
}

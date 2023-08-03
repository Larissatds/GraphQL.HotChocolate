using GraphQL.HotChocolate.API.Schema.Mutations;
using GraphQL.HotChocolate.API.Schema.Queries;

namespace GraphQL.HotChocolate.API
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddGraphQLServer()
                .AddQueryType<Query>()
                .AddMutationType<Mutation>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) 
        { 
            if(env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints => 
            {
                endpoints.MapGraphQL();
            });
        }
    }
}

using GraphQL.HotChocolate.API.Schema.Mutations;
using GraphQL.HotChocolate.API.Schema.Queries;
using GraphQL.HotChocolate.API.Schema.Subscriptions;
using GraphQL.HotChocolate.API.Services;
using GraphQL.HotChocolate.API.Services.Courses;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.HotChocolate.API
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddGraphQLServer()
                .AddQueryType<Query>()
                .AddMutationType<Mutation>()
                .AddSubscriptionType<Subscription>();

            services.AddGraphQLServer().AddInMemorySubscriptions();

            string connectionString = _configuration.GetConnectionString("default");
            services.AddPooledDbContextFactory<SchoolDbContext>(o => o.UseSqlite(connectionString));

            services.AddScoped<CoursesRepository>();
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

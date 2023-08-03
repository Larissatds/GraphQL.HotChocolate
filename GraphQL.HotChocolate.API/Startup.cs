namespace GraphQL.HotChocolate.API
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {

        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env) 
        { 
            if(env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
        }
    }
}

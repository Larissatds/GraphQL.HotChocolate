using GraphQL.HotChocolate.API;
using Microsoft.AspNetCore;

public class Program
{
    public static void Main(string[] args)
    {
        CreateWebHostBuilder(args).UseContentRoot(Directory.GetCurrentDirectory()).UseIISIntegration().Build().Run();
    }

    public static IWebHostBuilder CreateWebHostBuilder(string[] args) => WebHost.CreateDefaultBuilder(args).UseStartup<Startup>();  
}
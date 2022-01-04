using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Dealership.BlazorApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //_context.Database.EnsureCreated();

            CreateHostBuilder(args)
                .Build()
                .Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

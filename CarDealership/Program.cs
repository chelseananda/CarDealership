using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CarDealership
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    // Set up your app startup class (usually Startup.cs)
                    webBuilder.UseStartup<Startup>();
                })
                .ConfigureServices((context, services) =>
                {
                    // Example: configure application settings with strongly typed options
                    services.Configure<MyConfigOptions>(context.Configuration.GetSection("MyConfig"));
                    
                    // Example: adding logging
                    services.AddLogging(loggingBuilder =>
                    {
                        loggingBuilder.AddConsole();
                    });
                });
    }

    // Example of a configuration class for MyConfig
    public class MyConfigOptions
    {
        public string SomeSetting { get; set; }
    }
}

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace Backend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(cfg => cfg.UseStartup<Startup>()).ConfigureAppConfiguration(cfg => cfg.AddEnvironmentVariables()).Build().Run();
        }
    }
}
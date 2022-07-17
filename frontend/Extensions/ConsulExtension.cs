using Frontend.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Frontend.Extensions
{
    public static class ConsulExtension
    {
        private static Agent Consul { get; set; }

        private static IWebHostEnvironment Environment { get; set; }

        private static IApplicationBuilder Application { get; set; }

        public static IApplicationBuilder UseConsul(this IApplicationBuilder app, IWebHostEnvironment environment)
        {
            Application = app;

            Environment = environment;

            Consul = app.ApplicationServices.GetService<Agent>();

            var lifetime = app.ApplicationServices.GetService<IHostApplicationLifetime>();

            lifetime.ApplicationStarted.Register(OnStarted);

            lifetime.ApplicationStopping.Register(OnStopping);

            return app;
        }

        private static async void OnStarted()
        {
            var feature = Application.ServerFeatures.Get<IServerAddressesFeature>();

            foreach (var address in feature.Addresses)
            {
                var args = address.Split(':');

                if (args.Length == 3)
                {
                    await Consul.Register(Environment.ApplicationName.ToLower(), $"{args[0]}:{args[1]}", int.Parse(args[2]));
                }
            }
        }

        private static void OnStopping()
        {
        }
    }
}
using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Spectre.Console.Cli;
using WorldsCollideCli.Bootstrap;
using WorldsCollideCli.Commands.Flagset;
using WorldsCollideCli.Commands.Schema;

namespace WorldsCollideCli
{
    internal class Program
    {
        static int Main(string[] args)
        {
            var host = CreateHostBuilder(args);
            var registrar = new TypeRegistrar(host);
            var app = new CommandApp(registrar);
            app.Configure(config =>
            {
                config.AddBranch("flagset", flagset =>
                {
                    flagset.AddCommand<FlagsetAddCommand>("add");
                });
                config.AddCommand<SchemaCommand>("schema");
            });

            return app.Run(args);
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host
         .CreateDefaultBuilder(args)
         .ConfigureServices(ServiceConfiguration.Configure);
    }
}

using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NJsonSchema;
using Spectre.Console.Cli;
using WorldsCollideCli.Bootstrap;
using WorldsCollideCli.Commands.Flagset;
using WorldsCollideCli.Commands.Schema;
using WorldsCollideCli.Domain;

namespace WorldsCollideCli
{
    internal class Program
    {
        static int Main(string[] args)
        {
            var host = CreateHostBuilder(args);
            var registrar = new TypeRegistrar(host);
            var app = new CommandApp();
            app.Configure(config =>
            {
                config.AddCommand<FlagsetCommand>("flagset");
                config.AddCommand<SchemaCommand>("schema");
            });

            return app.Run(args);
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host
         .CreateDefaultBuilder(args)
         .ConfigureServices((hostContext, services) =>
         {

         });
    }
}

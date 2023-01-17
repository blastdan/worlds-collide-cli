using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Spectre.Console;
using WorldsCollideDomain.Commands;
using WorldsCollideDomain.Repositories;
using WorldsCollideInfrastructure.Handlers;
using WorldsCollideInfrastructure.Repositories;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace WorldsCollideCli.Bootstrap
{
    public static class ServiceConfiguration
    {
        public static void Configure(HostBuilderContext context, IServiceCollection services)
        {
            var yamlSerializer = new SerializerBuilder()
                                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                                .Build();

            services.AddMediatR(typeof(AddFlagset), typeof(AddFlagsetHandler));
            services.AddSingleton<IAnsiConsole>((provider) => AnsiConsole.Console);

            services.AddTransient<IFlagsetRepository, FlagsetRepository>();
            services.AddSingleton<ISerializer>((provider) =>
            {
                var yamlSerializer = new SerializerBuilder()
                                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                                .Build();

                return yamlSerializer;
            });
        }
    }
}

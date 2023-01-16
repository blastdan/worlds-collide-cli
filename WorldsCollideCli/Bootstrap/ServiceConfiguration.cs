using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Spectre.Console;
using WorldsCollideDomain.Commands;
using WorldsCollideDomain.Repositories;
using WorldsCollideInfrastructure.Handlers;
using WorldsCollideInfrastructure.Repositories;

namespace WorldsCollideCli.Bootstrap
{
    public static class ServiceConfiguration
    {
        public static void Configure(HostBuilderContext context, IServiceCollection services)
        {
            services.AddMediatR(typeof(AddFlagset), typeof(AddFlagsetHandler));
            services.AddSingleton<IAnsiConsole>((provider) => AnsiConsole.Console);

            services.AddTransient<IFlagsetRepository, FlagsetRepository>();
        }
    }
}

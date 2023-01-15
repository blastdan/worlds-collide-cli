using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Spectre.Console;
using Spectre.Console.Cli;

namespace WorldsCollideCli.Bootstrap
{
    public static class ServiceConfiguration
    {
        public static void Configure(HostBuilderContext context, IServiceCollection services)
        {
            services.AddSingleton<IAnsiConsole>((provider) => AnsiConsole.Console);
        }
    }
}

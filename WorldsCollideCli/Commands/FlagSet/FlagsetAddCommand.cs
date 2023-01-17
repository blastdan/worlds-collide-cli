using MediatR;
using Spectre.Console;
using Spectre.Console.Cli;
using WorldsCollideDomain.Commands;

namespace WorldsCollideCli.Commands.Flagset
{

    public class FlagsetAddCommand : AsyncCommand<FlagsetAddCommandSettings>
    {
        private readonly IAnsiConsole console;
        private readonly IMediator mediator;

        public FlagsetAddCommand(IAnsiConsole console, IMediator mediator)
        {
            this.console = console;
            this.mediator = mediator;
        }

        public async override Task<int> ExecuteAsync(CommandContext context, FlagsetAddCommandSettings settings)
        {
            var directory = new DirectoryInfo(settings.Location);
            var command = new AddFlagset(settings.FlagsetName, directory, new WorldsCollideDomain.Flagset());
            var newDirectory = await mediator.Send(command);
            var path = new TextPath(newDirectory.FullName);
            AnsiConsole.Write(path);

            return 0;
        }
    }
}

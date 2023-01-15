using System.Diagnostics.CodeAnalysis;
using Spectre.Console.Cli;

namespace WorldsCollideCli.Commands.Flagset
{
    public class FlagsetCommand : Command<FlagSetSettings>
    {
        public override int Execute([NotNull] CommandContext context, [NotNull] FlagSetSettings settings)
        {
            Console.WriteLine("I'm Working");

            return 0;
        }
    }
}

using System.Diagnostics.CodeAnalysis;
using Spectre.Console.Cli;

namespace WorldsCollideCli.Commands.Flagset
{
    public class FlagsetCommand : Command<FlagsetSettings>
    {
        public override int Execute([NotNull] CommandContext context, [NotNull] FlagsetSettings settings)
        {
            Console.WriteLine("I'm Working");

            return 0;
        }
    }
}

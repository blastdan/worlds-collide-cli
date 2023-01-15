using Spectre.Console.Cli;

namespace WorldsCollideCli.Commands.Flagset
{
    public class FlagSetSettings : CommandSettings
    {
        [CommandArgument(0, "[FLAGSET_LOCATION]")]
        public string FlagsetLocation { get; set; } = ".";
    }
}

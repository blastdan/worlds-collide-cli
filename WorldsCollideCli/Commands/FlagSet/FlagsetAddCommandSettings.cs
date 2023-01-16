namespace WorldsCollideCli.Commands.Flagset
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using Spectre.Console.Cli;

    public class FlagsetAddCommandSettings : CommandSettings
    {
        [CommandOption("-n|--name")]
        [Description("The name of the flagset to create. A folder will be made with this name.")]
        [Required]
        public string FlagsetName { get; set; } = string.Empty;

        [CommandOption("-l|--location")]
        [Description("The location to create the folder for the flagset.")]
        [DefaultValue(".")]
        public string Location { get; set; } = ".";
    }
}

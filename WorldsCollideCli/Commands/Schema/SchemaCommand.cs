using System.Diagnostics.CodeAnalysis;
using NJsonSchema;
using Spectre.Console;
using Spectre.Console.Cli;
using Spectre.Console.Json;

namespace WorldsCollideCli.Commands.Schema
{
    public class SchemaCommand : Command
    {
        private readonly IAnsiConsole ansiConsole;

        public SchemaCommand(IAnsiConsole ansiConsole)
        {
            this.ansiConsole = ansiConsole;
        }

        public override int Execute([NotNull] CommandContext context)
        {
            var schema = JsonSchema.FromType<WorldsCollideDomain.Flagset>();
            var schemaData = schema.ToJson();
            var json = new JsonText(schemaData);
            this.ansiConsole.Write(new Panel(json));


            return 0;
        }
    }
}

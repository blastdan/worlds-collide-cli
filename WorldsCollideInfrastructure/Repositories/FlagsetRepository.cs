using System;
using System.Threading.Tasks;
using NJsonSchema;
using WorldsCollideDomain;
using WorldsCollideDomain.Repositories;
using YamlDotNet.Serialization;

namespace WorldsCollideInfrastructure.Repositories
{
    public class FlagsetRepository : IFlagsetRepository
    {
        private readonly ISerializer yamlSerializer;

        public FlagsetRepository(ISerializer yamlSerializer)
        {
            this.yamlSerializer = yamlSerializer;
        }

        public async Task<DirectoryInfo> Create(string name, DirectoryInfo location, Flagset flagset)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException($"'{nameof(name)}' cannot be null or whitespace.", nameof(name));
            }

            if (location is null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            var flagsetPath = Path.Join(location.FullName, name);
            var flagsetConfigPath = Path.Join(flagsetPath, ".worldscollide");
            var directory = Directory.CreateDirectory(flagsetPath);
            var yaml = yamlSerializer.Serialize(flagset);
            await File.WriteAllTextAsync(flagsetConfigPath, yaml);

            return directory;
        }
    }
}

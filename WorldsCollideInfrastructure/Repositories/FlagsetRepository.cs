using System;
using System.Threading.Tasks;
using WorldsCollideDomain.Repositories;

namespace WorldsCollideInfrastructure.Repositories
{
    public class FlagsetRepository : IFlagsetRepository
    {

        public DirectoryInfo Create(string name, DirectoryInfo location)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException($"'{nameof(name)}' cannot be null or whitespace.", nameof(name));
            }

            if (location is null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            var path = Path.Join(location.FullName, name);
            var directory = Directory.CreateDirectory(path);
        }
    }
}

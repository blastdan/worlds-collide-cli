using MediatR;

namespace WorldsCollideDomain.Commands
{

    public class AddFlagset : IRequest<DirectoryInfo>
    {
        /// <summary>
        /// Creates a new flagset
        /// </summary>
        /// <param name="name">Name of the flagset to save</param>
        /// <param name="location">The location to save the flagset</param>
        /// <param name="flagset">The flagset that should be saved to that location</param>
        public AddFlagset(string name, DirectoryInfo location, Flagset flagset)
        {
            this.Name = name;
            this.Location = location;
            this.Flagset = flagset;
        }

        public string Name { get; set; }
        public DirectoryInfo Location { get; set; }
        public Flagset Flagset { get; }
    }
}

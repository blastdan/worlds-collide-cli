using System;
using MediatR;
using WorldsCollideDomain.Commands;
using WorldsCollideDomain.Repositories;

namespace WorldsCollideInfrastructure.Handlers
{
    public class AddFlagsetHandler : IRequestHandler<AddFlagset, DirectoryInfo>
    {
        private readonly IFlagsetRepository flagsetRepository;

        public AddFlagsetHandler(IFlagsetRepository flagsetRepository)
        {
            this.flagsetRepository = flagsetRepository;
        }

        public async Task<DirectoryInfo> Handle(AddFlagset request, CancellationToken cancellationToken)
        {
            return flagsetRepository.Create(request.Name, request.Location);
        }
    }
}

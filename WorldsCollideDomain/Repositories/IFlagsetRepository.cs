namespace WorldsCollideDomain.Repositories
{
    public interface IFlagsetRepository
    {
        Task<DirectoryInfo> Create(string name, DirectoryInfo location, Flagset flagset);
    }
}

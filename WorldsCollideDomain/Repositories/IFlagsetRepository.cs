namespace WorldsCollideDomain.Repositories
{
    public interface IFlagsetRepository
    {
        DirectoryInfo Create(string name, DirectoryInfo location);
    }
}

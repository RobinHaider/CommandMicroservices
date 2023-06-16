using PlatformService.Models;

namespace PlatformService.Data;

public interface IPlatformRepository
{
    Task<IEnumerable<Platform>> GetAllPlatforms();
    Task<Platform?> GetPlatformById(int id);
    void CreatePlatform(Platform platform);
    Task<bool> SaveChangesAsync();
}

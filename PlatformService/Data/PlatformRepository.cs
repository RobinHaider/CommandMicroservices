using Microsoft.EntityFrameworkCore;
using PlatformService.Models;

namespace PlatformService.Data;

public class PlatformRepository : IPlatformRepository
{
    private readonly AppDbContext _context;
    public PlatformRepository(AppDbContext context)
    {
        _context = context;
    }
    public void CreatePlatform(Platform platform)
    {
        if (platform == null)
        {
            throw new ArgumentNullException(nameof(platform));
        }

        _context.Platforms.Add(platform);
    }

    public async Task<IEnumerable<Platform>> GetAllPlatforms()
    {
        return await _context.Platforms.ToListAsync();
    }

    public async Task<Platform?> GetPlatformById(int id)
    {
        return await _context.Platforms.FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<bool> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }
}

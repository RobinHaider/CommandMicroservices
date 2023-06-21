using PlatformService.Models;

namespace PlatformService.Data;

public static class PrepDb
{
    public static void SeedData(IApplicationBuilder app)
    {
        using var serviceScope = app.ApplicationServices.CreateScope();
        var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

        SeedPlatforms(context);
    }

    private static void SeedPlatforms(AppDbContext context)
    {
       if(!context.Platforms.Any())
        {
            Console.WriteLine("--> Seeding data...");

            context.Platforms.AddRange(
                               new Platform() { Name = "Dot Net", Publisher = "Microsoft", Cost = "Free" },
                               new Platform() { Name = "SQL Server Express", Publisher = "Microsoft", Cost = "Free" },
                               new Platform() { Name = "Kubernetes", Publisher = "Cloud Native Computing Foundation", Cost = "Free" }
                                                                        );

            context.SaveChanges();
        }
        else
        {
            Console.WriteLine("--> We already have data");
        }
    }
}

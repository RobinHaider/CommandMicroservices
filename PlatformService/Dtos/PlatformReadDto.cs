namespace PlatformService.Dtos;

public class PlatformReadDto
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string Publisher { get; set; } = null!;

    public string Cost { get; set; } = null!;
}

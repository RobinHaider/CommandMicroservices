using System.ComponentModel.DataAnnotations;

namespace PlatformService.Dtos;

public class PlatformCreateDto
{
    [Required]
    public string Name { get; set; } = null!;

    [Required]
    public string Publisher { get; set; } = null!;

    [Required]
    public string Cost { get; set; } = null!;
}

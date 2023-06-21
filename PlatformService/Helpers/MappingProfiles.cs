using AutoMapper;

namespace PlatformService.Helpers;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Models.Platform, Dtos.PlatformReadDto>();
        CreateMap<Dtos.PlatformCreateDto, Models.Platform>();
    }
}

using AutoMapper;
using Rakheoana.Dtos;
using Rakheoana.Models;

namespace Rakheoana.Profiles
{
    public class PlatformProfile : Profile
    {
        public PlatformProfile()
        {
            // Source -> Target
            CreateMap<Platform, PlatformReadDto>(); 

            CreateMap<PlatformCreateDto, Platform>();
        }
    
    }
    

}
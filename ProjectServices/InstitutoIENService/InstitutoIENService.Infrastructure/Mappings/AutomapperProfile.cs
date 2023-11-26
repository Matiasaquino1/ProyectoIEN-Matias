using AutoMapper;
using InstitutoIENService.Core.DTOs;
using InstitutoIENService.Core.Entities;

namespace InstitutoIENService.Infrastructure.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Administrative, AdministrativeDto>();
            CreateMap<AdministrativeDto, Administrative>();

            CreateMap<Country, CountryDto>();
            CreateMap<CountryDto, Country>();
        }
    }
}

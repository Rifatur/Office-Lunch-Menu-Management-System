using AutoMapper;

using OfficeLunchMenuSystem.Application.Features.Menu.DTOs;
using OfficeLunchMenuSystem.Domain.Entities;

namespace OfficeLunchMenuSystem.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LunchMenu, LunchMenuDTO>().ReverseMap();
        }
    }
}

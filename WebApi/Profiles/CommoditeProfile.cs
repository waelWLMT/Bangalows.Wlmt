using AutoMapper;
using Core.Dtos;
using Core.Models;

namespace WebApi.Profiles
{
    public class CommoditeProfile : Profile
    {
        public CommoditeProfile()
        {
            CreateMap<Comodite, CommoditeReadDto>();
        }
    }
}

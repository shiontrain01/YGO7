using AirplaneProject.Application.Bases;
using AirplaneProject.Domain.Bases;
using AirplaneProject.Domain.Models;
using AutoMapper;

namespace AirplaneProject.Application.AutoMapper
{
    public class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile()
        {
            CreateMap<Entity, EntityDto>();
        }
    }
}

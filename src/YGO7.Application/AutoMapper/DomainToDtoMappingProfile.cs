using YGO7.Application.Bases;
using YGO7.Domain.Bases;
using YGO7.Domain.Models;
using AutoMapper;

namespace YGO7.Application.AutoMapper
{
    public class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile()
        {
            CreateMap<Entity, EntityDto>();
        }
    }
}

using YGO7.Application.Bases;
using YGO7.Domain.Bases;
using YGO7.Domain.Models;
using AutoMapper;
using YGO7.Application.Dtos;

namespace YGO7.Application.AutoMapper
{
    public class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile()
        {
            CreateMap<Entity, EntityDto>();
            
            
            CreateMap<Card, CompleteCardInformationDto>();
            CreateMap<CompleteCardInformation, CompleteCardInformationDto>();
            CreateMap<Monster, CompleteCardInformationDto>();
            CreateMap<FusionMonster, CompleteCardInformationDto>();
            CreateMap<LinkMonster, CompleteCardInformationDto>();
            CreateMap<XyzMonster, CompleteCardInformationDto>();
            CreateMap<SynchroMonster, CompleteCardInformationDto>();
            CreateMap<TrapCard, CompleteCardInformationDto>();
            CreateMap<SpellCard, CompleteCardInformationDto>();
            CreateMap<FusionMonster, FusionMonsterDto>();
            CreateMap<LinkMonster, LinkMonsterDto>();
            CreateMap<XyzMonster, XyzMonsterDto>();
            CreateMap<SynchroMonster, SynchroMonsterDto>();
            CreateMap<TrapCard, TrapCardDto>();
            CreateMap<SpellCard, SpellCardDto>();

        }
    }
}

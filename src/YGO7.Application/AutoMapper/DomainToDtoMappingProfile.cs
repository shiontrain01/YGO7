using YGO7.Application.Bases;
using YGO7.Domain.Bases;
using YGO7.Domain.Models;
using AutoMapper;
using YGO7.Application.Dtos;
using YGO7.Domain.Models.MonsterClass;

namespace YGO7.Application.AutoMapper
{
    public class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile()
        {
            CreateMap<Entity, EntityDto>();
            
            
            CreateMap<Card, EffectMonsterDto>();
            CreateMap<FlipMonster, EffectMonsterDto>();
            CreateMap<GeminiMonster, EffectMonsterDto>();
            CreateMap<SpiritMonster, EffectMonsterDto>();
            CreateMap<TokenMonster, EffectMonsterDto>();
            CreateMap<UnionMonster, EffectMonsterDto>();
            CreateMap<FusionMonster, FusionMonsterDto>();
            CreateMap<LinkMonster, LinkMonsterDto>();
            CreateMap<PendulumMonster, PendulumMonsterDto>();
            CreateMap<RitualMonster, RitualMonsterDto>();
            CreateMap<XyzMonster, XyzMonsterDto>();
            CreateMap<SynchroMonster, SynchroMonsterDto>();
            CreateMap<TrapCard, TrapCardDto>();
            CreateMap<SpellCard, SpellCardDto>();

        }
    }
}

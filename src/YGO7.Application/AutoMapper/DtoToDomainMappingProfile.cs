using YGO7.Domain.Bases;
using YGO7.Domain.Models;
using AutoMapper;
using YGO7.Application.Dtos;
using YGO7.Domain.Models.MonsterClass;

namespace YGO7.Application.AutoMapper
{
	public class DtoToDomainMappingProfile : Profile
    {
		public DtoToDomainMappingProfile()
		{

			CreateMap<EffectMonsterDto , FlipMonster >();
			CreateMap<EffectMonsterDto,GeminiMonster >();
			CreateMap<EffectMonsterDto,SpiritMonster >();
			CreateMap<EffectMonsterDto,TokenMonster >();
			CreateMap<EffectMonsterDto,UnionMonster >();
			CreateMap<FusionMonsterDto,FusionMonster >();
			CreateMap<LinkMonsterDto,LinkMonster >();
			CreateMap<PendulumMonsterDto,PendulumMonster >();
			CreateMap<RitualMonsterDto,RitualMonster >();
			CreateMap<XyzMonsterDto,XyzMonster >();
			CreateMap<SynchroMonsterDto,SynchroMonster >();
			CreateMap<TrapCardDto,TrapCard >();
			CreateMap<SpellCardDto,SpellCard >();
        }
    }
}

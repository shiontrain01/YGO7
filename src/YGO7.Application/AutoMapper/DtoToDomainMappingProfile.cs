using YGO7.Domain.Bases;
using YGO7.Domain.Models;
using AutoMapper;
using YGO7.Application.Dtos;

namespace YGO7.Application.AutoMapper
{
	public class DtoToDomainMappingProfile : Profile
    {
		public DtoToDomainMappingProfile()
		{
			CreateMap<CompleteCardInformationDto, CompleteCardInformation>();
			CreateMap<CompleteCardInformationDto, Card>();
			CreateMap<CompleteCardInformationDto,Monster >();
			CreateMap<CompleteCardInformationDto,FusionMonster >();
			CreateMap<CompleteCardInformationDto,LinkMonster >();
			CreateMap<CompleteCardInformationDto,RitualMonster >();
			CreateMap<CompleteCardInformationDto,XyzMonster >();
			CreateMap<CompleteCardInformationDto,SynchroMonster >();
			CreateMap<CompleteCardInformationDto,TrapCard >();
			CreateMap<CompleteCardInformationDto,SpellCard >();
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

using System.Collections.Generic;
using YGO7.Application.Bases;
using YGO7.Domain.Enums;

namespace YGO7.Application.Dtos
{
    public class CompleteCardInformationDto : EntityDto
    {
        //Campos referentes a Card
        public string? CardId { get; set; }
        
        public string? CardName { get; set; }
        
        public string? CardAbility { get; set; }
        
        public CardTypeEnum? CardType { get; set; }
        
        public short? CardEffectSpeed { get; set; }
        
        public bool? HaveEffect { get; set; }
        
        public ElementEnum? CardElement { get; set; }
        
        //Campos referentes a monstro
        
        public short? CardAttack { get; set; }

        public short? CardDefense { get; set; }
        
        public MonsterTypeEnum? MonsterType { get; set; }
        
        public MonsterCardClassEnum? MonsterCardClass { get; set; }
        
        public string? MonsterSecondaryEffect { get; set; }
        
        public short? Stars { get; set; }
        
        public short? PendulumScale { get; set; }
        
        public string? PendulumEffect { get; set; }
        
        public string? RitualSummonRequirement { get; set; }
        
        public short? RitualLevelMin { get; set; }
        
        public List<string>? MonsterNeededRitual { get; set; }
        
        public bool?  TunerMonster { get; set; }
        
        public List<MonsterSecondarySpecializationEnum>? MonsterSecondarySpecialization { get; set; }
        
        //Campos referentes a fusão
        
        public string? FusionSummonRequirement { get; set; }

        public List<string>? MonsterNeededFusion { get; set; }
        
        //Campos referentes a xyz

        public string? XyzSummonRequirement { get; set; }

        public short? XyzRank { get; set; }

        public short? MaterialsNeededMMin { get; set; }
        
        public short? MaterialsNeededMax { get; set; }
        
        //Campos referentes a Synchro

        public string? SynchroSummonRequirement { get; set; }
        
        public List<string>? MonstersNeededSynchro { get; set; }

        public List<string>? TunersMonstersNeeded { get; set; }

        public short? TunersNeededMin { get; set; }

        public short? TunersNeededMax { get; set; }

        // Campos referentes a Link
        
        public string? LinkSummonRequirement { get; set; }
        
        public List<string>? MonstersNeededLink { get; set; }

        public short? LinkGrade { get; set; }
        
        public bool? ArrowSuperiorEsquerdo { get; set; }
        
        public bool? ArrowSuperiorCentro { get; set; }
        
        public bool? ArrowSuperiorDireito { get; set; }
        
        public bool? ArrowCentralEsquerdo { get; set; }
        
        public bool? ArrowCentralDireito { get; set; }
        
        public bool? ArrowInferiorEsquerdo { get; set; }
        
        public bool? ArrowInferiorCentral { get; set; }
        
        public bool? ArrowInferiorDireito { get; set; }
        
        // Campos referentes a traps
        
        public TrapCardClassEnum? TrapCardClass { get; set; }
        
        // Campos referentes a spell
        
        public SpellCardClassEnum? SpellCardClass  { get; set; }
        
        //Campos Globais
        
        public short? MonstersNeededMax { get; set; }
        
        public short? MonstersNeededMin { get; set; }
        
    }
}
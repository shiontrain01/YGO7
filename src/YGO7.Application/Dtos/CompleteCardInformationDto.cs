using System;
using System.Collections.Generic;
using YGO7.Application.Bases;
using YGO7.Domain.Enums;

namespace YGO7.Application.Dtos
{
    public class CompleteCardInformationDto : EntityDto
    {
      
        public string CardId { get; set; }
        
        public string CardName { get; set; }
        
        public string CardAbility { get; set; }
        
        public CardTypeEnum CardType { get; set; }
        
        public short CardEffectSpeed { get; set; }
        
        public bool HaveEffect { get; set; }
        
        public ElementEnum CardElement { get; set; }
        
        public short CardAttack { get; set; }

        public short CardDefense { get; set; }
        
        public MonsterTypeEnum MonsterType { get; set; }
        
        public MonsterCardClassEnum MonsterCardClass { get; set; }
        
        public string MonsterSecondaryEffect { get; set; }
        
        public short Stars { get; set; }
        
        public PendulumMonsterDto  PendulumMonster { get; set; }
        
        public bool  TunerMonster { get; set; }
        
        public List<MonsterSecondarySpecializationEnum> MonsterSecondarySpecialization { get; set; }
        
        public string FusionSummonRequirement { get; set; }

        
        public List<String> MonsterNeededFusion { get; set; }
        
        public string XyzSummonRequirement { get; set; }

        public short XyzRank { get; set; }

        public short MaterialsNeededMMin { get; set; }
        
        public short MaterialsNeededMax { get; set; }
        
        public string SynchroSummonRequirement { get; set; }
        
        public short TunersNeededMin { get; set; }
        
        public short TunersNeededMax { get; set; }
        
        public short MonstersNeededMin { get; set; }
        
        public short MonstersNeededMax { get; set; }
        
        public TrapCardClassEnum TrapCardClass { get; set; }
        
        public string RitualSummonRequirement { get; set; }
        
        public short RitualLevelMin { get; set; }
        
        public string LinkSummonRequirement { get; set; }

        public short LinkGrade { get; set; }
        
        public bool ArrowSuperiorEsquerdo { get; set; }
        
        public bool ArrowSuperiorCentro { get; set; }
        
        public bool ArrowSuperiorDireito { get; set; }
        
        public bool ArrowCentralEsquerdo { get; set; }
        
        public bool ArrowCentralDireito { get; set; }
        
        public bool ArrowInferiorEsquerdo { get; set; }
        
        public bool ArrowInferiorCentral { get; set; }
        
        public bool ArrowInferiorDireito { get; set; }
    }
}
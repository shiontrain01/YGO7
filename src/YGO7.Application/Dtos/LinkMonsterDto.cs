using System;
using System.Collections.Generic;
using YGO7.Domain.Enums;

namespace YGO7.Application.Dtos
{
    public class LinkMonsterDto
    {
        public string CardId { get; set; }
        
        public string CardName { get; set; }
        
        public string CardAbility { get; set; }
        
        public CardTypeEnum CardType { get; set; }
        
        public short CardEffectSpeed { get; set; }
        
        public Boolean HaveEffect { get; set; }
        
        public ElementEnum CardElement { get; set; }
        
        public short CardAttack { get; set; }

        public short CardDefense { get; set; }
        
        public MonsterTypeEnum MonsterType { get; set; }
        
        public List<MonsterCardClassEnum> MonsterCardClass { get; set; }
        
        public string LinkSummonRequirement { get; set; }

        public short LinkGrade { get; set; }

        public short MonstersNeededMin { get; set; }
        
        public short MonstersNeededMax { get; set; }
        
        public Boolean ArrowSuperiorEsquerdo { get; set; }
        
        public Boolean ArrowSuperiorCentro { get; set; }
        
        public Boolean ArrowSuperiorDireito { get; set; }
        
        public Boolean ArrowCentralEsquerdo { get; set; }
        
        public Boolean ArrowCentralDireito { get; set; }
        
        public Boolean ArrowInferiorEsquerdo { get; set; }
        
        public Boolean ArrowInferiorCentral { get; set; }
        
        public Boolean ArrowInferiorDireito { get; set; }
    }
}
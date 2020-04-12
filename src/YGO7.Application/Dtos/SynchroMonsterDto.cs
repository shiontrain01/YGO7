using System;
using System.Collections.Generic;
using YGO7.Domain.Enums;

namespace YGO7.Application.Dtos
{
    public class SynchroMonsterDto
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
        
        public string SynchroSummonRequirement { get; set; }

        public short Stars { get; set; }
        
        public short TunersNeededMin { get; set; }
        
        public short TunersNeededMax { get; set; }
        
        public short MonstersNeededMin { get; set; }
        
        public short MonstersNeededMax { get; set; }
    }
}
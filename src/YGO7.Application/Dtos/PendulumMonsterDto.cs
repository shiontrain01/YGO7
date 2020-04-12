﻿using System;
using System.Collections.Generic;
using YGO7.Domain.Enums;

namespace YGO7.Application.Dtos
{
    public class PendulumMonsterDto
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
        
        public string MonsterSecondaryCardAbility { get; set; }
        
        public short PendulumScale { get; set; }

        public short Stars { get; set; }
        
        public string PendulumEffect { get; set; }
    }
}
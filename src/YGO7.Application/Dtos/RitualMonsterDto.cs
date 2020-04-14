using System;
using System.Collections.Generic;
using YGO7.Domain.Enums;

namespace YGO7.Application.Dtos
{
    public class RitualMonsterDto
    {
        public string RitualSummonRequirement { get; set; }
        
        public short RitualLevelMin { get; set; }
        
        public List<string> MonsterNeededRitual { get; set; }

    }
}
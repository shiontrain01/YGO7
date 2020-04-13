using System;
using System.Collections.Generic;
using YGO7.Domain.Enums;

namespace YGO7.Application.Dtos
{
    public class PendulumMonsterDto
    {

        public string MonsterSecondaryCardAbility { get; set; }
        
        public short PendulumScale { get; set; }

        public short Stars { get; set; }
        
        public string PendulumEffect { get; set; }
    }
}
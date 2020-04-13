using System;
using YGO7.Domain.Enums;

namespace YGO7.Application.Dtos
{
    public class TrapCardDto
    {
        public string CardId { get; set; }
        
        public string CardName { get; set; }
        
        public string CardAbility { get; set; }
        
        public CardTypeEnum CardType { get; set; }
        
        public short CardEffectSpeed { get; set; }
        
        public bool HaveEffect { get; set; }
        
        public ElementEnum CardElement { get; set; }
        
        public TrapCardClassEnum TrapCardClass { get; set; }


    }
}
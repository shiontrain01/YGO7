using System;
using System.Collections.Generic;
using YGO7.Domain.Enums;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using YGO7.Domain.Bases;

namespace YGO7.Domain.Models
{
    public class Card : Entity
    {
        [BsonElement("CardId")]
        public string CardId { get; set; }
        
        [BsonElement("CardName")]
        public string CardName { get; set; }
        
        [BsonElement("CardAbility")]
        public string CardAbility { get; set; }
        
        [BsonElement("CardType")]
        public CardTypeEnum CardType { get; set; }
        
        [BsonElement("CardEffectSpeed")]
        public short CardEffectSpeed { get; set; }
        
        [BsonElement("HaveEffect")]
        public Boolean HaveEffect { get; set; }
        
        [BsonElement("CardElement")]
        public ElementEnum CardElement { get; set; }
        
      
    }
}
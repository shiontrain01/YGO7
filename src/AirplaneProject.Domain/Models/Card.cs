using System;
using System.Collections.Generic;
using AirplaneProject.Domain.Enums;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AirplaneProject.Domain.Models
{
    public class Card
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        
        [BsonElement("CardId")]
        public long CardId { get; set; }
        
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

        [BsonElement("MonsterType")]
        public List<MonsterTypeEnum> MonsterType { get; set; }
  
        [BsonElement("CardElement")]
        public ElementEnum CardElement { get; set; }
    }
}
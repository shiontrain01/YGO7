using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace YGO7.Domain.Models
{
    public class RitualMonster : Monster
    {

        [BsonElement("RitualSummonRequirement")]
        public string RitualSummonRequirement { get; set; }
        
        [BsonElement("RitualLevelMin")]
        public short RitualLevelMin { get; set; }
        
        [BsonElement("MonsterNeededRitual")]
        public List<string> MonsterNeededRitual { get; set; }

    }
}
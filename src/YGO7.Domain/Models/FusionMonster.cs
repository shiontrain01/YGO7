using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace YGO7.Domain.Models
{
    public class FusionMonster : Monster
    {
        [BsonElement("FusionSummonRequirement")]
        public string FusionSummonRequirement { get; set; }

        [BsonElement("Stars")]
        public short Stars { get; set; }
        
        [BsonElement("MonsterNeededFusion")]
        public List<String> MonsterNeededFusion { get; set; }
        

    }
}
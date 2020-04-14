using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace YGO7.Domain.Models
{
    public class FusionMonster : Monster
    {
        [BsonElement("FusionSummonRequirement")]
        public string FusionSummonRequirement { get; set; }

        [BsonElement("MonsterNeededFusion")]
        public List<string> MonsterNeededFusion { get; set; }
        

    }
}
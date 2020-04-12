using System.Collections.Generic;
using YGO7.Domain.Enums;
using MongoDB.Bson.Serialization.Attributes;

namespace YGO7.Domain.Models
{
    public class Monster : Card
    {
        [BsonElement("CardAttack")]
        public short CardAttack { get; set; }

        [BsonElement("CardDefense")]
        public short CardDefense { get; set; }
        
        [BsonElement("MonsterType")]
        public MonsterTypeEnum MonsterType { get; set; }
        
        [BsonElement("MonsterCardClass")]
        public List<MonsterCardClassEnum> MonsterCardClass { get; set; }
    }
}
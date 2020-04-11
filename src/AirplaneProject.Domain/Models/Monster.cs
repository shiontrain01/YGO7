using AirplaneProject.Domain.Enums;
using MongoDB.Bson.Serialization.Attributes;

namespace AirplaneProject.Domain.Models
{
    public class Monster : Card
    {
        [BsonElement("CardAttack")]
        public short CardAttack { get; set; }

        [BsonElement("CardDefense")]
        public short CardDefense { get; set; }
        
        [BsonElement("MonsterCardClass")]
        public MonsterCardClassEnum MonsterCardClass { get; set; }
    }
}
using MongoDB.Bson.Serialization.Attributes;

namespace YGO7.Domain.Models
{
    public class RitualMonster : Monster
    {
        [BsonElement("Stars")]
        public short Stars { get; set; }
        
        [BsonElement("RitualSummonRequirement")]
        public string RitualSummonRequirement { get; set; }
        
        [BsonElement("RitualLevelMin")]
        public short RitualLevelMin { get; set; }
    }
}
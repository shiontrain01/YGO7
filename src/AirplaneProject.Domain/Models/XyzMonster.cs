using MongoDB.Bson.Serialization.Attributes;

namespace AirplaneProject.Domain.Models
{
    public class XyzMonster : Monster
    {
        [BsonElement("XyzSummonRequirement")]
        public string XyzSummonRequirement { get; set; }

        [BsonElement("XyzRank")]
        public short XyzRank { get; set; }

        [BsonElement("MaterialsNeededMin")]
        public short MaterialsNeededMMin { get; set; }
        
        [BsonElement("MaterialsNeededMax")]
        public short MaterialsNeededMax { get; set; }
    }
}
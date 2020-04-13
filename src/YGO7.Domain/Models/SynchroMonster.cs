using MongoDB.Bson.Serialization.Attributes;

namespace YGO7.Domain.Models
{
    public class SynchroMonster : Monster
    {
        [BsonElement("SynchroSummonRequirement")]
        public string SynchroSummonRequirement { get; set; }

        [BsonElement("TunersNeededMin")]
        public short TunersNeededMin { get; set; }
        
        [BsonElement("TunersNeededMax")]
        public short TunersNeededMax { get; set; }
        
        [BsonElement("MonstersNeededMin")]
        public short MonstersNeededMin { get; set; }
        
        [BsonElement("MonstersNeededMax")]
        public short MonstersNeededMax { get; set; }
    }
}
using MongoDB.Bson.Serialization.Attributes;

namespace YGO7.Domain.Models
{
    public class LinkMonster : Monster
    {
        [BsonElement("LinkSummonRequirement")]
        public string LinkSummonRequirement { get; set; }

        [BsonElement("LinkGrade")]
        public short LinkGrade { get; set; }

        [BsonElement("MonstersNeededMin")]
        public short MonstersNeededMin { get; set; }
        
        [BsonElement("MonstersNeededMax")]
        public short MonstersNeededMax { get; set; }
    }
}
using MongoDB.Bson.Serialization.Attributes;

namespace YGO7.Domain.Models.MonsterClass
{
    public class UnionMonster : Monster
    {
        [BsonElement("UnionEffect")]
        public string UnionEffect { get; set; }
        
        [BsonElement("Stars")]
        public short Stars { get; set; }
    }
}
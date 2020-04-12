using MongoDB.Bson.Serialization.Attributes;

namespace YGO7.Domain.Models.MonsterClass
{
    public class FlipMonster : Monster
    {
        [BsonElement("FlipEffect")]
        public string FlipEffect { get; set; }
    }
}
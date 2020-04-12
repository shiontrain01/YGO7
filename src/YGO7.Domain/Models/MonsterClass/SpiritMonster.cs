using MongoDB.Bson.Serialization.Attributes;

namespace YGO7.Domain.Models.MonsterClass
{
    public class SpiritMonster : Monster
    {
        [BsonElement("SpiritEffect")]
        public string SpiritEffect { get; set; }
    }
}
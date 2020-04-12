using MongoDB.Bson.Serialization.Attributes;

namespace YGO7.Domain.Models.MonsterClass
{
    public class GeminiMonster : Monster
    {
        [BsonElement("GeminiEffect")]
        public string GeminiEffect { get; set; }
    }
}
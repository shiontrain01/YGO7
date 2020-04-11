using MongoDB.Bson.Serialization.Attributes;

namespace AirplaneProject.Domain.Models.MonsterClass
{
    public class GeminiMonster : Monster
    {
        [BsonElement("GeminiEffect")]
        public string GeminiEffect { get; set; }
    }
}
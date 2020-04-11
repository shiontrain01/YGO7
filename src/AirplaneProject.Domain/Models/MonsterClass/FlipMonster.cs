using MongoDB.Bson.Serialization.Attributes;

namespace AirplaneProject.Domain.Models.MonsterClass
{
    public class FlipMonster : Monster
    {
        [BsonElement("FlipEffect")]
        public string FlipEffect { get; set; }
    }
}
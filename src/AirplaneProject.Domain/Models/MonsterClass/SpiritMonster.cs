using MongoDB.Bson.Serialization.Attributes;

namespace AirplaneProject.Domain.Models.MonsterClass
{
    public class SpiritMonster : Monster
    {
        [BsonElement("SpiritEffect")]
        public string SpiritEffect { get; set; }
    }
}
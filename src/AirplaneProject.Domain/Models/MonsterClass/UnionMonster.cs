using MongoDB.Bson.Serialization.Attributes;

namespace AirplaneProject.Domain.Models.MonsterClass
{
    public class UnionMonster : Monster
    {
        [BsonElement("UnionEffect")]
        public string UnionEffect { get; set; }
    }
}
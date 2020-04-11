using MongoDB.Bson.Serialization.Attributes;

namespace AirplaneProject.Domain.Models.MonsterClass
{
    public class TokenMonster : Monster
    {
        [BsonElement("TokenEffect")]
        public string TokenEffect { get; set; }
    }
}
using MongoDB.Bson.Serialization.Attributes;

namespace YGO7.Domain.Models.MonsterClass
{
    public class TokenMonster : Monster
    {
        [BsonElement("TokenEffect")]
        public string TokenEffect { get; set; }
        
        [BsonElement("Stars")]
        public short Stars { get; set; }
    }
}
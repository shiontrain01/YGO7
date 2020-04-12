using MongoDB.Bson.Serialization.Attributes;

namespace YGO7.Domain.Models
{
    public class PendulumMonster : Monster
    {
        [BsonElement("PendulumScale")]
        public short PendulumScale { get; set; }

        [BsonElement("Stars")]
        public short Stars { get; set; }
        
        [BsonElement("PendulumEffect")]
        public string PendulumEffect { get; set; }
    }
}
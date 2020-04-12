using YGO7.Domain.Enums;
using MongoDB.Bson.Serialization.Attributes;

namespace YGO7.Domain.Models
{
    public class TrapCard : Card
    {
        [BsonElement("TrapCardClass")]
        public TrapCardClassEnum TrapCardClass { get; set; }

    }
}
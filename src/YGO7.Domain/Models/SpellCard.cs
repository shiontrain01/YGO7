using YGO7.Domain.Enums;
using MongoDB.Bson.Serialization.Attributes;

namespace YGO7.Domain.Models
{
    public class SpellCard : Card
    {
         
        [BsonElement("SpellCardClass")]
        public SpellCardClassEnum SpellCardClass { get; set; }

    }
}
using AirplaneProject.Domain.Enums;
using MongoDB.Bson.Serialization.Attributes;

namespace AirplaneProject.Domain.Models
{
    public class SpellCard : Card
    {
         
        [BsonElement("SpellCardClass")]
        public SpellCardClassEnum SpellCardClass { get; set; }

    }
}
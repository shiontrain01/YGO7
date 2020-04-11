using AirplaneProject.Domain.Enums;
using MongoDB.Bson.Serialization.Attributes;

namespace AirplaneProject.Domain.Models
{
    public class TrapCard : Card
    {
        [BsonElement("TrapCardClass")]
        public TrapCardClassEnum TrapCardClass { get; set; }

    }
}
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace YGO7.Domain.Models
{
    public class MonsterSecondaryEffect
    {
        [BsonElement("SecondaryEffect")]
        public string SecondaryEffect { get; set; }

    }
}
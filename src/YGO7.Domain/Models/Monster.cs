using System.Collections.Generic;
using YGO7.Domain.Enums;
using MongoDB.Bson.Serialization.Attributes;

namespace YGO7.Domain.Models
{
    public class Monster : Card
    {
        [BsonElement("CardAttack")]
        public short CardAttack { get; set; }

        [BsonElement("CardDefense")]
        public short CardDefense { get; set; }
        
        [BsonElement("MonsterType")]
        public MonsterTypeEnum MonsterType { get; set; }
        
        [BsonElement("MonsterCardClass")]
        public MonsterCardClassEnum MonsterCardClass { get; set; }
        
        [BsonElement("MonsterSecondaryEffect")]
        public string MonsterSecondaryEffect { get; set; }
        
        [BsonElement("Stars")]
        public short Stars { get; set; }
        
        [BsonElement("PendulumScale")]
        public short PendulumScale { get; set; }
        
        [BsonElement("PendulumEffect")]
        public string PendulumEffect { get; set; }
        
        [BsonElement("RitualSummonRequirement")]
        public string RitualSummonRequirement { get; set; }
        
        [BsonElement("RitualLevelMin")]
        public short RitualLevelMin { get; set; }
        
        [BsonElement("MonsterNeededRitual")]
        public List<string> MonsterNeededRitual { get; set; }
        
        [BsonElement("TunerMonster")]
        public bool  TunerMonster { get; set; }
        
        [BsonElement("MonsterSecondarySpecialization")]
        public List<MonsterSecondarySpecializationEnum> MonsterSecondarySpecialization { get; set; }
    }
}
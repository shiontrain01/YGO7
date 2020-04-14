#nullable enable
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using YGO7.Domain.Bases;
using YGO7.Domain.Enums;

namespace YGO7.Domain.Models
{
    public class CompleteCardInformation  : Entity
    {
        //Informacoes de carta
        [BsonElement("CardId")]
        public string? CardId { get; set; }
        
        [BsonElement("CardName")]
        public string CardName { get; set; }
        
        [BsonElement("CardAbility")]
        public string? CardAbility { get; set; }
        
        [BsonElement("CardType")]
        public CardTypeEnum CardType { get; set; }
        
        [BsonElement("CardEffectSpeed")]
        public short? CardEffectSpeed { get; set; }
        
        [BsonElement("HaveEffect")]
        public bool HaveEffect { get; set; }
        
        [BsonElement("CardElement")]
        public ElementEnum CardElement { get; set; }
        
        //informacoes de spell
        
        [BsonElement("SpellCardClass")]
        public SpellCardClassEnum? SpellCardClass { get; set; }
        
        //informacoes de trap
        
        [BsonElement("TrapCardClass")]
        public TrapCardClassEnum? TrapCardClass { get; set; }
        
        //informacoes de monstro
        
        [BsonElement("CardAttack")]
        public short? CardAttack { get; set; }

        [BsonElement("CardDefense")]
        public short? CardDefense { get; set; }
        
        [BsonElement("MonsterType")]
        public MonsterTypeEnum? MonsterType { get; set; }
        
        [BsonElement("MonsterCardClass")]
        public MonsterCardClassEnum? MonsterCardClass { get; set; }
        
        [BsonElement("MonsterSecondaryEffect")]
        public string? MonsterSecondaryEffect { get; set; }
        
        [BsonElement("Stars")]
        public short? Stars { get; set; }
        
        [BsonElement("PendulumMonster")]
        public PendulumMonster?  PendulumMonster { get; set; }
        
        [BsonElement("RitualMonster")]
        public RitualMonster?  RitualMonster { get; set; }
        
        [BsonElement("TunerMonster")]
        public bool?  TunerMonster { get; set; }
        
        [BsonElement("MonsterSecondarySpecialization")]
        public List<MonsterSecondarySpecializationEnum>? MonsterSecondarySpecialization { get; set; }
        
        //informacoes de fusao
        
        [BsonElement("FusionSummonRequirement")]
        public string? FusionSummonRequirement { get; set; }

        [BsonElement("MonsterNeededFusion")]
        public List<string>? MonsterNeededFusion { get; set; }
        
        //informacoes de shynchro
        
        [BsonElement("SynchroSummonRequirement")]
        public string? SynchroSummonRequirement { get; set; }

        [BsonElement("TunersMonstersNeeded")]
        public List<string>? TunersMonstersNeeded { get; set; }
        
        [BsonElement("MonstersNeededSynchro")]
        public List<string>? MonstersNeededSynchro { get; set; }
        
        [BsonElement("TunersNeededMin")]
        public short? TunersNeededMin { get; set; }
        
        [BsonElement("TunersNeededMax")]
        public short? TunersNeededMax { get; set; }
        
        [BsonElement("MonstersNeededMin")]
        public short? MonstersNeededMin { get; set; }
        
        [BsonElement("MonstersNeededMax")]
        public short? MonstersNeededMax { get; set; }
        
        //informacoes de xyz
        
        [BsonElement("XyzSummonRequirement")]
        public string? XyzSummonRequirement { get; set; }

        [BsonElement("XyzRank")]
        public short? XyzRank { get; set; }

        [BsonElement("MaterialsNeededMin")]
        public short? MaterialsNeededMMin { get; set; }
        
        [BsonElement("MaterialsNeededMax")]
        public short? MaterialsNeededMax { get; set; }
        
        //informacoes de link
        
        [BsonElement("LinkSummonRequirement")]
        public string? LinkSummonRequirement { get; set; }

        [BsonElement("MonstersNeededLink")]
        public List<string>? MonstersNeededLink { get; set; }
        
        [BsonElement("LinkGrade")]
        public short? LinkGrade { get; set; }

        [BsonElement("ArrowSuperiorEsquerdo")]
        public bool? ArrowSuperiorEsquerdo { get; set; }
        
        [BsonElement("ArrowSuperiorCentro")]
        public bool? ArrowSuperiorCentro { get; set; }
        
        [BsonElement("ArrowSuperiorDireito")]
        public bool? ArrowSuperiorDireito { get; set; }
        
        [BsonElement("ArrowCentralEsquerdo")]
        public bool? ArrowCentralEsquerdo { get; set; }
        
        [BsonElement("ArrowCentralDireito")]
        public bool? ArrowCentralDireito { get; set; }
        
        [BsonElement("ArrowInferiorEsquerdo")]
        public bool? ArrowInferiorEsquerdo { get; set; }
        
        [BsonElement("ArrowInferiorCentral")]
        public bool? ArrowInferiorCentral { get; set; }
        
        [BsonElement("ArrowInferiorDireito")]
        public bool? ArrowInferiorDireito { get; set; }
    }
}
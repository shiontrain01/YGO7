using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace YGO7.Domain.Models
{
    public class LinkMonster : Monster
    {
        [BsonElement("LinkSummonRequirement")]
        public string LinkSummonRequirement { get; set; }

        [BsonElement("MonstersNeededLink")]
        public List<string> MonstersNeededLink { get; set; }
        
        [BsonElement("LinkGrade")]
        public short LinkGrade { get; set; }

        [BsonElement("MonstersNeededMin")]
        public short MonstersNeededMin { get; set; }
        
        [BsonElement("MonstersNeededMax")]
        public short MonstersNeededMax { get; set; }
        
        [BsonElement("ArrowSuperiorEsquerdo")]
        public bool ArrowSuperiorEsquerdo { get; set; }
        
        [BsonElement("ArrowSuperiorCentro")]
        public bool ArrowSuperiorCentro { get; set; }
        
        [BsonElement("ArrowSuperiorDireito")]
        public bool ArrowSuperiorDireito { get; set; }
        
        [BsonElement("ArrowCentralEsquerdo")]
        public bool ArrowCentralEsquerdo { get; set; }
        
        [BsonElement("ArrowCentralDireito")]
        public bool ArrowCentralDireito { get; set; }
        
        [BsonElement("ArrowInferiorEsquerdo")]
        public bool ArrowInferiorEsquerdo { get; set; }
        
        [BsonElement("ArrowInferiorCentral")]
        public bool ArrowInferiorCentral { get; set; }
        
        [BsonElement("ArrowInferiorDireito")]
        public bool ArrowInferiorDireito { get; set; }
    }
}
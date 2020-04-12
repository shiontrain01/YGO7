using System;
using MongoDB.Bson.Serialization.Attributes;

namespace YGO7.Domain.Models
{
    public class LinkMonsterArrows : LinkMonster
    {
        [BsonElement("ArrowSuperiorEsquerdo")]
        public Boolean ArrowSuperiorEsquerdo { get; set; }
        
        [BsonElement("ArrowSuperiorCentro")]
        public Boolean ArrowSuperiorCentro { get; set; }
        
        [BsonElement("ArrowSuperiorDireito")]
        public Boolean ArrowSuperiorDireito { get; set; }
        
        [BsonElement("ArrowCentralEsquerdo")]
        public Boolean ArrowCentralEsquerdo { get; set; }
        
        [BsonElement("ArrowCentralDireito")]
        public Boolean ArrowCentralDireito { get; set; }
        
        [BsonElement("ArrowInferiorEsquerdo")]
        public Boolean ArrowInferiorEsquerdo { get; set; }
        
        [BsonElement("ArrowInferiorCentral")]
        public Boolean ArrowInferiorCentral { get; set; }
        
        [BsonElement("ArrowInferiorDireito")]
        public Boolean ArrowInferiorDireito { get; set; }
    }
}
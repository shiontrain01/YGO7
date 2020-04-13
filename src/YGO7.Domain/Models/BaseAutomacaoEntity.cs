using System;
using System.Collections.Generic;
using YGO7.Domain.Enums;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using YGO7.Domain.Bases;

namespace YGO7.Domain.Models
{
    public abstract class BaseAutomacaoEntity : Entity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Codigo { get; set; }

        public override string Value => Nome;
    }
}
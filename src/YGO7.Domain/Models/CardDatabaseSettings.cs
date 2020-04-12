﻿namespace YGO7.Domain.Models
{
    public class CardDatabaseSettings : ICardDatabaseSettings
    {
        public string CardsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface ICardDatabaseSettings
    { 
        string CardsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}

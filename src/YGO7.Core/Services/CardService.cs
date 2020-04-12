using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using YGO7.Domain.Models;
using MongoDB.Driver;
using YGO7.Core.Interfaces;

namespace YGO7.Core.Services
{
    public class CardService : ICardService
    {
        private readonly IMongoCollection<Card> _cards;

        public CardService(ICardDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _cards = database.GetCollection<Card>(settings.CardsCollectionName);
        }
        

        public Task<ISingleResult<Card>> ListGet() =>
            _cards.Find(card => true).ToList();

        public Task<ISingleResult<Card>> GetCard(string id) =>
            _cards.Find<Card>(card => card.Id == id).FirstOrDefault();

        public Task<ISingleResult<Card>> Create(Card card)
        {
            _cards.InsertOne(card);
            return card;
        }

        public Task<ISingleResult<Card>> Update(string id, Card cardIn) =>
            _cards.ReplaceOne(card => card.Id == id, cardIn);

        public void Remove(Card cardIn) =>
            _cards.DeleteOne(card => card.Id == cardIn.Id);

        public Task<ISingleResult<Card>> Remove(string id) =>
           return new _cards.DeleteOne(card => card.Id == id);
    }
}
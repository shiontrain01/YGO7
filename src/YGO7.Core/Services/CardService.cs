using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using YGO7.Domain.Models;
using MongoDB.Driver;
using YGO7.Core.Interfaces;
using YGO7.Core.Messages;
using YGO7.Core.Models.Results;

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

        public async Task<IListResult<Card>> GetAll()
        {
            var entity = new List<Card>();

            try
            {
                entity = _cards.Find(card => true).ToList();
                
            }
            catch (Exception)
            {
                return new ListResult<Card>(MensagensNegocio.MSG07);
            }

            return new ListResult<Card>(entity);
        }

        public async Task<ISingleResult<Card>> Get(string id)
        {
            var entity = new Card();
            try
            {
                _cards.Find<Card>(card => card.Id == id).FirstOrDefault();
            }
            catch (Exception)
            {
                return new SingleResult<Card>(MensagensNegocio.MSG07);
            }

            return new InclusaoResult<Card>(entity);
        }

        public async Task<ISingleResult<Card>> Incluir(Card entity)
        {

            try
            {
                _cards.InsertOne(entity);
                return new InclusaoResult<Card>(entity);
            }
            catch (Exception)
            {
                return new SingleResult<Card>(MensagensNegocio.MSG07);
            }

            
        }

        public async Task<ISingleResult<Card>> Editar(string id, Card entity)
        {
            try
            {
                var obj = new Card();
                HydrateValues(obj, entity);
                _cards.ReplaceOne(card => card.Id == id, entity);
            }
            catch (Exception ex)
            {
                return new SingleResult<Card>(ex);
            }

            return new EdicaoResult<Card>();
        }

        public async Task<ISingleResult<Card>> Excluir(string id)
        {
            try
            {
                _cards.DeleteOne(card => card.Id == id);
            }
            catch (Exception)
            {
                return new SingleResult<Card>(MensagensNegocio.MSG07);
            }

            return new ExclusaoResult<Card>();
        }

        private void HydrateValues(Card target, Card source)
        {
            //target.Codigo = source.Codigo;
            //target.QuantidadePassageiros = source.QuantidadePassageiros;
            //target.Modelo = source.Modelo;
        }
    }
}
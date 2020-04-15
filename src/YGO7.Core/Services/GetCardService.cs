using System.Threading.Tasks;
using MongoDB.Driver;
using YGO7.Core.Interfaces;
using YGO7.Core.Models.Results;
using YGO7.Domain.Models;

namespace YGO7.Core.Services
{
    public class GetCardService : IGetCardService
    {
        private readonly IMongoCollection<CompleteCardInformation> _cards;

        public GetCardService(ICardDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _cards = database.GetCollection<CompleteCardInformation>(settings.CardsCollectionName);
        }

        public async Task<ISingleResult<CompleteCardInformation>> GetById(string id)
        {
            var entity = await _cards.FindAsync(card => card.Id == id);
            return new InclusaoResult<CompleteCardInformation>(entity.FirstOrDefault());
        }
    }
}
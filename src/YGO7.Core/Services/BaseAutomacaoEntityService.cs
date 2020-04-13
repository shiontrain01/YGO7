using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MongoDB.Driver;
using YGO7.Core.Bases;
using YGO7.Core.Extensions;
using YGO7.Core.Interfaces;
using YGO7.Core.Messages;
using YGO7.Core.Models.Results;
using YGO7.Domain.Models;

namespace YGO7.Core.Services
{
	 public class BaseAutomacaoEntityService : IBaseAutomacaoEntityService
	 {

		  private readonly IMongoCollection<Card> _cards;

		  public BaseAutomacaoEntityService(ICardDatabaseSettings settings)
		  {
			   var client = new MongoClient(settings.ConnectionString);
			   var database = client.GetDatabase(settings.DatabaseName);

			   _cards = database.GetCollection<Card>(settings.CardsCollectionName);
		  }


		  public async Task<ISingleResult<Card>> Incluir(FusionMonster entity)
		  {
			   try
			   {
					await _cards.InsertOneAsync(entity);
			   }
			   catch (Exception)
			   {
					return new SingleResult<Card>(MensagensNegocio.MSG07);
			   }

			   return new InclusaoResult<Card>(entity);
		  }

		  public async Task<ISingleResult<Card>> Incluir(LinkMonster entity)
		  {
			   try
			   {
					await _cards.InsertOneAsync(entity);
			   }
			   catch (Exception)
			   {
					return new SingleResult<Card>(MensagensNegocio.MSG07);
			   }

			   return new InclusaoResult<Card>(entity);
		  }

		  public async Task<ISingleResult<Card>> Incluir(SynchroMonster entity)
		  {
			   try
			   {
					await _cards.InsertOneAsync(entity);
			   }
			   catch (Exception)
			   {
					return new SingleResult<Card>(MensagensNegocio.MSG07);
			   }

			   return new InclusaoResult<Card>(entity);
		  }

		  public async Task<ISingleResult<Card>> Incluir(XyzMonster entity)
		  {
			   try
			   {
					await _cards.InsertOneAsync(entity);
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
					await _cards.InsertOneAsync(entity);
			   }
			   catch (Exception)
			   {
					return new SingleResult<Card>(MensagensNegocio.MSG07);
			   }

			   return new InclusaoResult<Card>(entity);
		  }
	 }
}

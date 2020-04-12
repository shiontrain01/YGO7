using System.Collections.Generic;
using System.Threading.Tasks;
using YGO7.Domain.Models;

namespace YGO7.Core.Interfaces
{
    public interface ICardService
    {
        Task<ISingleResult<Card>> ListGet();

        Task<ISingleResult<Card>> GetCard(string id);

        Task<ISingleResult<Card>> Create(Card entity);

        Task<ISingleResult<Card>> Update(string id,Card entity);

        Task<ISingleResult<Card>> Remove(string id);
    }
}
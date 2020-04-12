using System.Collections.Generic;
using System.Threading.Tasks;
using YGO7.Domain.Models;

namespace YGO7.Core.Interfaces
{
    public interface ICardService
    {
        List<Card> ListGet();

        Card GetCard(string id);

        Card Create(Card entity);

        void Update(string id,Card entity);

        void Remove(string id);
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using YGO7.Domain.Models;

namespace YGO7.Core.Interfaces
{
    public interface ICardService
    {
        Task<IListResult<Card>> GetAll();

        Task<ISingleResult<Card>> Get(string id);

        Task<ISingleResult<Card>> Incluir(FusionMonster entity);
        Task<ISingleResult<Card>> Incluir(LinkMonster entity);
        Task<ISingleResult<Card>> Incluir(SynchroMonster entity);
        Task<ISingleResult<Card>> Incluir(XyzMonster entity);
        Task<ISingleResult<Card>> Incluir(Card entity);

        Task<ISingleResult<Card>> Editar(string id,Card entity);

        Task<ISingleResult<Card>> Excluir(string id);
    }
}
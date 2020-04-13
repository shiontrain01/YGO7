using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using YGO7.Domain.Models;

namespace YGO7.Core.Interfaces
{
     public interface IBaseAutomacaoEntityService
     {
          Task<ISingleResult<Card>> Incluir(FusionMonster entity);
          Task<ISingleResult<Card>> Incluir(LinkMonster entity);
          Task<ISingleResult<Card>> Incluir(SynchroMonster entity);
          Task<ISingleResult<Card>> Incluir(XyzMonster entity);
          Task<ISingleResult<Card>> Incluir(Card entity);
     }
}

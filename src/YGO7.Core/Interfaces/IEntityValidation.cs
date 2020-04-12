using YGO7.Domain.Bases;
using YGO7.Domain.Interfaces;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace YGO7.Core.Interfaces
{
	public interface IEntityValidation<TEntity>
		where TEntity : IEntity
	{
		Task<ISingleResult<TEntity>> RegistroExiste(int id, params string[] includes);

		Task<ISingleResult<TEntity>> RegistroComMesmoCodigo(int id, string codigo);
	}
}

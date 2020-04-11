using AirplaneProject.Domain.Bases;
using AirplaneProject.Domain.Interfaces;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AirplaneProject.Core.Interfaces
{
	public interface IEntityValidation<TEntity>
		where TEntity : IEntity
	{
		Task<ISingleResult<TEntity>> RegistroExiste(int id, params string[] includes);

		Task<ISingleResult<TEntity>> RegistroComMesmoCodigo(int id, string codigo);
	}
}

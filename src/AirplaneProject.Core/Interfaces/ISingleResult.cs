using AirplaneProject.Domain.Bases;
using AirplaneProject.Domain.Interfaces;

namespace AirplaneProject.Core.Interfaces
{
	public interface ISingleResult<TEntity> : IResult
		where TEntity : IEntity
	{	
		TEntity Data { get; set; }
	}
}

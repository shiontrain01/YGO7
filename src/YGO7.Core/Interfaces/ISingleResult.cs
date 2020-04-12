using YGO7.Domain.Bases;
using YGO7.Domain.Interfaces;

namespace YGO7.Core.Interfaces
{
	public interface ISingleResult<TEntity> : IResult
		where TEntity : IEntity
	{	
		TEntity Data { get; set; }
	}
}

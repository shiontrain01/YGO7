using System.Collections.Generic;
using YGO7.Domain.Bases;
using YGO7.Domain.Interfaces;

namespace YGO7.Core.Interfaces
{
	public interface IListResult<TEntity> : IResult
		where TEntity : IEntity
	{
		public IEnumerable<TEntity> Data { get; set; }
	}
}

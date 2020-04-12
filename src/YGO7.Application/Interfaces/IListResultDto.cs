using YGO7.Application.Bases;
using System.Collections.Generic;

namespace YGO7.Application.Interfaces
{
	public interface IListResultDto<T>
		where T : Dto
	{
		IEnumerable<T> Data { get; set; }
	}
}

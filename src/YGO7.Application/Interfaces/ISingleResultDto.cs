using YGO7.Application.Bases;

namespace YGO7.Application.Interfaces
{
	public interface ISingleResultDto<TDto> : IResultDto
		where TDto : Dto
	{
		TDto Data { get; }
	}
}

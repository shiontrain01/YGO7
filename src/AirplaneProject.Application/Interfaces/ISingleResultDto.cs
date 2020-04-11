using AirplaneProject.Application.Bases;

namespace AirplaneProject.Application.Interfaces
{
	public interface ISingleResultDto<TDto> : IResultDto
		where TDto : Dto
	{
		TDto Data { get; }
	}
}

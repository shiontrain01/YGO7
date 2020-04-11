using AirplaneProject.Application.Bases;
using System.Collections.Generic;

namespace AirplaneProject.Application.Interfaces
{
	public interface IListResultDto<T>
		where T : Dto
	{
		IEnumerable<T> Data { get; set; }
	}
}

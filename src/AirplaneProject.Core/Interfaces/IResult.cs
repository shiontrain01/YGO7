using AirplaneProject.Domain.Enums;

namespace AirplaneProject.Core.Interfaces
{
	public interface IResult
	{
		bool Sucesso { get; set; }
		string Mensagem { get; set; }
    }
}

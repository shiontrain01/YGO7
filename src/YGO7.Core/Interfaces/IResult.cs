using YGO7.Domain.Enums;

namespace YGO7.Core.Interfaces
{
	public interface IResult
	{
		bool Sucesso { get; set; }
		string Mensagem { get; set; }
    }
}

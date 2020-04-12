using YGO7.Domain.Bases;
using YGO7.Core.Messages;

namespace YGO7.Core.Models.Results
{
	public class EdicaoResult<TEntity> : SingleResult<TEntity>
		where TEntity : Entity
	{
		public EdicaoResult()
		{
			Sucesso = true;
			Mensagem = MensagensNegocio.ResourceManager.GetString("MSG02");
		}

		public EdicaoResult(bool sucesso, string mensagem)
		{
			this.Sucesso = sucesso;
			this.Mensagem = mensagem;
		}

		public EdicaoResult(string mensagem)
		{
			this.Sucesso = false;
			this.Mensagem = mensagem;
		}
	}
}

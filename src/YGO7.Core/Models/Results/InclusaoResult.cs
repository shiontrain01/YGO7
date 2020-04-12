using YGO7.Domain.Bases;
using YGO7.Core.Messages;

namespace YGO7.Core.Models.Results
{
	public class InclusaoResult<TEntity> : SingleResult<TEntity>
		where TEntity : Entity
	{
		public InclusaoResult(TEntity data)
		{
			Sucesso = true;
			Mensagem = MensagensNegocio.ResourceManager.GetString("MSG01");
			Data = data;
		}

		public InclusaoResult(bool sucesso, string mensagem)
		{
			this.Sucesso = sucesso;
			this.Mensagem = mensagem;
		}

		public InclusaoResult(string mensagem)
		{
			this.Sucesso = false;
			this.Mensagem = mensagem;
		}
	}
}

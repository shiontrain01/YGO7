using YGO7.Core.Messages;
using YGO7.Core.Interfaces;
using YGO7.Domain.Bases;
using YGO7.Domain.Enums;
using AutoMapper;
using YGO7.Application.Interfaces;
using System;
using System.Threading.Tasks;
using YGO7.Domain.Models;

namespace YGO7.Application.Bases
{
	public class SingleResultDto<TDto> : ResultDto, ISingleResultDto<TDto>
		where TDto : Dto
	{
		public SingleResultDto(TDto data)
		{
			this.Codigo = (data == null) ? EnumResultadoAcao.ErroNaoEncontrado : EnumResultadoAcao.Sucesso;
			this.Sucesso = data != null;
			this.Mensagem = (data == null) ? MensagensNegocio.ResourceManager.GetString("MSG04") : string.Empty;
			this.Data = data;
		}

		public SingleResultDto(string mensagem)
		{
			this.Codigo = EnumResultadoAcao.ErroValidacaoNegocio;
			this.Sucesso = false;
			this.Mensagem = mensagem;
		}

		public SingleResultDto(Exception ex)
		{
			this.Codigo = EnumResultadoAcao.ErroServidor;
			this.Sucesso = false;
			this.Mensagem = ex.Message;
		}

		public SingleResultDto(IResult result)
		{
			this.Sucesso = result.Sucesso;
			this.Mensagem = result.Mensagem;
		}

        public SingleResultDto(int codigo, bool sucesso, string mensagem)
        {
            this.Codigo = (EnumResultadoAcao)codigo;
            this.Sucesso = sucesso;
            this.Mensagem = mensagem;
        }

        public TDto Data { get; private set; }

		public void SetData<TEntity>(ISingleResult<TEntity> result, IMapper mapper)
			where TEntity : Entity
		{
			this.Data = mapper.Map<TDto>(result.Data);
		}
	}
}

using AirplaneProject.Core.Messages;
using AirplaneProject.Core.Interfaces;
using AirplaneProject.Domain.Bases;
using AirplaneProject.Domain.Enums;
using AutoMapper;
using AirplaneProject.Application.Interfaces;
using System;

namespace AirplaneProject.Application.Bases
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

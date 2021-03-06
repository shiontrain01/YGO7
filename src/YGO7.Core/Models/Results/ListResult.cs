﻿using YGO7.Core.Interfaces;
using YGO7.Core.Messages;
using YGO7.Domain.Bases;
using YGO7.Domain.Enums;
using YGO7.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace YGO7.Core.Models.Results
{
	public class ListResult<TEntity> : IListResult<TEntity>
		where TEntity : IEntity
	{
		public ListResult()
		{
			this.Codigo = EnumResultadoAcao.Sucesso;
			this.Sucesso = true;
		}

		public ListResult(string mensagem)
		{
			this.Codigo = EnumResultadoAcao.ErroValidacaoNegocio;
			this.Sucesso = false;
			this.Mensagem = mensagem;
		}

		public ListResult(Exception ex)
		{
			this.Codigo = EnumResultadoAcao.ErroServidor;
			this.Sucesso = false;
			this.Mensagem = MensagensNegocio.ResourceManager.GetString("MSG07");
		}

		public ListResult(IEnumerable<TEntity> data)
		{
			this.Codigo = (data == null) ? EnumResultadoAcao.ErroNaoEncontrado : EnumResultadoAcao.Sucesso;
			this.Sucesso = data != null;
			this.Mensagem = (data == null) ? MensagensNegocio.ResourceManager.GetString("MSG04") : string.Empty;
			this.Data = data;
		}

		public EnumResultadoAcao Codigo { get; set; }
		public bool Sucesso { get; set; }
		public string Mensagem { get; set; }
		public IEnumerable<TEntity> Data { get; set; }
	}
}

using YGO7.Application.Interfaces;
using YGO7.Domain.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace YGO7.Application.Bases
{
	public class ResultDto : IResultDto
	{
		public EnumResultadoAcao Codigo { get; set; }
		public bool Sucesso { get; set; }
		public string Mensagem { get; set; }
        public string Campo { get; set; }
        public IList<string> Mensagens { get; set; }

		public ValidationResult ValidationResult { get; set; }
	}
}

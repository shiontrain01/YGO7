using FluentValidation;

namespace AirplaneProject.Application.Bases
{
	public class DtoValidation<TDto> : AbstractValidator<TDto>
		where TDto : EntityDto
	{
		public const string CAMPO_OBRIGATORIO = "CAMPO_OBRIGATORIO";
		public const string TAMANHO_ESPECIFICO_CAMPO = "TAMANHO_ESPECIFICO_CAMPO";
		public const string TAMANHO_INTERVALO_CAMPO = "TAMANHO_INTERVALO_CAMPO";
		public const string CAMPO_DATA_MAIOR_QUE_HOJE = "CAMPO_DATA_MAIOR_QUE_HOJE";

		protected void ValidarId()
		{
			RuleFor(c => c.Id)
				.NotEqual(0);
		}
	}
}

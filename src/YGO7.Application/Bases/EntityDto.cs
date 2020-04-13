using YGO7.Application.Interfaces;

namespace YGO7.Application.Bases
{
	public class EntityDto : Dto, IEntityDto
	{
		public string Id { get; set; }
	}
}

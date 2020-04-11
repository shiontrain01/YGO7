using AirplaneProject.Application.Interfaces;

namespace AirplaneProject.Application.Bases
{
	public class EntityDto : Dto, IEntityDto
	{
		public int Id { get; set; }
	}
}

using AirplaneProject.Core.Interfaces;
using System.Threading.Tasks;

namespace AirplaneProject.Core.Bases
{
	public class Service : IService
	{
		private readonly IUnitOfWork _uow;

		public Service(IUnitOfWork uow)
		{
			_uow = uow;
		}

		public async Task<bool> Commit()
		{
			if (await _uow.Commit())
			{
				return true;
			}

			return false;
		}
	}
}

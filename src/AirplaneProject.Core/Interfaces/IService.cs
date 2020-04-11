using System.Threading.Tasks;

namespace AirplaneProject.Core.Interfaces
{
	public interface IService
    {
		Task<bool> Commit();
	}
}

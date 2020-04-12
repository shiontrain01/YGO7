using System.Threading.Tasks;

namespace YGO7.Core.Interfaces
{
	public interface IService
    {
		Task<bool> Commit();
	}
}

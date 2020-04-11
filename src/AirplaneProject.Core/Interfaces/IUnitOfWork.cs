using System;
using System.Threading.Tasks;

namespace AirplaneProject.Core.Interfaces
{
	public interface IUnitOfWork : IDisposable
    {
		Task<bool> Commit();
    }
}

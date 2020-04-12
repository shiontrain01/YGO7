using System;
using System.Threading.Tasks;

namespace YGO7.Core.Interfaces
{
	public interface IUnitOfWork : IDisposable
    {
		Task<bool> Commit();
    }
}

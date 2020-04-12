using AirplaneProject.Core.Interfaces;
using System.Threading.Tasks;

namespace AirplaneProject.Infrastructure.Data
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly AirplaneProjectContext context;

		public UnitOfWork(AirplaneProjectContext context)
		{
			this.context = context;
		}

		public async Task<bool> Commit()
		{
			return await context.SaveChangesAsync() > 0;
		}

		public void Dispose()
		{
			context.Dispose();
		}
	}
}

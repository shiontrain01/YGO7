using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace AirplaneProject.Infrastructure.Data
{
	public class AirplaneProjectContextFactory : IDesignTimeDbContextFactory<AirplaneProjectContext>
	{
		public AirplaneProjectContext CreateDbContext(string[] args)
		{
			var optionsBuilder = new DbContextOptionsBuilder<AirplaneProjectContext>();

			// get the configuration from the app settings
			var config = new ConfigurationBuilder()
			   .SetBasePath(Directory.GetCurrentDirectory())
			   .AddJsonFile("appsettings.json")
			   .Build();

			// define the database to use
			optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));

			return new AirplaneProjectContext(optionsBuilder.Options);
		}
	}
}

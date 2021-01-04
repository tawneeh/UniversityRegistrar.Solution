using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace UniversityTracker.Models
{
  public class UniversityTrackerContextFactory : IDesignTimeDbContextFactory<UniversityTrackerContext>
  {
    UniversityTrackerContext IDesignTimeDbContextFactory<UniversityTrackerContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<UniversityTrackerContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);
      return new UniversityTrackerContext(builder.Options);
    }
  }
}
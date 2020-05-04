using Microsoft.EntityFrameworkCore;
using System.IO;
using TheTvTracker.Data.Model;

namespace TheTvTracker.Data.Access
{
  public class DbConnector : DbContext
  {
    public DbSet<User> Users { get; set; }
    public string DbPath { get; set; } = $"Data Source=.{Path.DirectorySeparatorChar}Data{Path.DirectorySeparatorChar}Data.db";

    public DbConnector()
    {
      if (!Directory.Exists("Data")) Directory.CreateDirectory("Data");
      Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlite(DbPath);
    }
  }
}

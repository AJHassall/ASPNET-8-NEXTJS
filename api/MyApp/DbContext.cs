using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
public class MyDbContext : DbContext
{
    public DbSet<DbEntryExample> Customers { get; set; } // Example DbSet

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
optionsBuilder.UseSqlServer("Server=db;Database=ApplicationDB;User Id=sa;Password=P@ssw0rd;TrustServerCertificate=True");    }
}


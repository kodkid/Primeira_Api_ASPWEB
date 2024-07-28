using Microsoft.EntityFrameworkCore;
using PrimeiraApi.Model;

namespace PrimeiraApi.Infraestrutura
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(
                "Server=localhost;" +
                "Port=5432;Database=employee;" +
                "User Id=postgres;" +
                "Password=root;"
                );
      
    }
}

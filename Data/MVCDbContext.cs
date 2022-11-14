using Microsoft.EntityFrameworkCore;
using ProjetoMVC.Models.Domain;

namespace ProjetoMVC.Data
{
    public class MVCDbContext : DbContext
    {
        public MVCDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

    }
}

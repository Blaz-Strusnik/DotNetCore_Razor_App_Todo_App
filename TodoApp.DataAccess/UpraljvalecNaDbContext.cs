using Microsoft.EntityFrameworkCore;
using TodoApp.Entities;

namespace TodoApp.DataAccess
{
    public class UpraljvalecNaDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionStringContainer.SQLiteConnectionString);
        }

        public DbSet<Naloga> Naloge { get; set; }
    }
}

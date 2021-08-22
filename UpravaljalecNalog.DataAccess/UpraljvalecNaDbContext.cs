using Microsoft.EntityFrameworkCore;
using UpravaljalecNalog.Entities;

namespace UpravaljalecNalog.DataAccess
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

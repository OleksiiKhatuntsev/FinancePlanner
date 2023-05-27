using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Currency> Currencies { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<OperationType> OperationTypes { get; set; }

        public DbSet<Operation> Operations{ get; set; }
    }
}
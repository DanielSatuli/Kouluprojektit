using Microsoft.EntityFrameworkCore;

namespace ItemApi.Data
{
    public class HistoryContext : DbContext
    {
        public DbSet<Item> History { get; set; }

        public HistoryContext(DbContextOptions<HistoryContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

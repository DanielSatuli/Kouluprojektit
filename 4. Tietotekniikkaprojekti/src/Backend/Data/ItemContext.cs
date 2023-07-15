using Microsoft.EntityFrameworkCore;

namespace ItemApi.Data
{
    public class ItemContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

        public ItemContext(DbContextOptions<ItemContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

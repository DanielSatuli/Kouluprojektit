using Microsoft.EntityFrameworkCore;

namespace ItemApi.Data
{
    public class EmailContext : DbContext
    {
        public DbSet<Email> Emails { get; set; }

        public EmailContext(DbContextOptions<EmailContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

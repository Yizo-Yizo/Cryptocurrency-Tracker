using Microsoft.EntityFrameworkCore;

namespace CryptoTrackerWebApi.Model
{
    public class CryptoTrackerContext : DbContext
    {
        public CryptoTrackerContext(DbContextOptions<CryptoTrackerContext> options)
            : base(options)
        {

        }
        public DbSet<Users> Users { get; set; } = null!;
    }
}

using Microsoft.EntityFrameworkCore;

namespace CryptoWebApi.Model
{
    public class AppUserContext : DbContext
    {
        public AppUserContext(DbContextOptions<AppUserContext> options)
            : base(options) { }
        public DbSet<AppUser> AppUsers { get; set; } = null!;
    }
}

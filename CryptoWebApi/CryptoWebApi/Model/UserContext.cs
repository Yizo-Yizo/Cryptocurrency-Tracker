using Microsoft.EntityFrameworkCore;

namespace CryptoWebApi.Model
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
            : base(options) { }
        public DbSet<AppUser> AppUsers { get; set; } = null!;
    }
}

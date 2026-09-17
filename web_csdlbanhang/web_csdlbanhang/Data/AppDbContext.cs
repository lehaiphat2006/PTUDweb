using Microsoft.EntityFrameworkCore;

namespace web_csdlbanhang.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opts) : base(opts) { }
    }
}

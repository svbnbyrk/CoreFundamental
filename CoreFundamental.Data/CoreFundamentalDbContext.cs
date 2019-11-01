using CoreFundamental.Core;
using Microsoft.EntityFrameworkCore;

namespace CoreFundamental.Data
{
    public class CoreFundamentalDbContext:DbContext
    {
        public CoreFundamentalDbContext(DbContextOptions<CoreFundamentalDbContext> options):base(options)
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}

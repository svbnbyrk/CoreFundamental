using CoreFundamental.Core;
using Microsoft.EntityFrameworkCore;

namespace CoreFundamental.Data
{
    class CoreFundamentalDbContext:DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;

namespace DigitalStoreAPI.Model
{
    public class DigitalStoreContext : DbContext
    {
        public DigitalStoreContext(DbContextOptions<DigitalStoreContext> options) : base(options)
        {

        }
        public DbSet<Merchant>? Merchants { get; set; }
        public DbSet<Product> Products { get; set; }
       
    }
}

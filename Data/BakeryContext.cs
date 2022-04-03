namespace Bakery.Data
{
    public class BakeryContext : DbContext
    {
        public BakeryContext (DbContextOptions<BakeryContext> options)
            : base(options)
        {
        }

        public DbSet<Bakery.Models.Bakery.Model.Product> Product { get; set; }
    }
}

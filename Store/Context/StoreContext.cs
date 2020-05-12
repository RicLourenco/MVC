namespace Store.Context
{
    using Store.Models;
    using System.Data.Entity;

    public class StoreContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
using clients.model;
using Microsoft.EntityFrameworkCore;
using products.model;

namespace products.data
{
    public class ProductsContext : DbContext 
    {
        public ProductsContext (DbContextOptions<ProductsContext> opt) : base(opt)
        {

        }

        public DbSet<Product> Products {get; set;}
        public DbSet<Client> Clients {get; set;}
    }
}
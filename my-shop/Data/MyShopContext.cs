using clients.model;
using Microsoft.EntityFrameworkCore;
using products.model;

namespace myshop.data
{
    public class MyShopContext : DbContext 
    {
        public MyShopContext (DbContextOptions<MyShopContext> options) : base(options)
        {

        }

        public DbSet<Product> Products {get; set;}
        public DbSet<Client> Clients {get; set;}
    }
}
using System.Collections.Generic;
using products.model;

namespace products.data 
{
    public class MockProductRepo : IProductRepo
    {
        public IEnumerable<Product> GetAllProducts()
        {
            var products = new List<Product>
            {
                new Product {id_product = 1, description = "toy of batman", price = 9.0, stock_quantity = 120},
                new Product {id_product = 4, description = "plastic cup 50", price= 8.50, stock_quantity = 230 }
            };

            return products;
        }

        public Product GetProductById(int id_product)
        {
            return new Product {id_product = 32, description= "monitor 144hz", price = 1200.50, stock_quantity = 98};
        }
    }
}
using System.Collections.Generic;
using products.model;

namespace products.data
{
    public interface IProductRepo
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id_product);

    }
}
using products.models;

namespace shop.data 
{
    public interface IShopRepo  
    {
        IEnumerable<product> GetAllProducts();
        product GetProductById(int id);

    }
}
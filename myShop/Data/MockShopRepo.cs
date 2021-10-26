using products.models;

namespace shop.data 
{
    public class MockShopRepo : IShopRepo
    {
        public IEnumerable<product> GetAllProducts()
        {
            var products = new List<product>
            {
                new product {id = 0, description="watter bottle", price=5, stock_quantity=50},
                new product {id = 1, description="mechanical keyboard", price=220, stock_quantity= 30},
                new product {id = 2, description="ultrawide monitor", price=1200, stock_quantity = 320}
            };

            return products;
        }

        public product GetProductById(int id)
        {
            return new product{id = 52, description= "pencil", price=1, stock_quantity= 450};
        }
    }
}
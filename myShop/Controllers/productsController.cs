using Microsoft.AspNetCore.Mvc;
using products.models;
using shop.data;

namespace shop.controllers
{
    [Route("api/products")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        private readonly MockShopRepo _repository = new MockShopRepo();

        //GET api/products
        [HttpGet]
        public ActionResult <IEnumerable<product>> GetAllProducts()
        {
            var productItems = _repository.GetAllProducts();

            return Ok(productItems);
        }

        //GET api/products/id
        [HttpGet("{id}")]
        public ActionResult <product> GetProductById(int id)
        {
            var productItem = _repository.GetProductById(id);
            return Ok(productItem);
        }
    }
    
}
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using products.data;
using products.model;

namespace products.controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly MockProductRepo MockRepository = new MockProductRepo();

        //GET api/products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetAllProducts()
        {
            var productList = MockRepository.GetAllProducts();
            return Ok(productList);
        }

        //GET api/products/{id}
        [HttpGet("{id}")]
        public ActionResult<Product> GetProductById(int id_product)
        {
            var productItem = MockRepository.GetProductById(id_product);
            return Ok (productItem);
        }
    }
}
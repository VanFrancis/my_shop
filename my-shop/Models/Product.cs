using System.ComponentModel.DataAnnotations;

namespace products.model
{
    public class Product 
    {
        [Key]
        public int id_product {get; set;} 
        [Required]
        public string description {get; set;}
        [Required]
        public double price {get; set;}
        [Required]
        public int stock_quantity {get; set;}
    }
}
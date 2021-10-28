using System.ComponentModel.DataAnnotations;

namespace clients.model 
{
    public class Client 
    {
        [Key]
        public int id_client {get; set;}
        [Required]
        public string name {get; set;}
    }
}
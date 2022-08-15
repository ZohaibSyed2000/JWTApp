using System.ComponentModel.DataAnnotations;

namespace JWTApp.Models
{
    public class Order
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }

        public int Quantity { get; set; }

        public string Type { get; set; }    
    }
}

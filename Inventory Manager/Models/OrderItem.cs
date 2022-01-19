using System.ComponentModel.DataAnnotations;

namespace Inventory_Manager.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        [Required]
        public virtual Order Order { get; set; }
        [Required]
        public virtual Product Product { get; set; }
        [Required]
        [Range(1, 500, ErrorMessage = "Only positive values are allowed")]
        public int Quantity { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Inventory_Manager.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
        [Range(1, 500, ErrorMessage = "Only positive values are allowed")]
        public int Quantity { get; set; }
    }
}

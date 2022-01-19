using System.ComponentModel.DataAnnotations;

namespace Inventory_Manager.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
        [Range(1, 500, ErrorMessage = "Only positive values are allowed")]
        public int Quantity { get; set; }
    }
}

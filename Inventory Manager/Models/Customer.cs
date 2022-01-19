using System.ComponentModel.DataAnnotations;

namespace Inventory_Manager.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string FullName { get; set; }
        
        [Required]
        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [Range(1, double.MaxValue, ErrorMessage = "Dude, thats a bit too much debt, don't you think?")]
        public double InDebt { get; set; }

        public List<Order> Orders { get; set; }

        public override string ToString()
        {
            return this.FullName;
        }
    }
}

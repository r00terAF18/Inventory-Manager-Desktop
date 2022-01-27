using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory_Manager.Models
{
    public class Payment
    {
        public int Id { get; set; }
        [Required]
        [Range(0, double.MaxValue)]
        public double Amount { get; set; }

        public string Comments { get; set; }

        [Required]
        public DateTime DatePayed { get; set; } = DateTime.Now;
        [Required]
        public Customer Customer { get; set; }

        public override string ToString()
        {
            return $"{Customer.FullName} - {Amount}";
        }
    }
}

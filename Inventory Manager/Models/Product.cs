using System.ComponentModel.DataAnnotations;

namespace Inventory_Manager.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string ProdctionYear { get; set; }

        [Required]
        public int Count { get; set; }

        [Required]
        public double PurchasePrice { get; set; }

        [Required]
        public double SellPrice { get; set; }

        public DateTime DatePurchased { get; set; }

        public override string ToString()
        {
            return this.Name;
        }

    }
}

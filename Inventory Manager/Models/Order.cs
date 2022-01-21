using System.ComponentModel.DataAnnotations;

namespace Inventory_Manager.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }

        public bool Paid { get; set; } = false;

        public double TransportFee { get; set; } = 0;

        public double Total
        {
            get
            {
                double total = 0;
                foreach (var item in Items)
                {
                    total += item.Product.SellPrice;
                }
                return total;
            }
        }

        public virtual Customer ByCustomer { get; set; }

        public virtual List<OrderItem> Items { get; set; }

        public override string ToString()
        {
            return $"{this.Id} - {this.DateCreated.ToString()}";
        }
    }
}

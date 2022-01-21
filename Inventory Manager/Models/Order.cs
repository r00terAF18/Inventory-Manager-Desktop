using System.ComponentModel.DataAnnotations;

namespace Inventory_Manager.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;

        public bool Paid { get; set; } = false;

        public double TransportFee { get; set; } = 0;

        public double Total
        {
            get
            {
                double total = 0;
                if (Items is not null && Items.Count > 0)
                {
                    foreach (var item in Items)
                    {
                        total += item.Product.SellPrice;
                    }
                }
                else
                {
                    total = 0;
                }
                
                return total;
            }
        }

        public virtual Customer? ByCustomer { get; set; }

        public virtual List<OrderItem>? Items { get; set; }

        public override string ToString()
        {
            return $"{Id} - {DateCreated.ToString()}";
        }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Inventory_Manager.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        public bool Paid { get; set; } = false;

        [Display(Name = "Transport Fee")]
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
                        total += item.Product.SellPrice * item.Quantity;
                    }
                }
                else
                {
                    total = 0;
                }
                
                return total;
            }
        }

        [Display(Name = "Customer")]
        public virtual Customer? ByCustomer { get; set; }
        // public virtual List<OrderItem>? Items
        // {
        //     get
        //     {

        //     }
        //     set;
        // }

        public virtual List<OrderItem>? Items { get; set; }

        public override string ToString()
        {
            return $"{Id} - {DateCreated.ToString()}";
        }
    }
}

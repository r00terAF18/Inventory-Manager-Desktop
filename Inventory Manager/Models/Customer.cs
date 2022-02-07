using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory_Manager.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        [Column("Full Name")]
        public string FullName { get; set; }

        [Required]
        [StringLength(20)]
        [Column("Phone Number")]
        public string PhoneNumber { get; set; }

        [Column("Address")]
        public string? Address { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Dude, thats a bit too much debt, don't you think?")]
        [Column("In Debt")]
        // public double InDebt { get; set; }
        public double InDebt
        {
            get
            {
                double inDebt = 0;
                if (Orders is not null)
                {
                    foreach (var order in Orders)
                    {
                        if (order.Paid)
                        {
                            inDebt += order.TransportFee;
                        }
                        else
                        {
                            inDebt += order.Total + order.TransportFee;
                        }
                    }
                }
                if (Payments is not null)
                {
                    foreach (var payment in Payments)
                    {
                        inDebt -= payment.Amount;
                    }
                }
                return inDebt;
            }
        }

        [Range(0, double.MaxValue, ErrorMessage = "Dude, thats a bit too much to pay back, don't you think?")]
        [Column("To be Paid")]
        public double ToRePay
        {
            get
            {
                if (InDebt < 0)
                {
                    return -InDebt;
                }
                else
                {
                    return 0;
                }
            }
        }

        public virtual List<Order> Orders { get; set; }

        public List<Payment> Payments { get; set; }

        public override string ToString()
        {
            return this.FullName;
        }
    }
}

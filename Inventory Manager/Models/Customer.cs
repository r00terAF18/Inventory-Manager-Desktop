﻿using System.ComponentModel.DataAnnotations;

namespace Inventory_Manager.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Full Name", Description = "Full Name", Prompt = "Full Name")]
        public string FullName { get; set; }
        
        [Required]
        [StringLength(20)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Dude, thats a bit too much debt, don't you think?")]
        [Display(Name = "In Debt")]
        public double InDebt { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Dude, thats a bit too much to pay back, don't you think?")]
        [Display(Name = "To be Paid")]
        public double ToRePay { get; set; }

        public List<Order> Orders { get; set; }

        public override string ToString()
        {
            return this.FullName;
        }
    }
}

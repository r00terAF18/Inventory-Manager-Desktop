using Inventory_Manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Manager.CustomerForms
{
    public partial class CustomerAdd : Form
    {
        private readonly IMContext _ctx;
        private readonly Customer c;
        public CustomerAdd(IMContext ctx)
        {
            InitializeComponent();
            _ctx = ctx;
        }

        public CustomerAdd(IMContext ctx, Customer customer)
        {
            InitializeComponent();
            _ctx = ctx;
            c = customer;
            txtFullName.Text = c.FullName;
            txtPhoneNumber.Text = c.PhoneNumber;
            btnAddCustomer.Text = "Update";
            
            
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            if (_ctx.Customers.SingleOrDefault(c => c.FullName == txtFullName.Text) != null)
            {
                lblFullName.ForeColor = Color.Red;
                lblFullName.Text = "Customer already exists";
            }
            else
            {
                lblFullName.BackColor = Color.Green;
                lblFullName.Text = "Customer is valid";
            }
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (_ctx.Customers.SingleOrDefault(c => c.PhoneNumber == txtPhoneNumber.Text) != null)
            {
                lblPhoneNumber.BackColor = Color.Red;
                lblPhoneNumber.Text = "Phone Number already exists";
            }
            else
            {
                lblPhoneNumber.BackColor = Color.Green;
                lblPhoneNumber.Text = "Phone Number is valid";
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (btnAddCustomer.Text != "Update")
            {
                Customer c = new();
                c.FullName = txtFullName.Text;
                c.PhoneNumber = txtPhoneNumber.Text;

                _ctx.Customers.Add(c);
                _ctx.SaveChanges();

                txtPhoneNumber.Text = String.Empty;
                txtFullName.Text = String.Empty;

                MessageBox.Show("Customer added successfully");
            }
            else
            {
                c.FullName = txtFullName.Text;
                c.PhoneNumber = txtPhoneNumber.Text;
                _ctx.Customers.Update(c);
                _ctx.SaveChanges();

                txtPhoneNumber.Text = String.Empty;
                txtFullName.Text = String.Empty;

                MessageBox.Show("Customer updated successfully");
            }
        }
    }
}

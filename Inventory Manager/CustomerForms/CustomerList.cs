using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Manager.Models;

namespace Inventory_Manager.CustomerForms
{
    public partial class CustomerList : Form
    {
        private readonly IMContext _ctx;
        public CustomerList()
        {
            InitializeComponent();
        }

        public CustomerList(IMContext ctx)
        {
            InitializeComponent();
            _ctx = ctx;
        }

        private void CustomerList_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void RefreshList()
        {
            customerTable.DataSource = _ctx.Customers.ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (customerTable.SelectedCells[0].ColumnIndex == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this customer?", "Delete Customer", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int customerID = int.Parse(customerTable.SelectedCells[0].Value.ToString());
                    Customer c = _ctx.Customers.SingleOrDefault(x => x.Id == customerID);
                    _ctx.Customers.Remove(c);
                    _ctx.SaveChanges();
                    RefreshList();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (customerTable.SelectedCells[0].ColumnIndex == 0)
            {
                int customerID = int.Parse(customerTable.SelectedCells[0].Value.ToString());
                Customer customer = _ctx.Customers.SingleOrDefault(x => x.Id == customerID);

                customer.FullName = txtFullName.Text;
                customer.PhoneNumber = txtPhoneNumber.Text;
                customer.Address = txtAddress.Text;

                _ctx.Customers.Update(customer);
                _ctx.SaveChanges();

                RefreshList();
            }

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string address = txtAddress.Text;
            Customer customer = new()
            {
                FullName = fullName,
                PhoneNumber = phoneNumber,
                Address = address
            };
            _ctx.Customers.Add(customer);
            _ctx.SaveChanges();

            RefreshList();
        }

        private void customerTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (customerTable.SelectedCells[0].ColumnIndex == 0)
            {
                int customerID = int.Parse(customerTable.SelectedCells[0].Value.ToString());
                Customer c = _ctx.Customers.SingleOrDefault(x => x.Id == customerID);

                txtFullName.Text = c.FullName;
                txtPhoneNumber.Text = c.PhoneNumber;
                txtAddress.Text = c.Address;
            }
        }
    }
}

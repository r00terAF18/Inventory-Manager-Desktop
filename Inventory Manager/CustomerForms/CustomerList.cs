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
            var customers = _ctx.Customers.ToList();
            customerTable.DataSource = customers;
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (customerTable.SelectedCells[0].ColumnIndex == 0)
            {
                int customerID = int.Parse(customerTable.SelectedCells[0].Value.ToString());
                // lblId.Text = customerTable.SelectedCells[0].Value.ToString();
                Customer c = _ctx.Customers.SingleOrDefault(x => x.Id == customerID);
                CustomerAdd cAdd = new(_ctx, c);
                cAdd.Show();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}

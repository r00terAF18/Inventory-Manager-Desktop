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

// First a combo box with customer names
// then when the customer combo box is changed the order list is refreshed
// then when the order list is changed the order details are displayed
// in a datatable

namespace Inventory_Manager.OrderForms
{
    public partial class OrderList : Form
    {
        private readonly IMContext _ctx;
        public OrderList()
        {
            InitializeComponent();
        }

        public OrderList(IMContext ctx)
        {
            InitializeComponent();
            _ctx = ctx;
        }

        private void RefreshList()
        {
            comboCustomer.DataSource = _ctx.Customers.ToList();
        }

        private void OrderList_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void comboCustomer_SelectedValueChanged(object sender, EventArgs e)
        {
            Customer customer = _ctx.Customers.SingleOrDefault(c => c.FullName == comboCustomer.SelectedValue.ToString());
            comboOrders.DataSource = _ctx.Orders.Where(o => o.ByCustomer == customer).ToList();
        }

        private void comboOrders_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int oid = int.Parse(comboOrders.SelectedValue.ToString().Split("-")[0]);
                Order order = _ctx.Orders.SingleOrDefault(o => o.Id == oid);

                lblPaid.Text = "Paid: " + order.Paid.ToString();
                lblFee.Text = "Transport Fee: " + order.TransportFee.ToString();
                lblTotal.Text = "Total: " + _ctx.OrderItems.Where(oi => oi.Order == order).ToList().Count; // order.Total.ToString()

                dataTableOrderItems.DataSource = _ctx.OrderItems.Where(oi => oi.Order == order).ToList();
            }
            catch
            {

            }
        }
    }
}

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
            txtFilterCustomer.Text = String.Empty;
            comboCustomer.Enabled = false;
        }

        private void OrderList_Load(object sender, EventArgs e)
        {
            //RefreshList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataTableOrderItems.SelectedCells[0].ColumnIndex == 0)
            {
                int orderId = int.Parse(dataTableOrderItems.SelectedCells[0].Value.ToString());
                // lblId.Text = dataTableOrderItems.SelectedCells[0].Value.ToString();
                Order order = _ctx.Orders.SingleOrDefault(x => x.Id == orderId);
                OrderEdit cAdd = new(_ctx, order);
                cAdd.Show();
            }
            else
            {
                MessageBox.Show("Please select an ID Column to edit");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataTableOrderItems.SelectedCells[0].ColumnIndex == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this Order?", "Delete Order", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int orderId = int.Parse(dataTableOrderItems.SelectedCells[0].Value.ToString());
                    Order order = _ctx.Orders.SingleOrDefault(x => x.Id == orderId);

                    foreach (var orderItem in _ctx.OrderItems.Where(oi => oi.Order == order))
                    {
                        _ctx.OrderItems.Remove(orderItem);
                    }

                    _ctx.Orders.Remove(order);
                    _ctx.SaveChanges();
                    RefreshList();
                }
            }
            else
            {
                MessageBox.Show("Please select an ID Column to delete");
            }
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
                lblTotal.Text = "Total: " + order.Total.ToString(); // order.Total.ToString()

                dataTableOrderItems.DataSource = _ctx.OrderItems.Where(oi => oi.Order == order).ToList();
            }
            catch
            {

            }
        }

        private void txtFilterCustomer_TextChanged(object sender, EventArgs e)
        {
            comboCustomer.DataSource = _ctx.Customers.Where(c => c.FullName.Contains(txtFilterCustomer.Text)).ToList();
            if (!comboCustomer.Enabled)
            {
                comboCustomer.Enabled = true;
                comboOrders.Enabled = true;
            }
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            if (dataTableOrderItems.SelectedCells[0].ColumnIndex == 0)
            {
                int orderId = int.Parse(dataTableOrderItems.SelectedCells[0].Value.ToString());
                // lblId.Text = dataTableOrderItems.SelectedCells[0].Value.ToString();
                OrderItem orderItem = _ctx.OrderItems.SingleOrDefault(x => x.Id == orderId);
                EditItem editItem = new(_ctx, orderItem);
                editItem.Show();
            }
            else
            {
                MessageBox.Show("Please select an ID Column to edit");
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (dataTableOrderItems.SelectedCells[0].ColumnIndex == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this Item from the Order?", "Delete Order Item", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int orderId = int.Parse(dataTableOrderItems.SelectedCells[0].Value.ToString());
                    OrderItem orderItem = _ctx.OrderItems.SingleOrDefault(x => x.Id == orderId);
                    // re-stock deleted OrderItem
                    Product product = orderItem.Product;
                    product.Count += orderItem.Quantity;
                    _ctx.Products.Update(product);

                    _ctx.OrderItems.Remove(orderItem);
                    _ctx.SaveChanges();
                    //RefreshList();
                }
            }
            else
            {
                MessageBox.Show("Please select an ID Column to delete");
            }
        }
    }
}

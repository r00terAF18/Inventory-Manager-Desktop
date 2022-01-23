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

namespace Inventory_Manager.OrderForms
{
    public partial class OrderEdit : Form
    {
        private readonly IMContext _ctx;
        private Order _order;
        public OrderEdit()
        {
            InitializeComponent();
        }

        public OrderEdit(IMContext ctx, Order order)
        {
            InitializeComponent();
            _ctx = ctx;
            _order = order;
        }

        private void OrderEdit_Load(object sender, EventArgs e)
        {
            comboCustomer.DataSource = _ctx.Customers.ToList();
            txtTransportFee.Text = _order.TransportFee.ToString();
            comboCustomer.SelectedText = _order.ByCustomer.FullName;
        }

        private void OrderEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Customer customer = _order.ByCustomer;
            if (!switchPaid.Checked)
            {
                customer.InDebt += _order.Total + _order.TransportFee;
            }
            else
            {
                customer.InDebt += _order.TransportFee;
                customer.InDebt -= _order.Total;
            }

            _ctx.Customers.Update(customer);
            _ctx.SaveChanges();
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            _order.Paid = switchPaid.Checked;
            _order.TransportFee = double.Parse(txtTransportFee.Text);

            _ctx.Orders.Update(_order);
            _ctx.SaveChanges();

            MessageBox.Show("Order updated successfully");
        }
    }
}

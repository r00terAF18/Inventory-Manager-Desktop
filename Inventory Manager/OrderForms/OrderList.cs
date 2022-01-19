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
            treeView1.BeginUpdate();
            treeView1.Nodes.Clear();

            // show orders of customer in tree view
            var orders = _ctx.Orders.ToList();
            foreach (var order in orders)
            {
                TreeNode node = new TreeNode($"{order.ByCustomer.FullName} at {order.DateCreated.ToString()}");
                // node.Nodes.Add();
                // node.Nodes.Add(order.DateCreated.ToString());
                // node.Nodes.Add(order.Total.ToString());
                foreach (var item in order.Items)
                {
                    node.Nodes.Add(item.Product.Name);
                }
                treeView1.Nodes.Add(node);
            }

            treeView1.EndUpdate();
        }

        private void OrderList_Load(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}

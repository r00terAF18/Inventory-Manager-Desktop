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
    public partial class EditItem : Form
    {
        private readonly IMContext _ctx;
        private OrderItem _oItem;
        public EditItem(IMContext ctx, OrderItem oItem)
        {
            InitializeComponent();
            _ctx = ctx;
            _oItem = oItem;
        }

        private void EditItem_Load(object sender, EventArgs e)
        {
            lblProduct.Text = _oItem.Product.Name;
            //comboProduct.SelectedValue = _oItem.Product.Name;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _oItem.Quantity = int.Parse(quantity.Value.ToString());
            _ctx.OrderItems.Update(_oItem);
            _ctx.SaveChangesAsync();

            MessageBox.Show("Order Item Updated successfully!");
        }
    }
}

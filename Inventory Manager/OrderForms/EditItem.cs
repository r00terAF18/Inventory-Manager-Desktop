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
            comboProduct.DataSource = _ctx.Products.ToList();
            comboProduct.SelectedValue = _oItem.Product.Name;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _oItem.Product = _ctx.Products.SingleOrDefault(p => p.Name == comboProduct.SelectedValue.ToString());
            _oItem.Quantity = int.Parse(quantity.Value.ToString());
            _ctx.OrderItems.Update(_oItem);
            _ctx.SaveChangesAsync();

            MessageBox.Show("Order Item Updated successfully!");
        }

        private void comboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                quantity.Maximum = _ctx.Products.SingleOrDefault(p => p.Name == comboProduct.SelectedValue.ToString()).Count;
            }
            catch (Exception)
            {
                // MessageBox.Show("Please select a product");
            }
        }
    }
}

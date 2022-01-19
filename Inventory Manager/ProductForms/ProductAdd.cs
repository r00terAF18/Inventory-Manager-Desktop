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

namespace Inventory_Manager.ProductForms
{
    public partial class ProductAdd : Form
    {
        private readonly IMContext _ctx;
        private readonly Product p;
        public ProductAdd(IMContext ctx)
        {
            InitializeComponent();
            _ctx = ctx;
        }

        public ProductAdd(IMContext ctx, Product product)
        {
            InitializeComponent();

            btnAdd.Text = "Update";

            _ctx = ctx;
            p = product;

            txtPName.Text = p.Name;
            dateProduction.Value = int.Parse(p.ProdctionYear);
            countStock.Value = p.Count;
            txtPPrice.Text = p.PurchasePrice.ToString();
            txtSPrice.Text = p.SellPrice.ToString();
            datePurchase.Value = p.DatePurchased;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text != "Update")
            {
                Product product = new Product();
                product.Name = txtPName.Text;
                product.ProdctionYear = dateProduction.Value.ToString();
                product.Count = (int)countStock.Value;
                product.PurchasePrice = double.Parse(txtPPrice.Text);
                product.SellPrice = double.Parse(txtSPrice.Text);
                product.DatePurchased = datePurchase.Value;

                _ctx.Products.Add(product);
                _ctx.SaveChanges();

                txtPName.Text = "";
                txtPPrice.Text = "";
                txtSPrice.Text = "";

                MessageBox.Show("Product added successfully");
            }
            else
            {
                p.Name = txtPName.Text;
                p.ProdctionYear = dateProduction.Value.ToString();
                p.Count = (int)countStock.Value;
                p.PurchasePrice = double.Parse(txtPPrice.Text);
                p.SellPrice = double.Parse(txtSPrice.Text);
                p.DatePurchased = datePurchase.Value;

                _ctx.Products.Update(p);
                _ctx.SaveChanges();

                txtPName.Text = "";
                txtPPrice.Text = "";
                txtSPrice.Text = "";

                MessageBox.Show("Product updated successfully");
            }
        }

        private void txtPName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

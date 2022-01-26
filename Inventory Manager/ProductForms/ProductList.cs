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
    public partial class ProductList : Form
    {
        private readonly IMContext _ctx;
        public ProductList()
        {
            InitializeComponent();
        }

        public ProductList(IMContext ctx)
        {
            InitializeComponent();
            _ctx = ctx;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (productTable.SelectedCells[0].ColumnIndex == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this product?", "Delete Product", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int productId = int.Parse(productTable.SelectedCells[0].Value.ToString());
                    Product product = _ctx.Products.SingleOrDefault(x => x.Id == productId);
                    _ctx.Products.Remove(product);
                    _ctx.SaveChanges();
                    RefreshList();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void RefreshList()
        {
            productTable.DataSource = _ctx.Products.ToList();
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (productTable.SelectedCells[0].ColumnIndex == 0)
            {
                int productId = int.Parse(productTable.SelectedCells[0].Value.ToString());
                Product product = _ctx.Products.SingleOrDefault(x => x.Id == productId);

                product.Name = txtPName.Text;
                product.PurchasePrice = double.Parse(txtPPrice.Text);
                product.SellPrice = double.Parse(txtSPrice.Text);
                product.Count = int.Parse(countStock.Value.ToString());
                product.ProdctionYear = dateProduction.Value.ToString();

                _ctx.Products.Update(product);
                _ctx.SaveChanges();
                RefreshList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new()
            {
                Name = txtPName.Text,
                ProdctionYear = dateProduction.Value.ToString(),
                Count = (int)countStock.Value,
                PurchasePrice = double.Parse(txtPPrice.Text),
                SellPrice = double.Parse(txtSPrice.Text)
            };
            _ctx.Products.Add(product);
            _ctx.SaveChanges();
            RefreshList();
        }

        private void productTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (productTable.SelectedCells[0].ColumnIndex == 0)
            {
                int productId = int.Parse(productTable.SelectedCells[0].Value.ToString());
                Product product = _ctx.Products.SingleOrDefault(x => x.Id == productId);

                txtPName.Text = product.Name;
                txtPPrice.Text = product.PurchasePrice.ToString();
                txtSPrice.Text = product.SellPrice.ToString();
                countStock.Value = product.Count;
                dateProduction.Value = decimal.Parse(product.ProdctionYear);
            }
        }
    }
}

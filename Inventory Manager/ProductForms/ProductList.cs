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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (productTable.SelectedCells[0].ColumnIndex == 0)
            {
                int productId = int.Parse(productTable.SelectedCells[0].Value.ToString());
                // lblId.Text = productTable.SelectedCells[0].Value.ToString();
                Product product = _ctx.Products.SingleOrDefault(x => x.Id == productId);
                ProductAdd cAdd = new(_ctx, product);
                cAdd.Show();
            }
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
            var products = _ctx.Products.ToList();
            productTable.DataSource = products;
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Inventory_Manager.CustomerForms;
using Inventory_Manager.ProductForms;
using Inventory_Manager.OrderForms;

namespace Inventory_Manager
{
    public partial class MainForm : Form
    {
        public IMContext ctx;
        public MainForm()
        {
            InitializeComponent();
            ctx = new();
            ctx.Database.EnsureCreatedAsync();
            ctx.Database.MigrateAsync();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            CustomerAdd c = new(ctx);
            c.Show();
        }

        private void btnListCustomer_Click(object sender, EventArgs e)
        {
            CustomerList c = new(ctx);
            c.Show();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ProductAdd p = new(ctx);
            p.Show();
        }

        private void btnListProduct_Click(object sender, EventArgs e)
        {
            ProductList p = new(ctx);
            p.Show();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            OrderAdd o = new(ctx);
            o.Show();
        }

        private void btnListOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
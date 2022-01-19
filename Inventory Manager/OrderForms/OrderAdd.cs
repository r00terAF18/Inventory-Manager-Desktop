﻿using System;
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
    public partial class OrderAdd : Form
    {
        private readonly IMContext _ctx;
        private Order order;
        public OrderAdd(IMContext ctx)
        {
            InitializeComponent();
            _ctx = ctx;
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            order = new Order();
            order.DateCreated = DateTime.Now;
            order.ByCustomer = _ctx.Customers.SingleOrDefault(c => c.FullName == comboCustomer.SelectedValue.ToString());
            order.Paid = switchPaid.Checked;
            order.TransportFee = double.Parse(txtTransportFee.Text);

            _ctx.Orders.Add(order);
            _ctx.SaveChanges();

            txtTransportFee.Text = "";

            MessageBox.Show("Order added successfully");

            comboCustomer.Enabled = false;
            switchPaid.Enabled = false;
            txtTransportFee.Enabled = false;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            OrderItem item = new OrderItem();

            Product product = _ctx.Products.SingleOrDefault(p => p.Name == comboProduct.SelectedValue.ToString());

            int cut = int.Parse(quantity.Value.ToString());

            item.Order = order;
            item.Product = product;
            item.Quantity = cut;

            _ctx.OrderItems.Add(item);

            product.Count -= cut;
            _ctx.Products.Update(product);

            _ctx.SaveChanges();

            MessageBox.Show("Item added successfully");

            // comboProduct.Enabled = false;
            // countItem.Enabled = false;
        }

        private void OrderAdd_Load(object sender, EventArgs e)
        {
            comboCustomer.DataSource = _ctx.Customers.ToList();
            comboProduct.DataSource = _ctx.Products.ToList();
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

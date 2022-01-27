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

namespace Inventory_Manager.PaymentForms
{
    public partial class PaymentList : Form
    {
        private readonly IMContext _ctx;
        private Customer _customer;
        public PaymentList()
        {
            InitializeComponent();
        }

        public PaymentList(IMContext ctx, Customer customer)
        {
            InitializeComponent();
            _ctx = ctx;
            _customer = customer;
        }

        private void RefreshList()
        {
            paymentTable.DataSource = _ctx.Payments.Where(x => x.Customer == _customer).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double amount = double.Parse(txtAmount.Text);
            string comments = txtComments.Text;

            Payment p = new()
            {
                Amount = amount,
                Comments = comments,
                Customer = _customer,
            };

            _ctx.Payments.Add(p);
            _ctx.SaveChangesAsync();
            RefreshList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (paymentTable.SelectedCells[0].ColumnIndex == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this Payemnt?", "Delete Payment", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int paymentID = int.Parse(paymentTable.SelectedCells[0].Value.ToString());
                    Payment p = _ctx.Payments.SingleOrDefault(x => x.Id == paymentID);
                    _ctx.Payments.Remove(p);
                    _ctx.SaveChanges();
                    RefreshList();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void paymentTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (paymentTable.SelectedCells[0].ColumnIndex == 0)
            {
                int paymentID = int.Parse(paymentTable.SelectedCells[0].Value.ToString());
                Payment payment = _ctx.Payments.SingleOrDefault(x => x.Id == paymentID);

                txtAmount.Text = payment.Amount.ToString();
                txtComments.Text = payment.Comments;
            }
        }

        private void PaymentList_Load(object sender, EventArgs e)
        {
            lblName.Text = _customer.FullName;
            lblNumber.Text = _customer.PhoneNumber;
            RefreshList();
        }
    }
}

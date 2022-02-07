using System.Data;
using Inventory_Manager.Models;
using iText.Html2pdf;
using System.Text;

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
            txtFilterCustomer.Text = String.Empty;
            comboCustomer.Enabled = false;
        }

        private void OrderList_Load(object sender, EventArgs e)
        {
            //RefreshList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataTableOrderItems.SelectedCells[0].ColumnIndex == 0)
            {
                int orderId = int.Parse(dataTableOrderItems.SelectedCells[0].Value.ToString());
                // lblId.Text = dataTableOrderItems.SelectedCells[0].Value.ToString();
                Order order = _ctx.Orders.SingleOrDefault(x => x.Id == orderId);
                OrderEdit cAdd = new(_ctx, order);
                cAdd.Show();
            }
            else
            {
                MessageBox.Show("Please select an ID Column to edit");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataTableOrderItems.SelectedCells[0].ColumnIndex == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this Order?", "Delete Order", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int orderId = int.Parse(dataTableOrderItems.SelectedCells[0].Value.ToString());
                    Order order = _ctx.Orders.SingleOrDefault(x => x.Id == orderId);

                    foreach (var orderItem in _ctx.OrderItems.Where(oi => oi.Order == order))
                    {
                        _ctx.OrderItems.Remove(orderItem);
                    }

                    _ctx.Orders.Remove(order);
                    _ctx.SaveChanges();
                    RefreshList();
                }
            }
            else
            {
                MessageBox.Show("Please select an ID Column to delete");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void comboCustomer_SelectedValueChanged(object sender, EventArgs e)
        {
            Customer customer = _ctx.Customers.SingleOrDefault(c => c.FullName == comboCustomer.SelectedValue.ToString());
            comboOrders.DataSource = _ctx.Orders.Where(o => o.ByCustomer == customer).ToList();
        }

        private void comboOrders_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int oid = int.Parse(comboOrders.SelectedValue.ToString().Split("-")[0]);
                Order order = _ctx.Orders.SingleOrDefault(o => o.Id == oid);

                lblPaid.Text = "Paid: " + order.Paid.ToString();
                lblFee.Text = "Transport Fee: " + order.TransportFee.ToString();
                lblTotal.Text = "Total: " + order.Total.ToString(); // order.Total.ToString()

                dataTableOrderItems.DataSource = _ctx.OrderItems.Where(oi => oi.Order == order).ToList();
            }
            catch
            {

            }
        }

        private void txtFilterCustomer_TextChanged(object sender, EventArgs e)
        {
            comboCustomer.DataSource = _ctx.Customers.Where(c => c.FullName.Contains(txtFilterCustomer.Text)).ToList();
            if (!comboCustomer.Enabled)
            {
                comboCustomer.Enabled = true;
                comboOrders.Enabled = true;
            }
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            if (dataTableOrderItems.SelectedCells[0].ColumnIndex == 0)
            {
                int orderId = int.Parse(dataTableOrderItems.SelectedCells[0].Value.ToString());
                // lblId.Text = dataTableOrderItems.SelectedCells[0].Value.ToString();
                OrderItem orderItem = _ctx.OrderItems.SingleOrDefault(x => x.Id == orderId);
                EditItem editItem = new(_ctx, orderItem);
                editItem.Show();
            }
            else
            {
                MessageBox.Show("Please select an ID Column to edit");
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (dataTableOrderItems.SelectedCells[0].ColumnIndex == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this Item from the Order?", "Delete Order Item", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int orderId = int.Parse(dataTableOrderItems.SelectedCells[0].Value.ToString());
                    OrderItem orderItem = _ctx.OrderItems.SingleOrDefault(x => x.Id == orderId);
                    // re-stock deleted OrderItem
                    Product product = orderItem.Product;
                    product.Count += orderItem.Quantity;
                    _ctx.Products.Update(product);

                    _ctx.OrderItems.Remove(orderItem);
                    _ctx.SaveChanges();
                    //RefreshList();
                }
            }
            else
            {
                MessageBox.Show("Please select an ID Column to delete");
            }
        }

        private string AddComma(string input)
        {
            input = input.Insert(input.Length - 3, ",");
            if (input.Length >= 8)
            {
                input = input.Insert(input.Length - 7, ",");
            }
            if (input.Length >= 11)
            {
                input = input.Insert(input.Length - 10, ",");
            }
            if (input.Length >= 14)
            {
                input = input.Insert(input.Length - 13, ",");
            }

            return input;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dataTableOrderItems.SelectedCells[0].ColumnIndex == 0)
            {
                int orderId = int.Parse(dataTableOrderItems.SelectedCells[0].Value.ToString());
                Order order = _ctx.Orders.SingleOrDefault(x => x.Id == orderId);

                string empty_table_row = @"
                <tr>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td>-</td>
                </tr>";



                string inv_id = $"INV-{order.Id.ToString()}";
                string issued = DateTime.Now.ToString("MMM dd yyyy");
                string customer = order.ByCustomer.FullName;
                string total = AddComma(order.Total.ToString() + "000");
                string transport_fee = AddComma(order.TransportFee.ToString() + "000");

                string html_doc = "";

                using (StreamReader sr = new StreamReader("index.html"))
                {
                    html_doc = sr.ReadToEnd();
                }

                var doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html_doc);

                doc.GetElementbyId("customer").InnerHtml = customer;
                doc.GetElementbyId("inv-id").InnerHtml = inv_id;
                doc.GetElementbyId("issued").InnerHtml = issued;
                doc.GetElementbyId("subtotal").InnerHtml = total;
                doc.GetElementbyId("transport_fee").InnerHtml = transport_fee;
                doc.GetElementbyId("debt").InnerHtml = AddComma(order.ByCustomer.InDebt.ToString() + "000");

                foreach (OrderItem orderItem in order.Items)
                {
                    string amount = AddComma((orderItem.Product.SellPrice * orderItem.Quantity).ToString() + "000");
                    string price = AddComma(orderItem.Product.SellPrice.ToString() + "000");
                    string table_row = $@"
                    <tr>
                        <td>{orderItem.Product.Name}</td>
                        <td>{orderItem.Quantity.ToString()}</td>
                        <td>{price}</td>
                        <td>{amount}</td>
                    </tr>";
                    doc.GetElementbyId("tbody").InnerHtml += table_row;
                }
                if (order.Items.Count <= 2)
                {
                    for (int i = 0; i <= 4; i++)
                    {
                        doc.GetElementbyId("tbody").InnerHtml += empty_table_row;
                    }
                }

                doc.Save($@"C:\Users\{Environment.UserName}\Documents\Invoice_{customer}.html", Encoding.UTF8);
                // using (FileStream htmlSource = File.Open(@"invoice.html", FileMode.Open))
                // using (FileStream pdfDest = File.Open($@"C:\Users\{Environment.UserName}\Documents\Invoice.pdf", FileMode.OpenOrCreate))
                // {
                //     ConverterProperties converterProperties = new ConverterProperties();
                //     converterProperties.SetCharset("utf-8");
                //     HtmlConverter.ConvertToPdf(htmlSource, pdfDest, converterProperties);
                // }

                MessageBox.Show("Created Invoice!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Please select an ID Column to edit");
            }
        }
    }
}

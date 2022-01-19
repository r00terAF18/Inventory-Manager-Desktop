namespace Inventory_Manager.OrderForms
{
    partial class OrderAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboCustomer = new MaterialSkin2DotNet.Controls.MaterialComboBox();
            this.switchPaid = new MaterialSkin2DotNet.Controls.MaterialSwitch();
            this.txtTransportFee = new MaterialSkin2DotNet.Controls.MaterialTextBox();
            this.btnCreateOrder = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.btnAddItem = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.materialDivider1 = new MaterialSkin2DotNet.Controls.MaterialDivider();
            this.comboProduct = new MaterialSkin2DotNet.Controls.MaterialComboBox();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // comboCustomer
            // 
            this.comboCustomer.AutoResize = false;
            this.comboCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboCustomer.Depth = 0;
            this.comboCustomer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboCustomer.DropDownHeight = 174;
            this.comboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCustomer.DropDownWidth = 121;
            this.comboCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboCustomer.FormattingEnabled = true;
            this.comboCustomer.Hint = "Customer";
            this.comboCustomer.IntegralHeight = false;
            this.comboCustomer.ItemHeight = 43;
            this.comboCustomer.Location = new System.Drawing.Point(12, 12);
            this.comboCustomer.MaxDropDownItems = 4;
            this.comboCustomer.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.comboCustomer.Name = "comboCustomer";
            this.comboCustomer.Size = new System.Drawing.Size(302, 49);
            this.comboCustomer.StartIndex = 0;
            this.comboCustomer.TabIndex = 0;
            // 
            // switchPaid
            // 
            this.switchPaid.AutoSize = true;
            this.switchPaid.Depth = 0;
            this.switchPaid.Location = new System.Drawing.Point(12, 73);
            this.switchPaid.Margin = new System.Windows.Forms.Padding(0);
            this.switchPaid.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switchPaid.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.switchPaid.Name = "switchPaid";
            this.switchPaid.Ripple = true;
            this.switchPaid.Size = new System.Drawing.Size(90, 37);
            this.switchPaid.TabIndex = 1;
            this.switchPaid.Text = "Paid";
            this.switchPaid.UseVisualStyleBackColor = true;
            // 
            // txtTransportFee
            // 
            this.txtTransportFee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTransportFee.Depth = 0;
            this.txtTransportFee.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTransportFee.Hint = "Transport Fee";
            this.txtTransportFee.LeadingIcon = null;
            this.txtTransportFee.Location = new System.Drawing.Point(12, 113);
            this.txtTransportFee.MaxLength = 50;
            this.txtTransportFee.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.txtTransportFee.Multiline = false;
            this.txtTransportFee.Name = "txtTransportFee";
            this.txtTransportFee.Size = new System.Drawing.Size(240, 50);
            this.txtTransportFee.TabIndex = 2;
            this.txtTransportFee.Text = "";
            this.txtTransportFee.TrailingIcon = null;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreateOrder.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCreateOrder.Depth = 0;
            this.btnCreateOrder.HighEmphasis = true;
            this.btnCreateOrder.Icon = null;
            this.btnCreateOrder.Location = new System.Drawing.Point(12, 172);
            this.btnCreateOrder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCreateOrder.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(126, 36);
            this.btnCreateOrder.TabIndex = 3;
            this.btnCreateOrder.Text = "Create Order";
            this.btnCreateOrder.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCreateOrder.UseAccentColor = false;
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddItem.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddItem.Depth = 0;
            this.btnAddItem.HighEmphasis = true;
            this.btnAddItem.Icon = null;
            this.btnAddItem.Location = new System.Drawing.Point(402, 113);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddItem.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(88, 36);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddItem.UseAccentColor = false;
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(320, 12);
            this.materialDivider1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(75, 196);
            this.materialDivider1.TabIndex = 5;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // comboProduct
            // 
            this.comboProduct.AutoResize = false;
            this.comboProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboProduct.Depth = 0;
            this.comboProduct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboProduct.DropDownHeight = 174;
            this.comboProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProduct.DropDownWidth = 121;
            this.comboProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboProduct.FormattingEnabled = true;
            this.comboProduct.Hint = "Product";
            this.comboProduct.IntegralHeight = false;
            this.comboProduct.ItemHeight = 43;
            this.comboProduct.Location = new System.Drawing.Point(401, 12);
            this.comboProduct.MaxDropDownItems = 4;
            this.comboProduct.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.comboProduct.Name = "comboProduct";
            this.comboProduct.Size = new System.Drawing.Size(302, 49);
            this.comboProduct.StartIndex = 0;
            this.comboProduct.TabIndex = 6;
            this.comboProduct.SelectedIndexChanged += new System.EventHandler(this.comboProduct_SelectedIndexChanged);
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantity.Location = new System.Drawing.Point(401, 73);
            this.quantity.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(120, 29);
            this.quantity.TabIndex = 7;
            this.quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // OrderAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 219);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.comboProduct);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.txtTransportFee);
            this.Controls.Add(this.switchPaid);
            this.Controls.Add(this.comboCustomer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderAdd";
            this.Text = "OrderAdd";
            this.Load += new System.EventHandler(this.OrderAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin2DotNet.Controls.MaterialComboBox comboCustomer;
        private MaterialSkin2DotNet.Controls.MaterialSwitch switchPaid;
        private MaterialSkin2DotNet.Controls.MaterialTextBox txtTransportFee;
        private MaterialSkin2DotNet.Controls.MaterialButton btnCreateOrder;
        private MaterialSkin2DotNet.Controls.MaterialButton btnAddItem;
        private MaterialSkin2DotNet.Controls.MaterialDivider materialDivider1;
        private MaterialSkin2DotNet.Controls.MaterialComboBox comboProduct;
        private NumericUpDown quantity;
    }
}
namespace Inventory_Manager.ProductForms
{
    partial class ProductAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductAdd));
            this.txtPName = new MaterialSkin2DotNet.Controls.MaterialTextBox();
            this.countStock = new System.Windows.Forms.NumericUpDown();
            this.txtSPrice = new MaterialSkin2DotNet.Controls.MaterialTextBox();
            this.txtPPrice = new MaterialSkin2DotNet.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            this.datePurchase = new System.Windows.Forms.DateTimePicker();
            this.materialLabel3 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            this.lblPName = new MaterialSkin2DotNet.Controls.MaterialLabel();
            this.lblPPrice = new MaterialSkin2DotNet.Controls.MaterialLabel();
            this.lblSPrice = new MaterialSkin2DotNet.Controls.MaterialLabel();
            this.btnAdd = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.dateProduction = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.countStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateProduction)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPName
            // 
            this.txtPName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPName.Depth = 0;
            this.txtPName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPName.Hint = "Product Name";
            this.txtPName.LeadingIcon = null;
            this.txtPName.Location = new System.Drawing.Point(12, 12);
            this.txtPName.MaxLength = 50;
            this.txtPName.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.txtPName.Multiline = false;
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(314, 50);
            this.txtPName.TabIndex = 0;
            this.txtPName.Text = "";
            this.txtPName.TrailingIcon = null;
            this.txtPName.TextChanged += new System.EventHandler(this.txtPName_TextChanged);
            // 
            // countStock
            // 
            this.countStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countStock.Location = new System.Drawing.Point(206, 146);
            this.countStock.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.countStock.Name = "countStock";
            this.countStock.Size = new System.Drawing.Size(120, 29);
            this.countStock.TabIndex = 2;
            this.countStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSPrice
            // 
            this.txtSPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSPrice.Depth = 0;
            this.txtSPrice.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSPrice.Hint = "Sell Price";
            this.txtSPrice.LeadingIcon = null;
            this.txtSPrice.Location = new System.Drawing.Point(12, 304);
            this.txtSPrice.MaxLength = 50;
            this.txtSPrice.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.txtSPrice.Multiline = false;
            this.txtSPrice.Name = "txtSPrice";
            this.txtSPrice.Size = new System.Drawing.Size(314, 50);
            this.txtSPrice.TabIndex = 3;
            this.txtSPrice.Text = "";
            this.txtSPrice.TrailingIcon = null;
            this.txtSPrice.TextChanged += new System.EventHandler(this.txtSPrice_TextChanged);
            // 
            // txtPPrice
            // 
            this.txtPPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPPrice.Depth = 0;
            this.txtPPrice.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPPrice.Hint = "Purchase Price";
            this.txtPPrice.LeadingIcon = null;
            this.txtPPrice.Location = new System.Drawing.Point(12, 212);
            this.txtPPrice.MaxLength = 50;
            this.txtPPrice.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.txtPPrice.Multiline = false;
            this.txtPPrice.Name = "txtPPrice";
            this.txtPPrice.Size = new System.Drawing.Size(314, 50);
            this.txtPPrice.TabIndex = 4;
            this.txtPPrice.Text = "";
            this.txtPPrice.TrailingIcon = null;
            this.txtPPrice.TextChanged += new System.EventHandler(this.txtPPrice_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(12, 103);
            this.materialLabel1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(114, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Production Year";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(12, 152);
            this.materialLabel2.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(58, 19);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "In Stock";
            // 
            // datePurchase
            // 
            this.datePurchase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datePurchase.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePurchase.Location = new System.Drawing.Point(206, 396);
            this.datePurchase.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.datePurchase.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.datePurchase.Name = "datePurchase";
            this.datePurchase.Size = new System.Drawing.Size(120, 29);
            this.datePurchase.TabIndex = 8;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(12, 406);
            this.materialLabel3.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(113, 19);
            this.materialLabel3.TabIndex = 9;
            this.materialLabel3.Text = "Purchased Date";
            // 
            // lblPName
            // 
            this.lblPName.AutoSize = true;
            this.lblPName.Depth = 0;
            this.lblPName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPName.Location = new System.Drawing.Point(12, 65);
            this.lblPName.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.lblPName.Name = "lblPName";
            this.lblPName.Size = new System.Drawing.Size(1, 0);
            this.lblPName.TabIndex = 10;
            // 
            // lblPPrice
            // 
            this.lblPPrice.AutoSize = true;
            this.lblPPrice.Depth = 0;
            this.lblPPrice.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPPrice.Location = new System.Drawing.Point(11, 265);
            this.lblPPrice.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.lblPPrice.Name = "lblPPrice";
            this.lblPPrice.Size = new System.Drawing.Size(1, 0);
            this.lblPPrice.TabIndex = 11;
            // 
            // lblSPrice
            // 
            this.lblSPrice.AutoSize = true;
            this.lblSPrice.Depth = 0;
            this.lblSPrice.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSPrice.Location = new System.Drawing.Point(11, 357);
            this.lblSPrice.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.lblSPrice.Name = "lblSPrice";
            this.lblSPrice.Size = new System.Drawing.Size(1, 0);
            this.lblSPrice.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdd.Depth = 0;
            this.btnAdd.HighEmphasis = true;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(262, 464);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 36);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd.UseAccentColor = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dateProduction
            // 
            this.dateProduction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateProduction.Location = new System.Drawing.Point(206, 97);
            this.dateProduction.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.dateProduction.Minimum = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            this.dateProduction.Name = "dateProduction";
            this.dateProduction.Size = new System.Drawing.Size(120, 29);
            this.dateProduction.TabIndex = 14;
            this.dateProduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateProduction.Value = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            // 
            // ProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 515);
            this.Controls.Add(this.dateProduction);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblSPrice);
            this.Controls.Add(this.lblPPrice);
            this.Controls.Add(this.lblPName);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.datePurchase);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtPPrice);
            this.Controls.Add(this.txtSPrice);
            this.Controls.Add(this.countStock);
            this.Controls.Add(this.txtPName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(358, 554);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(358, 554);
            this.Name = "ProductAdd";
            this.Text = "ProductAdd";
            ((System.ComponentModel.ISupportInitialize)(this.countStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateProduction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin2DotNet.Controls.MaterialTextBox txtPName;
        private NumericUpDown countStock;
        private MaterialSkin2DotNet.Controls.MaterialTextBox txtSPrice;
        private MaterialSkin2DotNet.Controls.MaterialTextBox txtPPrice;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel1;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel2;
        private DateTimePicker datePurchase;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel3;
        private MaterialSkin2DotNet.Controls.MaterialLabel lblPName;
        private MaterialSkin2DotNet.Controls.MaterialLabel lblPPrice;
        private MaterialSkin2DotNet.Controls.MaterialLabel lblSPrice;
        private MaterialSkin2DotNet.Controls.MaterialButton btnAdd;
        private NumericUpDown dateProduction;
    }
}
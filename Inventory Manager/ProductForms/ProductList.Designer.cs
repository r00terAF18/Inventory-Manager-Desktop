namespace Inventory_Manager.ProductForms
{
    partial class ProductList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.productTable = new MaterialSkin2DotNet.Controls.MaterialDataTable();
            this.btnDelete = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.btnRefresh = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.dateProduction = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.lblPPrice = new MaterialSkin2DotNet.Controls.MaterialLabel();
            this.lblPName = new MaterialSkin2DotNet.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            this.txtPPrice = new MaterialSkin2DotNet.Controls.MaterialTextBox();
            this.txtSPrice = new MaterialSkin2DotNet.Controls.MaterialTextBox();
            this.countStock = new System.Windows.Forms.NumericUpDown();
            this.txtPName = new MaterialSkin2DotNet.Controls.MaterialTextBox();
            this.btnUpdate = new MaterialSkin2DotNet.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateProduction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countStock)).BeginInit();
            this.SuspendLayout();
            // 
            // productTable
            // 
            this.productTable.AllowUserToAddRows = false;
            this.productTable.AllowUserToDeleteRows = false;
            this.productTable.AllowUserToOrderColumns = true;
            this.productTable.AllowUserToResizeRows = false;
            this.productTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.productTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.productTable.ColumnHeadersHeight = 56;
            this.productTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productTable.DefaultCellStyle = dataGridViewCellStyle18;
            this.productTable.Depth = 0;
            this.productTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.productTable.EnableHeadersVisualStyles = false;
            this.productTable.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.productTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.productTable.Location = new System.Drawing.Point(0, 0);
            this.productTable.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.productTable.Name = "productTable";
            this.productTable.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.productTable.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.productTable.RowTemplate.Height = 52;
            this.productTable.ShowColorStripping = true;
            this.productTable.Size = new System.Drawing.Size(896, 466);
            this.productTable.TabIndex = 0;
            this.productTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productTable_CellDoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelete.Depth = 0;
            this.btnDelete.HighEmphasis = true;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(903, 367);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(73, 36);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelete.UseAccentColor = false;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRefresh.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRefresh.Depth = 0;
            this.btnRefresh.HighEmphasis = true;
            this.btnRefresh.Icon = null;
            this.btnRefresh.Location = new System.Drawing.Point(903, 415);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRefresh.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(84, 36);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRefresh.UseAccentColor = false;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dateProduction
            // 
            this.dateProduction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateProduction.Location = new System.Drawing.Point(1097, 71);
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
            this.dateProduction.TabIndex = 2;
            this.dateProduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateProduction.Value = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdd.Depth = 0;
            this.btnAdd.HighEmphasis = true;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(1156, 415);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 36);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Add";
            this.btnAdd.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd.UseAccentColor = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPPrice
            // 
            this.lblPPrice.AutoSize = true;
            this.lblPPrice.Depth = 0;
            this.lblPPrice.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPPrice.Location = new System.Drawing.Point(1095, 239);
            this.lblPPrice.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.lblPPrice.Name = "lblPPrice";
            this.lblPPrice.Size = new System.Drawing.Size(1, 0);
            this.lblPPrice.TabIndex = 24;
            // 
            // lblPName
            // 
            this.lblPName.AutoSize = true;
            this.lblPName.Depth = 0;
            this.lblPName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPName.Location = new System.Drawing.Point(1096, 65);
            this.lblPName.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.lblPName.Name = "lblPName";
            this.lblPName.Size = new System.Drawing.Size(1, 0);
            this.lblPName.TabIndex = 23;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(903, 112);
            this.materialLabel2.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(58, 19);
            this.materialLabel2.TabIndex = 20;
            this.materialLabel2.Text = "In Stock";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(903, 77);
            this.materialLabel1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(114, 19);
            this.materialLabel1.TabIndex = 19;
            this.materialLabel1.Text = "Production Year";
            // 
            // txtPPrice
            // 
            this.txtPPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPPrice.Depth = 0;
            this.txtPPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPPrice.Hint = "Purchase Price";
            this.txtPPrice.LeadingIcon = null;
            this.txtPPrice.Location = new System.Drawing.Point(904, 143);
            this.txtPPrice.MaxLength = 50;
            this.txtPPrice.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.txtPPrice.Multiline = false;
            this.txtPPrice.Name = "txtPPrice";
            this.txtPPrice.Size = new System.Drawing.Size(314, 50);
            this.txtPPrice.TabIndex = 4;
            this.txtPPrice.Text = "";
            this.txtPPrice.TrailingIcon = null;
            // 
            // txtSPrice
            // 
            this.txtSPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSPrice.Depth = 0;
            this.txtSPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSPrice.Hint = "Sell Price";
            this.txtSPrice.LeadingIcon = null;
            this.txtSPrice.Location = new System.Drawing.Point(903, 199);
            this.txtSPrice.MaxLength = 50;
            this.txtSPrice.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.txtSPrice.Multiline = false;
            this.txtSPrice.Name = "txtSPrice";
            this.txtSPrice.Size = new System.Drawing.Size(314, 50);
            this.txtSPrice.TabIndex = 5;
            this.txtSPrice.Text = "";
            this.txtSPrice.TrailingIcon = null;
            // 
            // countStock
            // 
            this.countStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countStock.Location = new System.Drawing.Point(1097, 106);
            this.countStock.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.countStock.Name = "countStock";
            this.countStock.Size = new System.Drawing.Size(120, 29);
            this.countStock.TabIndex = 3;
            this.countStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.countStock.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // txtPName
            // 
            this.txtPName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPName.Depth = 0;
            this.txtPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPName.Hint = "Product Name";
            this.txtPName.LeadingIcon = null;
            this.txtPName.Location = new System.Drawing.Point(903, 12);
            this.txtPName.MaxLength = 50;
            this.txtPName.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.txtPName.Multiline = false;
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(314, 50);
            this.txtPName.TabIndex = 1;
            this.txtPName.Text = "";
            this.txtPName.TrailingIcon = null;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUpdate.Depth = 0;
            this.btnUpdate.HighEmphasis = true;
            this.btnUpdate.Icon = null;
            this.btnUpdate.Location = new System.Drawing.Point(1068, 415);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdate.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(77, 36);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdate.UseAccentColor = false;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 466);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dateProduction);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblPPrice);
            this.Controls.Add(this.lblPName);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtPPrice);
            this.Controls.Add(this.txtSPrice);
            this.Controls.Add(this.countStock);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.productTable);
            this.Name = "ProductList";
            this.Text = "ProductList";
            this.Load += new System.EventHandler(this.ProductList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateProduction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin2DotNet.Controls.MaterialDataTable productTable;
        private MaterialSkin2DotNet.Controls.MaterialButton btnDelete;
        private MaterialSkin2DotNet.Controls.MaterialButton btnRefresh;
        private NumericUpDown dateProduction;
        private MaterialSkin2DotNet.Controls.MaterialButton btnAdd;
        private MaterialSkin2DotNet.Controls.MaterialLabel lblPPrice;
        private MaterialSkin2DotNet.Controls.MaterialLabel lblPName;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel2;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel1;
        private MaterialSkin2DotNet.Controls.MaterialTextBox txtPPrice;
        private MaterialSkin2DotNet.Controls.MaterialTextBox txtSPrice;
        private NumericUpDown countStock;
        private MaterialSkin2DotNet.Controls.MaterialTextBox txtPName;
        private MaterialSkin2DotNet.Controls.MaterialButton btnUpdate;
    }
}
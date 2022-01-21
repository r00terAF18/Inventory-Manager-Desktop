namespace Inventory_Manager.OrderForms
{
    partial class OrderList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboCustomer = new MaterialSkin2DotNet.Controls.MaterialComboBox();
            this.dataTableOrderItems = new MaterialSkin2DotNet.Controls.MaterialDataTable();
            this.comboOrders = new MaterialSkin2DotNet.Controls.MaterialComboBox();
            this.btnRefresh = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.btnEdit = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.btnDelete = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.lblPaid = new MaterialSkin2DotNet.Controls.MaterialLabel();
            this.lblFee = new MaterialSkin2DotNet.Controls.MaterialLabel();
            this.lblTotal = new MaterialSkin2DotNet.Controls.MaterialLabel();
            this.txtFilterCustomer = new MaterialSkin2DotNet.Controls.MaterialTextBox();
            this.materialTextBox2 = new MaterialSkin2DotNet.Controls.MaterialTextBox();
            this.btnDeleteItem = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.btnEditItem = new MaterialSkin2DotNet.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableOrderItems)).BeginInit();
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
            this.comboCustomer.Enabled = false;
            this.comboCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboCustomer.FormattingEnabled = true;
            this.comboCustomer.Hint = "Select Customer";
            this.comboCustomer.IntegralHeight = false;
            this.comboCustomer.ItemHeight = 43;
            this.comboCustomer.Location = new System.Drawing.Point(12, 58);
            this.comboCustomer.MaxDropDownItems = 4;
            this.comboCustomer.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.comboCustomer.Name = "comboCustomer";
            this.comboCustomer.Size = new System.Drawing.Size(259, 49);
            this.comboCustomer.StartIndex = 0;
            this.comboCustomer.TabIndex = 0;
            this.comboCustomer.SelectedValueChanged += new System.EventHandler(this.comboCustomer_SelectedValueChanged);
            // 
            // dataTableOrderItems
            // 
            this.dataTableOrderItems.AllowUserToAddRows = false;
            this.dataTableOrderItems.AllowUserToDeleteRows = false;
            this.dataTableOrderItems.AllowUserToOrderColumns = true;
            this.dataTableOrderItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTableOrderItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataTableOrderItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataTableOrderItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataTableOrderItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTableOrderItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataTableOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTableOrderItems.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataTableOrderItems.Depth = 0;
            this.dataTableOrderItems.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataTableOrderItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataTableOrderItems.EnableHeadersVisualStyles = false;
            this.dataTableOrderItems.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataTableOrderItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.dataTableOrderItems.Location = new System.Drawing.Point(277, 0);
            this.dataTableOrderItems.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.dataTableOrderItems.MultiSelect = false;
            this.dataTableOrderItems.Name = "dataTableOrderItems";
            this.dataTableOrderItems.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTableOrderItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataTableOrderItems.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataTableOrderItems.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataTableOrderItems.RowTemplate.Height = 52;
            this.dataTableOrderItems.ShowVerticalScroll = false;
            this.dataTableOrderItems.Size = new System.Drawing.Size(691, 523);
            this.dataTableOrderItems.TabIndex = 2;
            // 
            // comboOrders
            // 
            this.comboOrders.AutoResize = false;
            this.comboOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboOrders.Depth = 0;
            this.comboOrders.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboOrders.DropDownHeight = 174;
            this.comboOrders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOrders.DropDownWidth = 121;
            this.comboOrders.Enabled = false;
            this.comboOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboOrders.FormattingEnabled = true;
            this.comboOrders.IntegralHeight = false;
            this.comboOrders.ItemHeight = 43;
            this.comboOrders.Location = new System.Drawing.Point(12, 167);
            this.comboOrders.MaxDropDownItems = 4;
            this.comboOrders.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.comboOrders.Name = "comboOrders";
            this.comboOrders.Size = new System.Drawing.Size(259, 49);
            this.comboOrders.StartIndex = 0;
            this.comboOrders.TabIndex = 3;
            this.comboOrders.SelectedValueChanged += new System.EventHandler(this.comboOrders_SelectedValueChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRefresh.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRefresh.Depth = 0;
            this.btnRefresh.HighEmphasis = true;
            this.btnRefresh.Icon = null;
            this.btnRefresh.Location = new System.Drawing.Point(12, 472);
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
            // btnEdit
            // 
            this.btnEdit.AutoSize = false;
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEdit.Depth = 0;
            this.btnEdit.HighEmphasis = true;
            this.btnEdit.Icon = null;
            this.btnEdit.Location = new System.Drawing.Point(13, 355);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEdit.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(123, 36);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit Order";
            this.btnEdit.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEdit.UseAccentColor = false;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelete.Depth = 0;
            this.btnDelete.HighEmphasis = true;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(12, 413);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 36);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete Order";
            this.btnDelete.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelete.UseAccentColor = false;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Depth = 0;
            this.lblPaid.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPaid.Location = new System.Drawing.Point(13, 236);
            this.lblPaid.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(41, 19);
            this.lblPaid.TabIndex = 7;
            this.lblPaid.Text = "Paid: ";
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Depth = 0;
            this.lblFee.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFee.Location = new System.Drawing.Point(12, 271);
            this.lblFee.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(78, 19);
            this.lblFee.TabIndex = 8;
            this.lblFee.Text = "Transport: ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Depth = 0;
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotal.Location = new System.Drawing.Point(12, 305);
            this.lblTotal.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(46, 19);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total: ";
            // 
            // txtFilterCustomer
            // 
            this.txtFilterCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilterCustomer.Depth = 0;
            this.txtFilterCustomer.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFilterCustomer.Hint = "Filter Customer by Name";
            this.txtFilterCustomer.LeadingIcon = null;
            this.txtFilterCustomer.Location = new System.Drawing.Point(13, 2);
            this.txtFilterCustomer.MaxLength = 50;
            this.txtFilterCustomer.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.txtFilterCustomer.Multiline = false;
            this.txtFilterCustomer.Name = "txtFilterCustomer";
            this.txtFilterCustomer.Size = new System.Drawing.Size(258, 50);
            this.txtFilterCustomer.TabIndex = 10;
            this.txtFilterCustomer.Text = "";
            this.txtFilterCustomer.TrailingIcon = null;
            this.txtFilterCustomer.TextChanged += new System.EventHandler(this.txtFilterCustomer_TextChanged);
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox2.LeadingIcon = null;
            this.materialTextBox2.Location = new System.Drawing.Point(13, 111);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Size = new System.Drawing.Size(258, 50);
            this.materialTextBox2.TabIndex = 11;
            this.materialTextBox2.Text = "";
            this.materialTextBox2.TrailingIcon = null;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.AutoSize = false;
            this.btnDeleteItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteItem.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteItem.Depth = 0;
            this.btnDeleteItem.HighEmphasis = true;
            this.btnDeleteItem.Icon = null;
            this.btnDeleteItem.Location = new System.Drawing.Point(144, 413);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteItem.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(123, 36);
            this.btnDeleteItem.TabIndex = 13;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteItem.UseAccentColor = false;
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnEditItem
            // 
            this.btnEditItem.AutoSize = false;
            this.btnEditItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditItem.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditItem.Depth = 0;
            this.btnEditItem.HighEmphasis = true;
            this.btnEditItem.Icon = null;
            this.btnEditItem.Location = new System.Drawing.Point(144, 355);
            this.btnEditItem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditItem.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(123, 36);
            this.btnEditItem.TabIndex = 12;
            this.btnEditItem.Text = "Edit Item";
            this.btnEditItem.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditItem.UseAccentColor = false;
            this.btnEditItem.UseVisualStyleBackColor = true;
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 523);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnEditItem);
            this.Controls.Add(this.materialTextBox2);
            this.Controls.Add(this.txtFilterCustomer);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblFee);
            this.Controls.Add(this.lblPaid);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.comboOrders);
            this.Controls.Add(this.dataTableOrderItems);
            this.Controls.Add(this.comboCustomer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order List";
            this.Load += new System.EventHandler(this.OrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableOrderItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin2DotNet.Controls.MaterialComboBox comboCustomer;
        private MaterialSkin2DotNet.Controls.MaterialDataTable dataTableOrderItems;
        private MaterialSkin2DotNet.Controls.MaterialComboBox comboOrders;
        private MaterialSkin2DotNet.Controls.MaterialButton btnRefresh;
        private MaterialSkin2DotNet.Controls.MaterialButton btnEdit;
        private MaterialSkin2DotNet.Controls.MaterialButton btnDelete;
        private MaterialSkin2DotNet.Controls.MaterialLabel lblPaid;
        private MaterialSkin2DotNet.Controls.MaterialLabel lblFee;
        private MaterialSkin2DotNet.Controls.MaterialLabel lblTotal;
        private MaterialSkin2DotNet.Controls.MaterialTextBox txtFilterCustomer;
        private MaterialSkin2DotNet.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin2DotNet.Controls.MaterialButton btnDeleteItem;
        private MaterialSkin2DotNet.Controls.MaterialButton btnEditItem;
    }
}
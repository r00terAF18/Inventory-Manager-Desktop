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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboCustomer = new MaterialSkin2DotNet.Controls.MaterialComboBox();
            this.dataTableOrderItems = new MaterialSkin2DotNet.Controls.MaterialDataTable();
            this.comboOrders = new MaterialSkin2DotNet.Controls.MaterialComboBox();
            this.btnRefresh = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.btnEdit = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.btnDelete = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.lblPaid = new MaterialSkin2DotNet.Controls.MaterialLabel();
            this.lblFee = new MaterialSkin2DotNet.Controls.MaterialLabel();
            this.lblTotal = new MaterialSkin2DotNet.Controls.MaterialLabel();
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
            this.comboCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboCustomer.FormattingEnabled = true;
            this.comboCustomer.IntegralHeight = false;
            this.comboCustomer.ItemHeight = 43;
            this.comboCustomer.Location = new System.Drawing.Point(12, 12);
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
            this.dataTableOrderItems.AllowUserToResizeRows = false;
            this.dataTableOrderItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTableOrderItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataTableOrderItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataTableOrderItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataTableOrderItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTableOrderItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataTableOrderItems.ColumnHeadersHeight = 56;
            this.dataTableOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTableOrderItems.DefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTableOrderItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataTableOrderItems.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataTableOrderItems.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataTableOrderItems.RowTemplate.Height = 52;
            this.dataTableOrderItems.ScrollBars = System.Windows.Forms.ScrollBars.None;
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
            this.comboOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboOrders.FormattingEnabled = true;
            this.comboOrders.IntegralHeight = false;
            this.comboOrders.ItemHeight = 43;
            this.comboOrders.Location = new System.Drawing.Point(12, 80);
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
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEdit.Depth = 0;
            this.btnEdit.HighEmphasis = true;
            this.btnEdit.Icon = null;
            this.btnEdit.Location = new System.Drawing.Point(13, 355);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEdit.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(64, 36);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
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
            this.btnDelete.Size = new System.Drawing.Size(73, 36);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
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
            this.lblPaid.Location = new System.Drawing.Point(13, 151);
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
            this.lblFee.Location = new System.Drawing.Point(12, 186);
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
            this.lblTotal.Location = new System.Drawing.Point(12, 220);
            this.lblTotal.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(46, 19);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total: ";
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 523);
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
            this.MdiChildrenMinimizedAnchorBottom = false;
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
    }
}
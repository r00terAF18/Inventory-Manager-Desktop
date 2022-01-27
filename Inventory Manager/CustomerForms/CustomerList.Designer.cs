namespace Inventory_Manager.CustomerForms
{
    partial class CustomerList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerList));
            this.customerTable = new MaterialSkin2DotNet.Controls.MaterialDataTable();
            this.btnRefresh = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.btnDelete = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.lblId = new MaterialSkin2DotNet.Controls.MaterialLabel();
            this.lblFullName = new MaterialSkin2DotNet.Controls.MaterialLabel();
            this.btnAddCustomer = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.txtPhoneNumber = new MaterialSkin2DotNet.Controls.MaterialTextBox();
            this.txtFullName = new MaterialSkin2DotNet.Controls.MaterialTextBox();
            this.btnUpdate = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.txtAddress = new MaterialSkin2DotNet.Controls.MaterialMultiLineTextBox();
            this.btnPayments = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerTable
            // 
            this.customerTable.AllowUserToAddRows = false;
            this.customerTable.AllowUserToDeleteRows = false;
            this.customerTable.AllowUserToOrderColumns = true;
            this.customerTable.AllowUserToResizeRows = false;
            this.customerTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.customerTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.customerTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.customerTable.ColumnHeadersHeight = 56;
            this.customerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customerTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.customerTable.Depth = 0;
            this.customerTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.customerTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.customerTable.EnableHeadersVisualStyles = false;
            this.customerTable.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.customerTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.customerTable.Location = new System.Drawing.Point(0, 0);
            this.customerTable.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.customerTable.MultiSelect = false;
            this.customerTable.Name = "customerTable";
            this.customerTable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.customerTable.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.customerTable.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.customerTable.RowTemplate.Height = 52;
            this.customerTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.customerTable.ShowColorStripping = true;
            this.customerTable.ShowEditingIcon = false;
            this.customerTable.ShowVerticalScroll = false;
            this.customerTable.Size = new System.Drawing.Size(883, 461);
            this.customerTable.TabIndex = 0;
            this.customerTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerTable_CellDoubleClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRefresh.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRefresh.Depth = 0;
            this.btnRefresh.HighEmphasis = true;
            this.btnRefresh.Icon = null;
            this.btnRefresh.Location = new System.Drawing.Point(12, 63);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRefresh.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(84, 36);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRefresh.UseAccentColor = false;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelete.Depth = 0;
            this.btnDelete.HighEmphasis = true;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(104, 63);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(73, 36);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelete.UseAccentColor = false;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Depth = 0;
            this.lblId.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblId.Location = new System.Drawing.Point(671, 118);
            this.lblId.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(1, 0);
            this.lblId.TabIndex = 4;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Depth = 0;
            this.lblFullName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFullName.Location = new System.Drawing.Point(671, 158);
            this.lblFullName.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(1, 0);
            this.lblFullName.TabIndex = 5;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddCustomer.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddCustomer.Depth = 0;
            this.btnAddCustomer.HighEmphasis = true;
            this.btnAddCustomer.Icon = null;
            this.btnAddCustomer.Location = new System.Drawing.Point(183, 63);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddCustomer.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(64, 36);
            this.btnAddCustomer.TabIndex = 8;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddCustomer.UseAccentColor = false;
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoneNumber.Depth = 0;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPhoneNumber.Hint = "Phone Number";
            this.txtPhoneNumber.LeadingIcon = null;
            this.txtPhoneNumber.Location = new System.Drawing.Point(12, 68);
            this.txtPhoneNumber.MaxLength = 20;
            this.txtPhoneNumber.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.txtPhoneNumber.Multiline = false;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(235, 50);
            this.txtPhoneNumber.TabIndex = 7;
            this.txtPhoneNumber.Text = "";
            this.txtPhoneNumber.TrailingIcon = null;
            // 
            // txtFullName
            // 
            this.txtFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFullName.Depth = 0;
            this.txtFullName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFullName.Hint = "Full Name";
            this.txtFullName.LeadingIcon = null;
            this.txtFullName.Location = new System.Drawing.Point(12, 12);
            this.txtFullName.MaxLength = 50;
            this.txtFullName.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.txtFullName.Multiline = false;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(235, 50);
            this.txtFullName.TabIndex = 6;
            this.txtFullName.Text = "";
            this.txtFullName.TrailingIcon = null;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUpdate.Depth = 0;
            this.btnUpdate.HighEmphasis = true;
            this.btnUpdate.Icon = null;
            this.btnUpdate.Location = new System.Drawing.Point(170, 15);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdate.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(77, 36);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdate.UseAccentColor = false;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Depth = 0;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtAddress.Hint = "Address";
            this.txtAddress.Location = new System.Drawing.Point(12, 124);
            this.txtAddress.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(235, 211);
            this.txtAddress.TabIndex = 12;
            this.txtAddress.Text = "";
            // 
            // btnPayments
            // 
            this.btnPayments.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPayments.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPayments.Depth = 0;
            this.btnPayments.HighEmphasis = true;
            this.btnPayments.Icon = null;
            this.btnPayments.Location = new System.Drawing.Point(12, 15);
            this.btnPayments.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPayments.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(99, 36);
            this.btnPayments.TabIndex = 13;
            this.btnPayments.Text = "Payments";
            this.btnPayments.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPayments.UseAccentColor = false;
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(895, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 461);
            this.panel1.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAddCustomer);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Controls.Add(this.btnPayments);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 348);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(254, 113);
            this.panel3.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.txtPhoneNumber);
            this.panel2.Controls.Add(this.txtFullName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 354);
            this.panel2.TabIndex = 15;
            // 
            // CustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.customerTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1165, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1165, 500);
            this.Name = "CustomerList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer List";
            this.Load += new System.EventHandler(this.CustomerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin2DotNet.Controls.MaterialDataTable customerTable;
        private MaterialSkin2DotNet.Controls.MaterialButton btnRefresh;
        private MaterialSkin2DotNet.Controls.MaterialButton btnDelete;
        private MaterialSkin2DotNet.Controls.MaterialLabel lblId;
        private MaterialSkin2DotNet.Controls.MaterialLabel lblFullName;
        private MaterialSkin2DotNet.Controls.MaterialButton btnAddCustomer;
        private MaterialSkin2DotNet.Controls.MaterialTextBox txtPhoneNumber;
        private MaterialSkin2DotNet.Controls.MaterialTextBox txtFullName;
        private MaterialSkin2DotNet.Controls.MaterialButton btnUpdate;
        private MaterialSkin2DotNet.Controls.MaterialMultiLineTextBox txtAddress;
        private MaterialSkin2DotNet.Controls.MaterialButton btnPayments;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}
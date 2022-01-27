namespace Inventory_Manager.PaymentForms
{
    partial class PaymentList
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
            this.paymentTable = new MaterialSkin2DotNet.Controls.MaterialDataTable();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblNumber = new MaterialSkin2DotNet.Controls.MaterialLabel();
            this.lblName = new MaterialSkin2DotNet.Controls.MaterialLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAdd = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.btnDelete = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.btnRefresh = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.btnUpdate = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtComments = new MaterialSkin2DotNet.Controls.MaterialMultiLineTextBox();
            this.txtAmount = new MaterialSkin2DotNet.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // paymentTable
            // 
            this.paymentTable.AllowUserToAddRows = false;
            this.paymentTable.AllowUserToDeleteRows = false;
            this.paymentTable.AllowUserToOrderColumns = true;
            this.paymentTable.AllowUserToResizeRows = false;
            this.paymentTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.paymentTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.paymentTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paymentTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.paymentTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.paymentTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.paymentTable.ColumnHeadersHeight = 56;
            this.paymentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.paymentTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.paymentTable.Depth = 0;
            this.paymentTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.paymentTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.paymentTable.EnableHeadersVisualStyles = false;
            this.paymentTable.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.paymentTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.paymentTable.Location = new System.Drawing.Point(0, 0);
            this.paymentTable.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.paymentTable.MultiSelect = false;
            this.paymentTable.Name = "paymentTable";
            this.paymentTable.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.paymentTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.paymentTable.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.paymentTable.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.paymentTable.RowTemplate.Height = 52;
            this.paymentTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.paymentTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.paymentTable.ShowColorStripping = true;
            this.paymentTable.ShowEditingIcon = false;
            this.paymentTable.ShowVerticalScroll = false;
            this.paymentTable.Size = new System.Drawing.Size(883, 548);
            this.paymentTable.TabIndex = 1;
            this.paymentTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.paymentTable_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(898, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 548);
            this.panel1.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.Controls.Add(this.lblNumber);
            this.panel4.Controls.Add(this.lblName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 338);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(269, 111);
            this.panel4.TabIndex = 16;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Depth = 0;
            this.lblNumber.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNumber.Location = new System.Drawing.Point(80, 36);
            this.lblNumber.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(1, 0);
            this.lblNumber.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Depth = 0;
            this.lblName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblName.Location = new System.Drawing.Point(80, 10);
            this.lblName.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(1, 0);
            this.lblName.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 449);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 99);
            this.panel3.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdd.Depth = 0;
            this.btnAdd.HighEmphasis = true;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(182, 57);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 36);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd.UseAccentColor = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelete.Depth = 0;
            this.btnDelete.HighEmphasis = true;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(103, 57);
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
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRefresh.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRefresh.Depth = 0;
            this.btnRefresh.HighEmphasis = true;
            this.btnRefresh.Icon = null;
            this.btnRefresh.Location = new System.Drawing.Point(11, 57);
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
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUpdate.Depth = 0;
            this.btnUpdate.HighEmphasis = true;
            this.btnUpdate.Icon = null;
            this.btnUpdate.Location = new System.Drawing.Point(100, 9);
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
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.txtComments);
            this.panel2.Controls.Add(this.txtAmount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 338);
            this.panel2.TabIndex = 15;
            // 
            // txtComments
            // 
            this.txtComments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComments.Depth = 0;
            this.txtComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtComments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtComments.Hint = "Address";
            this.txtComments.Location = new System.Drawing.Point(3, 68);
            this.txtComments.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(263, 267);
            this.txtComments.TabIndex = 12;
            this.txtComments.Text = "";
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmount.Depth = 0;
            this.txtAmount.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAmount.Hint = "Amount";
            this.txtAmount.LeadingIcon = null;
            this.txtAmount.Location = new System.Drawing.Point(3, 12);
            this.txtAmount.MaxLength = 50;
            this.txtAmount.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.txtAmount.Multiline = false;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(263, 50);
            this.txtAmount.TabIndex = 6;
            this.txtAmount.Text = "";
            this.txtAmount.TrailingIcon = null;
            // 
            // PaymentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 548);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.paymentTable);
            this.Name = "PaymentList";
            this.Text = "PaymentList";
            this.Load += new System.EventHandler(this.PaymentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paymentTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin2DotNet.Controls.MaterialDataTable paymentTable;
        private Panel panel1;
        private Panel panel3;
        private MaterialSkin2DotNet.Controls.MaterialButton btnAdd;
        private MaterialSkin2DotNet.Controls.MaterialButton btnDelete;
        private MaterialSkin2DotNet.Controls.MaterialButton btnRefresh;
        private MaterialSkin2DotNet.Controls.MaterialButton btnUpdate;
        private Panel panel2;
        private MaterialSkin2DotNet.Controls.MaterialMultiLineTextBox txtComments;
        private MaterialSkin2DotNet.Controls.MaterialTextBox txtAmount;
        private Panel panel4;
        private MaterialSkin2DotNet.Controls.MaterialLabel lblName;
        private MaterialSkin2DotNet.Controls.MaterialLabel lblNumber;
    }
}
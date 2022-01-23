namespace Inventory_Manager.OrderForms
{
    partial class OrderEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderEdit));
            this.btnEditOrder = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.txtTransportFee = new MaterialSkin2DotNet.Controls.MaterialTextBox();
            this.switchPaid = new MaterialSkin2DotNet.Controls.MaterialSwitch();
            this.SuspendLayout();
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditOrder.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditOrder.Depth = 0;
            this.btnEditOrder.HighEmphasis = true;
            this.btnEditOrder.Icon = null;
            this.btnEditOrder.Location = new System.Drawing.Point(12, 111);
            this.btnEditOrder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditOrder.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(127, 36);
            this.btnEditOrder.TabIndex = 7;
            this.btnEditOrder.Text = "Update Order";
            this.btnEditOrder.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditOrder.UseAccentColor = false;
            this.btnEditOrder.UseVisualStyleBackColor = true;
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
            // 
            // txtTransportFee
            // 
            this.txtTransportFee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTransportFee.Depth = 0;
            this.txtTransportFee.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTransportFee.Hint = "Transport Fee";
            this.txtTransportFee.LeadingIcon = null;
            this.txtTransportFee.Location = new System.Drawing.Point(12, 52);
            this.txtTransportFee.MaxLength = 50;
            this.txtTransportFee.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.txtTransportFee.Multiline = false;
            this.txtTransportFee.Name = "txtTransportFee";
            this.txtTransportFee.Size = new System.Drawing.Size(302, 50);
            this.txtTransportFee.TabIndex = 6;
            this.txtTransportFee.Text = "";
            this.txtTransportFee.TrailingIcon = null;
            // 
            // switchPaid
            // 
            this.switchPaid.AutoSize = true;
            this.switchPaid.Depth = 0;
            this.switchPaid.Location = new System.Drawing.Point(12, 12);
            this.switchPaid.Margin = new System.Windows.Forms.Padding(0);
            this.switchPaid.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switchPaid.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.switchPaid.Name = "switchPaid";
            this.switchPaid.Ripple = true;
            this.switchPaid.Size = new System.Drawing.Size(90, 37);
            this.switchPaid.TabIndex = 5;
            this.switchPaid.Text = "Paid";
            this.switchPaid.UseVisualStyleBackColor = true;
            // 
            // OrderEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 165);
            this.Controls.Add(this.btnEditOrder);
            this.Controls.Add(this.txtTransportFee);
            this.Controls.Add(this.switchPaid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(347, 204);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(347, 204);
            this.Name = "OrderEdit";
            this.Text = "Edit Order";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderEdit_FormClosed);
            this.Load += new System.EventHandler(this.OrderEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin2DotNet.Controls.MaterialButton btnEditOrder;
        private MaterialSkin2DotNet.Controls.MaterialTextBox txtTransportFee;
        private MaterialSkin2DotNet.Controls.MaterialSwitch switchPaid;
    }
}
namespace Inventory_Manager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnListCustomer = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.btnListProduct = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.btnListOrder = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.btnAddOrder = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // btnListCustomer
            // 
            this.btnListCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnListCustomer.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnListCustomer.Depth = 0;
            this.btnListCustomer.HighEmphasis = true;
            this.btnListCustomer.Icon = null;
            this.btnListCustomer.Location = new System.Drawing.Point(13, 15);
            this.btnListCustomer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnListCustomer.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnListCustomer.Name = "btnListCustomer";
            this.btnListCustomer.Size = new System.Drawing.Size(133, 36);
            this.btnListCustomer.TabIndex = 1;
            this.btnListCustomer.Text = "List Customer";
            this.btnListCustomer.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnListCustomer.UseAccentColor = false;
            this.btnListCustomer.UseVisualStyleBackColor = true;
            this.btnListCustomer.Click += new System.EventHandler(this.btnListCustomer_Click);
            // 
            // btnListProduct
            // 
            this.btnListProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnListProduct.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnListProduct.Depth = 0;
            this.btnListProduct.HighEmphasis = true;
            this.btnListProduct.Icon = null;
            this.btnListProduct.Location = new System.Drawing.Point(180, 15);
            this.btnListProduct.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnListProduct.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnListProduct.Name = "btnListProduct";
            this.btnListProduct.Size = new System.Drawing.Size(121, 36);
            this.btnListProduct.TabIndex = 3;
            this.btnListProduct.Text = "List Product";
            this.btnListProduct.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnListProduct.UseAccentColor = false;
            this.btnListProduct.UseVisualStyleBackColor = true;
            this.btnListProduct.Click += new System.EventHandler(this.btnListProduct_Click);
            // 
            // btnListOrder
            // 
            this.btnListOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnListOrder.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnListOrder.Depth = 0;
            this.btnListOrder.HighEmphasis = true;
            this.btnListOrder.Icon = null;
            this.btnListOrder.Location = new System.Drawing.Point(354, 63);
            this.btnListOrder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnListOrder.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnListOrder.Name = "btnListOrder";
            this.btnListOrder.Size = new System.Drawing.Size(101, 36);
            this.btnListOrder.TabIndex = 5;
            this.btnListOrder.Text = "List Order";
            this.btnListOrder.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnListOrder.UseAccentColor = false;
            this.btnListOrder.UseVisualStyleBackColor = true;
            this.btnListOrder.Click += new System.EventHandler(this.btnListOrder_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddOrder.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddOrder.Depth = 0;
            this.btnAddOrder.HighEmphasis = true;
            this.btnAddOrder.Icon = null;
            this.btnAddOrder.Location = new System.Drawing.Point(354, 15);
            this.btnAddOrder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddOrder.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(101, 36);
            this.btnAddOrder.TabIndex = 4;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddOrder.UseAccentColor = false;
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(619, 360);
            this.Controls.Add(this.btnListOrder);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.btnListProduct);
            this.Controls.Add(this.btnListCustomer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin2DotNet.Controls.MaterialButton btnListCustomer;
        private MaterialSkin2DotNet.Controls.MaterialButton btnListProduct;
        private MaterialSkin2DotNet.Controls.MaterialButton btnListOrder;
        private MaterialSkin2DotNet.Controls.MaterialButton btnAddOrder;
    }
}
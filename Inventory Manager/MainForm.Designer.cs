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
            this.btnAddCustomer = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.btnListCustomer = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.btnListProduct = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.btnAddProduct = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddCustomer.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddCustomer.Depth = 0;
            this.btnAddCustomer.HighEmphasis = true;
            this.btnAddCustomer.Icon = null;
            this.btnAddCustomer.Location = new System.Drawing.Point(13, 15);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddCustomer.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(132, 36);
            this.btnAddCustomer.TabIndex = 0;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddCustomer.UseAccentColor = false;
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnListCustomer
            // 
            this.btnListCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnListCustomer.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnListCustomer.Depth = 0;
            this.btnListCustomer.HighEmphasis = true;
            this.btnListCustomer.Icon = null;
            this.btnListCustomer.Location = new System.Drawing.Point(13, 63);
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
            this.btnListProduct.Location = new System.Drawing.Point(245, 63);
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
            // btnAddProduct
            // 
            this.btnAddProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddProduct.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddProduct.Depth = 0;
            this.btnAddProduct.HighEmphasis = true;
            this.btnAddProduct.Icon = null;
            this.btnAddProduct.Location = new System.Drawing.Point(245, 15);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddProduct.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(121, 36);
            this.btnAddProduct.TabIndex = 2;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddProduct.UseAccentColor = false;
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(444, 189);
            this.Controls.Add(this.btnListProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnListCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin2DotNet.Controls.MaterialButton btnAddCustomer;
        private MaterialSkin2DotNet.Controls.MaterialButton btnListCustomer;
        private MaterialSkin2DotNet.Controls.MaterialButton btnListProduct;
        private MaterialSkin2DotNet.Controls.MaterialButton btnAddProduct;
    }
}
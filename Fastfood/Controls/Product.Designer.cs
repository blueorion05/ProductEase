namespace Fastfood
{
    partial class Product
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            pbProduct = new PictureBox();
            lblName = new Label();
            lblPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)pbProduct).BeginInit();
            SuspendLayout();
            // 
            // pbProduct
            // 
            pbProduct.BackgroundImage = (Image)resources.GetObject("pbProduct.BackgroundImage");
            pbProduct.BackgroundImageLayout = ImageLayout.Stretch;
            pbProduct.Location = new Point(5, 3);
            pbProduct.Name = "pbProduct";
            pbProduct.Size = new Size(140, 140);
            pbProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProduct.TabIndex = 0;
            pbProduct.TabStop = false;
            pbProduct.Click += pbProduct_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Dock = DockStyle.Bottom;
            lblName.Location = new Point(0, 157);
            lblName.MaximumSize = new Size(148, 0);
            lblName.MinimumSize = new Size(148, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(148, 17);
            lblName.TabIndex = 1;
            lblName.Text = "Product Name";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            lblName.Click += lblName_Click;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.White;
            lblPrice.Dock = DockStyle.Bottom;
            lblPrice.Location = new Point(0, 174);
            lblPrice.MaximumSize = new Size(148, 0);
            lblPrice.MinimumSize = new Size(148, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Padding = new Padding(0, 0, 0, 15);
            lblPrice.Size = new Size(148, 32);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Price";
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            lblPrice.Click += lblPrice_Click;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pbProduct);
            Controls.Add(lblName);
            Controls.Add(lblPrice);
            Cursor = Cursors.Hand;
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Product";
            Size = new Size(148, 206);
            Click += controlProduct_Click;
            ((System.ComponentModel.ISupportInitialize)pbProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox pbProduct;
        public Label lblName;
        public Label lblPrice;
    }
}

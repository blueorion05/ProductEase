namespace Fastfood
{
    partial class controlProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controlProduct));
            pictureBox1 = new PictureBox();
            lblName = new Label();
            lblPrice = new Label();
            c = new controlProduct();
            lblId = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(5, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblName.AutoSize = true;
            lblName.Location = new Point(28, 151);
            lblName.Name = "lblName";
            lblName.Size = new Size(94, 17);
            lblName.TabIndex = 1;
            lblName.Text = "Product Name";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(54, 178);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(38, 17);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Price";
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // c
            // 
            c.BorderStyle = BorderStyle.FixedSingle;
            c.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            c.Location = new Point(0, 0);
            c.Name = "c";
            c.Size = new Size(148, 206);
            c.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblId.AutoSize = true;
            lblId.BackColor = Color.Transparent;
            lblId.ForeColor = Color.Transparent;
            lblId.Location = new Point(28, 41);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 17);
            lblId.TabIndex = 3;
            lblId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // controlProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblName);
            Controls.Add(pictureBox1);
            Controls.Add(lblPrice);
            Controls.Add(lblId);
            Cursor = Cursors.Hand;
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "controlProduct";
            Size = new Size(148, 206);
            Load += controlProduct_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox pictureBox1;
        public Label lblName;
        public Label lblPrice;
        private controlProduct c;
        public Label lblId;
    }
}

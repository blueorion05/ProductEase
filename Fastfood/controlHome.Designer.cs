namespace Fastfood
{
    partial class controlHome
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
            lbl1home = new Label();
            pb1totalorders = new PictureBox();
            lbl2totalorders = new Label();
            pictureBox1 = new PictureBox();
            lbl3totalsales = new Label();
            lbl2totalordersnumbers = new Label();
            lbl3totalsalesnumbers = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pb1totalorders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl1home
            // 
            lbl1home.AutoSize = true;
            lbl1home.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1home.Location = new Point(3, 0);
            lbl1home.Name = "lbl1home";
            lbl1home.Size = new Size(69, 30);
            lbl1home.TabIndex = 0;
            lbl1home.Text = "Home";
            // 
            // pb1totalorders
            // 
            pb1totalorders.BackColor = Color.SteelBlue;
            pb1totalorders.Location = new Point(58, 104);
            pb1totalorders.Name = "pb1totalorders";
            pb1totalorders.Size = new Size(164, 91);
            pb1totalorders.TabIndex = 1;
            pb1totalorders.TabStop = false;
            pb1totalorders.Click += pb1totalorders_Click;
            // 
            // lbl2totalorders
            // 
            lbl2totalorders.AutoSize = true;
            lbl2totalorders.BackColor = Color.SteelBlue;
            lbl2totalorders.ForeColor = Color.White;
            lbl2totalorders.Location = new Point(69, 126);
            lbl2totalorders.Name = "lbl2totalorders";
            lbl2totalorders.Size = new Size(70, 15);
            lbl2totalorders.TabIndex = 2;
            lbl2totalorders.Text = "Total Orders";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SteelBlue;
            pictureBox1.Location = new Point(58, 285);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 91);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lbl3totalsales
            // 
            lbl3totalsales.AutoSize = true;
            lbl3totalsales.BackColor = Color.SteelBlue;
            lbl3totalsales.ForeColor = Color.White;
            lbl3totalsales.Location = new Point(78, 310);
            lbl3totalsales.Name = "lbl3totalsales";
            lbl3totalsales.Size = new Size(61, 15);
            lbl3totalsales.TabIndex = 4;
            lbl3totalsales.Text = "Total Sales";
            // 
            // lbl2totalordersnumbers
            // 
            lbl2totalordersnumbers.AutoSize = true;
            lbl2totalordersnumbers.BackColor = Color.SteelBlue;
            lbl2totalordersnumbers.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl2totalordersnumbers.ForeColor = Color.White;
            lbl2totalordersnumbers.Location = new Point(126, 141);
            lbl2totalordersnumbers.Name = "lbl2totalordersnumbers";
            lbl2totalordersnumbers.Size = new Size(33, 40);
            lbl2totalordersnumbers.TabIndex = 5;
            lbl2totalordersnumbers.Text = "0";
            // 
            // lbl3totalsalesnumbers
            // 
            lbl3totalsalesnumbers.AutoSize = true;
            lbl3totalsalesnumbers.BackColor = Color.SteelBlue;
            lbl3totalsalesnumbers.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl3totalsalesnumbers.ForeColor = Color.White;
            lbl3totalsalesnumbers.Location = new Point(126, 325);
            lbl3totalsalesnumbers.Name = "lbl3totalsalesnumbers";
            lbl3totalsalesnumbers.Size = new Size(33, 40);
            lbl3totalsalesnumbers.TabIndex = 6;
            lbl3totalsalesnumbers.Text = "0";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(lbl3totalsalesnumbers);
            panel1.Controls.Add(lbl3totalsales);
            panel1.Controls.Add(lbl2totalordersnumbers);
            panel1.Controls.Add(lbl2totalorders);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pb1totalorders);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(544, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 586);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // controlHome
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(panel1);
            Controls.Add(lbl1home);
            Name = "controlHome";
            Size = new Size(824, 586);
            Load += controlHome_Load_1;
            ((System.ComponentModel.ISupportInitialize)pb1totalorders).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1home;
        private PictureBox pb1totalorders;
        private Label lbl2totalorders;
        private PictureBox pictureBox1;
        private Label lbl3totalsales;
        private Label lbl2totalordersnumbers;
        private Label lbl3totalsalesnumbers;
        private Panel panel1;
    }
}

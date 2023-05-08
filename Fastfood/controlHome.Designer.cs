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
            pb1totalorders = new PictureBox();
            lbl2totalorders = new Label();
            pictureBox1 = new PictureBox();
            lbl3totalsales = new Label();
            lbl2totalordersnumbers = new Label();
            lbl3totalsalesnumbers = new Label();
            panel1 = new Panel();
            lblWelcome = new Label();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb1totalorders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pb1totalorders
            // 
            pb1totalorders.BackColor = Color.FromArgb(0, 150, 136);
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
            lbl2totalorders.BackColor = Color.FromArgb(0, 150, 136);
            lbl2totalorders.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl2totalorders.ForeColor = Color.White;
            lbl2totalorders.Location = new Point(64, 114);
            lbl2totalorders.Name = "lbl2totalorders";
            lbl2totalorders.Size = new Size(119, 22);
            lbl2totalorders.TabIndex = 2;
            lbl2totalorders.Text = "Total Orders";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(0, 150, 136);
            pictureBox1.Location = new Point(58, 285);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 91);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lbl3totalsales
            // 
            lbl3totalsales.AutoSize = true;
            lbl3totalsales.BackColor = Color.FromArgb(0, 150, 136);
            lbl3totalsales.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl3totalsales.ForeColor = Color.White;
            lbl3totalsales.Location = new Point(64, 295);
            lbl3totalsales.Name = "lbl3totalsales";
            lbl3totalsales.Size = new Size(102, 22);
            lbl3totalsales.TabIndex = 4;
            lbl3totalsales.Text = "Total Sales";
            // 
            // lbl2totalordersnumbers
            // 
            lbl2totalordersnumbers.AutoSize = true;
            lbl2totalordersnumbers.BackColor = Color.FromArgb(0, 150, 136);
            lbl2totalordersnumbers.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl2totalordersnumbers.ForeColor = Color.White;
            lbl2totalordersnumbers.Location = new Point(127, 145);
            lbl2totalordersnumbers.Name = "lbl2totalordersnumbers";
            lbl2totalordersnumbers.Size = new Size(30, 33);
            lbl2totalordersnumbers.TabIndex = 5;
            lbl2totalordersnumbers.Text = "0";
            // 
            // lbl3totalsalesnumbers
            // 
            lbl3totalsalesnumbers.AutoSize = true;
            lbl3totalsalesnumbers.BackColor = Color.FromArgb(0, 150, 136);
            lbl3totalsalesnumbers.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl3totalsalesnumbers.ForeColor = Color.White;
            lbl3totalsalesnumbers.Location = new Point(127, 328);
            lbl3totalsalesnumbers.Name = "lbl3totalsalesnumbers";
            lbl3totalsalesnumbers.Size = new Size(30, 33);
            lbl3totalsalesnumbers.TabIndex = 6;
            lbl3totalsalesnumbers.Text = "0";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lbl3totalsalesnumbers);
            panel1.Controls.Add(lbl3totalsales);
            panel1.Controls.Add(lbl2totalordersnumbers);
            panel1.Controls.Add(lbl2totalorders);
            panel1.Controls.Add(pb1totalorders);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(784, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 654);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Century Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblWelcome.ForeColor = Color.Black;
            lblWelcome.Location = new Point(20, 16);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(180, 42);
            lblWelcome.TabIndex = 8;
            lblWelcome.Text = "Welcome";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox3);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 654);
            panel2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 150, 136);
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(127, 328);
            label1.Name = "label1";
            label1.Size = new Size(30, 33);
            label1.TabIndex = 6;
            label1.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 150, 136);
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(64, 295);
            label2.Name = "label2";
            label2.Size = new Size(102, 22);
            label2.TabIndex = 4;
            label2.Text = "Total Sales";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 150, 136);
            label3.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(127, 145);
            label3.Name = "label3";
            label3.Size = new Size(30, 33);
            label3.TabIndex = 5;
            label3.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 150, 136);
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(64, 114);
            label4.Name = "label4";
            label4.Size = new Size(119, 22);
            label4.TabIndex = 2;
            label4.Text = "Total Orders";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(0, 150, 136);
            pictureBox2.Location = new Point(58, 104);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(164, 91);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(0, 150, 136);
            pictureBox3.Location = new Point(58, 285);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(164, 91);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // controlHome
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            Controls.Add(lblWelcome);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "controlHome";
            Size = new Size(1064, 654);
            Load += controlHome_Load_1;
            ((System.ComponentModel.ISupportInitialize)pb1totalorders).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pb1totalorders;
        private Label lbl2totalorders;
        private PictureBox pictureBox1;
        private Label lbl3totalsales;
        private Label lbl2totalordersnumbers;
        private Label lbl3totalsalesnumbers;
        private Panel panel1;
        private Label lblWelcome;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}

namespace Fastfood
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            groupBox4 = new GroupBox();
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            groupBox6 = new GroupBox();
            groupBox5 = new GroupBox();
            toolStrip1 = new ToolStrip();
            toolStripButton2 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton3 = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripButton4 = new ToolStripButton();
            pictureBox4 = new PictureBox();
            panel3 = new Panel();
            panel2 = new Panel();
            EarnTotalLB = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            OrderTotalLB = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.White;
            groupBox4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(34, 432);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(441, 197);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "PRODUCTS UNAVAILABLE";
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(6, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(1055, 170);
            panel1.TabIndex = 12;
            // 
            // label3
            // 
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(286, 23);
            label3.Name = "label3";
            label3.Size = new Size(559, 129);
            label3.TabIndex = 1;
            label3.Text = resources.GetString("label3.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 26.2499962F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(28, 59);
            label1.Name = "label1";
            label1.Size = new Size(249, 45);
            label1.TabIndex = 0;
            label1.Text = "WELCOME";
            label1.Click += label1_Click;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.White;
            groupBox6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox6.Location = new Point(501, 213);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(231, 197);
            groupBox6.TabIndex = 12;
            groupBox6.TabStop = false;
            groupBox6.Text = "RECENT TRANSACTION";
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.White;
            groupBox5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox5.Location = new Point(786, 213);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(231, 197);
            groupBox5.TabIndex = 13;
            groupBox5.TabStop = false;
            groupBox5.Text = "RECENT PRODUCT ADDED";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton2, toolStripSeparator1, toolStripButton1, toolStripSeparator2, toolStripButton3, toolStripSeparator3, toolStripButton4 });
            toolStrip1.Location = new Point(3, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(430, 38);
            toolStrip1.TabIndex = 14;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.AutoSize = false;
            toolStripButton2.BackColor = Color.FromArgb(0, 150, 136);
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(100, 35);
            toolStripButton2.Text = "THIS MONTH";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 38);
            // 
            // toolStripButton1
            // 
            toolStripButton1.AutoSize = false;
            toolStripButton1.BackColor = Color.FromArgb(0, 150, 136);
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(100, 35);
            toolStripButton1.Text = "LAST 30 DAYS";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 38);
            // 
            // toolStripButton3
            // 
            toolStripButton3.AutoSize = false;
            toolStripButton3.BackColor = Color.FromArgb(0, 150, 136);
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(100, 35);
            toolStripButton3.Text = "LAST 7 DAYS";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 38);
            // 
            // toolStripButton4
            // 
            toolStripButton4.AutoSize = false;
            toolStripButton4.BackColor = Color.FromArgb(0, 150, 136);
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(100, 35);
            toolStripButton4.Text = "TODAY";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(16, 41);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(51, 50);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(toolStrip1);
            panel3.Location = new Point(34, 213);
            panel3.Name = "panel3";
            panel3.Size = new Size(441, 197);
            panel3.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.Controls.Add(EarnTotalLB);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(226, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(212, 132);
            panel2.TabIndex = 15;
            // 
            // EarnTotalLB
            // 
            EarnTotalLB.AutoSize = true;
            EarnTotalLB.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            EarnTotalLB.Location = new Point(121, 55);
            EarnTotalLB.Name = "EarnTotalLB";
            EarnTotalLB.Size = new Size(22, 24);
            EarnTotalLB.TabIndex = 5;
            EarnTotalLB.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(21, 11);
            label4.Name = "label4";
            label4.Size = new Size(106, 17);
            label4.TabIndex = 3;
            label4.Text = "TOTAL EARNING";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(OrderTotalLB);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(pictureBox4);
            panel4.Location = new Point(3, 52);
            panel4.Name = "panel4";
            panel4.Size = new Size(212, 132);
            panel4.TabIndex = 16;
            // 
            // OrderTotalLB
            // 
            OrderTotalLB.AutoSize = true;
            OrderTotalLB.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            OrderTotalLB.Location = new Point(116, 55);
            OrderTotalLB.Name = "OrderTotalLB";
            OrderTotalLB.Size = new Size(22, 24);
            OrderTotalLB.TabIndex = 4;
            OrderTotalLB.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 11);
            label2.Name = "label2";
            label2.Size = new Size(52, 17);
            label2.TabIndex = 1;
            label2.Text = "ORDER";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            Controls.Add(groupBox5);
            Controls.Add(groupBox6);
            Controls.Add(panel1);
            Controls.Add(groupBox4);
            Controls.Add(panel3);
            Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Home";
            Size = new Size(1064, 654);
            Load += controlHome_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox4;
        private Panel panel1;
        private Label label1;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton3;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripButton4;
        private PictureBox pictureBox4;
        private Panel panel3;
        private Panel panel2;
        private Label EarnTotalLB;
        private Label label4;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Label OrderTotalLB;
        private Label label2;
        private Label label3;
    }
}

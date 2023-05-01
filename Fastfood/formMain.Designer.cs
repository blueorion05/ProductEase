namespace Fastfood
{
    partial class formMain
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
            lbl1company = new Label();
            lbl2home = new Label();
            panelMain = new Panel();
            lbl3manage = new Label();
            lbl4order = new Label();
            lbl5records = new Label();
            lbl6account = new Label();
            lbl7logout = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnexit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lbl1company
            // 
            lbl1company.AutoSize = true;
            lbl1company.BackColor = Color.SteelBlue;
            lbl1company.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1company.ForeColor = Color.White;
            lbl1company.Location = new Point(12, 26);
            lbl1company.Name = "lbl1company";
            lbl1company.Size = new Size(125, 32);
            lbl1company.TabIndex = 0;
            lbl1company.Text = "COMPANY";
            // 
            // lbl2home
            // 
            lbl2home.AutoSize = true;
            lbl2home.BackColor = Color.SteelBlue;
            lbl2home.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl2home.ForeColor = Color.White;
            lbl2home.Location = new Point(35, 95);
            lbl2home.Name = "lbl2home";
            lbl2home.Size = new Size(62, 25);
            lbl2home.TabIndex = 1;
            lbl2home.Text = "Home";
            lbl2home.Click += lbl2home_Click;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(163, 32);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(824, 586);
            panelMain.TabIndex = 2;
            // 
            // lbl3manage
            // 
            lbl3manage.AutoSize = true;
            lbl3manage.BackColor = Color.SteelBlue;
            lbl3manage.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl3manage.ForeColor = Color.White;
            lbl3manage.Location = new Point(35, 145);
            lbl3manage.Name = "lbl3manage";
            lbl3manage.Size = new Size(81, 25);
            lbl3manage.TabIndex = 3;
            lbl3manage.Text = "Manage";
            lbl3manage.Click += lbl3manage_Click;
            // 
            // lbl4order
            // 
            lbl4order.AutoSize = true;
            lbl4order.BackColor = Color.SteelBlue;
            lbl4order.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl4order.ForeColor = Color.White;
            lbl4order.Location = new Point(35, 195);
            lbl4order.Name = "lbl4order";
            lbl4order.Size = new Size(61, 25);
            lbl4order.TabIndex = 4;
            lbl4order.Text = "Order";
            lbl4order.Click += lbl4order_Click;
            // 
            // lbl5records
            // 
            lbl5records.AutoSize = true;
            lbl5records.BackColor = Color.SteelBlue;
            lbl5records.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl5records.ForeColor = Color.White;
            lbl5records.Location = new Point(35, 245);
            lbl5records.Name = "lbl5records";
            lbl5records.Size = new Size(78, 25);
            lbl5records.TabIndex = 5;
            lbl5records.Text = "Records";
            lbl5records.Click += lbl5records_Click;
            // 
            // lbl6account
            // 
            lbl6account.AutoSize = true;
            lbl6account.BackColor = Color.SteelBlue;
            lbl6account.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl6account.ForeColor = Color.White;
            lbl6account.Location = new Point(35, 295);
            lbl6account.Name = "lbl6account";
            lbl6account.Size = new Size(81, 25);
            lbl6account.TabIndex = 6;
            lbl6account.Text = "Account";
            lbl6account.Click += lbl6account_Click;
            // 
            // lbl7logout
            // 
            lbl7logout.AutoSize = true;
            lbl7logout.BackColor = Color.SteelBlue;
            lbl7logout.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl7logout.ForeColor = Color.White;
            lbl7logout.Location = new Point(35, 345);
            lbl7logout.Name = "lbl7logout";
            lbl7logout.Size = new Size(71, 25);
            lbl7logout.TabIndex = 7;
            lbl7logout.Text = "Logout";
            lbl7logout.Click += lbl7logout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SteelBlue;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 618);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkCyan;
            panel2.Controls.Add(btnexit);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(163, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(824, 32);
            panel2.TabIndex = 8;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(777, 4);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(36, 22);
            btnexit.TabIndex = 0;
            btnexit.Text = "X";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // formMain
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(987, 618);
            Controls.Add(panelMain);
            Controls.Add(panel2);
            Controls.Add(lbl7logout);
            Controls.Add(lbl6account);
            Controls.Add(lbl5records);
            Controls.Add(lbl4order);
            Controls.Add(lbl3manage);
            Controls.Add(lbl2home);
            Controls.Add(lbl1company);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1company;
        private Label lbl2home;
        private Panel panelMain;
        private Label lbl3manage;
        private Label lbl4order;
        private Label lbl5records;
        private Label lbl6account;
        private Label lbl7logout;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btnexit;
    }
}
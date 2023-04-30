namespace Fastfood
{
    partial class Form2
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
            panel1 = new Panel();
            lbl3manage = new Label();
            lbl4order = new Label();
            lbl5records = new Label();
            lbl6account = new Label();
            lbl7logout = new Label();
            SuspendLayout();
            // 
            // lbl1company
            // 
            lbl1company.AutoSize = true;
            lbl1company.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1company.Location = new Point(12, 9);
            lbl1company.Name = "lbl1company";
            lbl1company.Size = new Size(125, 32);
            lbl1company.TabIndex = 0;
            lbl1company.Text = "COMPANY";
            // 
            // lbl2home
            // 
            lbl2home.AutoSize = true;
            lbl2home.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl2home.Location = new Point(35, 61);
            lbl2home.Name = "lbl2home";
            lbl2home.Size = new Size(62, 25);
            lbl2home.TabIndex = 1;
            lbl2home.Text = "Home";
            lbl2home.Click += lbl2home_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(162, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(735, 424);
            panel1.TabIndex = 2;
            // 
            // lbl3manage
            // 
            lbl3manage.AutoSize = true;
            lbl3manage.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl3manage.Location = new Point(35, 111);
            lbl3manage.Name = "lbl3manage";
            lbl3manage.Size = new Size(81, 25);
            lbl3manage.TabIndex = 3;
            lbl3manage.Text = "Manage";
            lbl3manage.Click += lbl3manage_Click;
            // 
            // lbl4order
            // 
            lbl4order.AutoSize = true;
            lbl4order.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl4order.Location = new Point(35, 161);
            lbl4order.Name = "lbl4order";
            lbl4order.Size = new Size(61, 25);
            lbl4order.TabIndex = 4;
            lbl4order.Text = "Order";
            lbl4order.Click += lbl4order_Click;
            // 
            // lbl5records
            // 
            lbl5records.AutoSize = true;
            lbl5records.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl5records.Location = new Point(35, 211);
            lbl5records.Name = "lbl5records";
            lbl5records.Size = new Size(78, 25);
            lbl5records.TabIndex = 5;
            lbl5records.Text = "Records";
            lbl5records.Click += lbl5records_Click;
            // 
            // lbl6account
            // 
            lbl6account.AutoSize = true;
            lbl6account.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl6account.Location = new Point(35, 261);
            lbl6account.Name = "lbl6account";
            lbl6account.Size = new Size(81, 25);
            lbl6account.TabIndex = 6;
            lbl6account.Text = "Account";
            lbl6account.Click += lbl6account_Click;
            // 
            // lbl7logout
            // 
            lbl7logout.AutoSize = true;
            lbl7logout.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl7logout.Location = new Point(35, 311);
            lbl7logout.Name = "lbl7logout";
            lbl7logout.Size = new Size(71, 25);
            lbl7logout.TabIndex = 7;
            lbl7logout.Text = "Logout";
            lbl7logout.Click += lbl7logout_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 450);
            Controls.Add(lbl7logout);
            Controls.Add(lbl6account);
            Controls.Add(lbl5records);
            Controls.Add(lbl4order);
            Controls.Add(lbl3manage);
            Controls.Add(panel1);
            Controls.Add(lbl2home);
            Controls.Add(lbl1company);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1company;
        private Label lbl2home;
        private Panel panel1;
        private Label lbl3manage;
        private Label lbl4order;
        private Label lbl5records;
        private Label lbl6account;
        private Label lbl7logout;
    }
}
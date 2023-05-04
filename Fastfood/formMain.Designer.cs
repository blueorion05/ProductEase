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
            panelMain = new Panel();
            panel2 = new Panel();
            btnMinimize = new Button();
            btnexit = new Button();
            panel1 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            btnLogout = new Button();
            btnAccount = new Button();
            btnRecords = new Button();
            btnOrder = new Button();
            btnManage = new Button();
            btnHome = new Button();
            button2 = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lbl1company
            // 
            lbl1company.AutoSize = true;
            lbl1company.BackColor = Color.Transparent;
            lbl1company.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1company.ForeColor = Color.White;
            lbl1company.Location = new Point(44, 18);
            lbl1company.Name = "lbl1company";
            lbl1company.Size = new Size(125, 32);
            lbl1company.TabIndex = 0;
            lbl1company.Text = "COMPANY";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.WhiteSmoke;
            panelMain.Location = new Point(215, 66);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1064, 654);
            panelMain.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 150, 136);
            panel2.Controls.Add(btnMinimize);
            panel2.Controls.Add(btnexit);
            panel2.Location = new Point(215, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1064, 64);
            panel2.TabIndex = 8;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.FromArgb(0, 150, 136);
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(987, 4);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(30, 22);
            btnMinimize.TabIndex = 1;
            btnMinimize.Text = "--";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnexit
            // 
            btnexit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnexit.BackColor = Color.FromArgb(0, 150, 136);
            btnexit.FlatAppearance.BorderSize = 0;
            btnexit.FlatStyle = FlatStyle.Flat;
            btnexit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnexit.ForeColor = Color.White;
            btnexit.Location = new Point(1023, 4);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(30, 22);
            btnexit.TabIndex = 0;
            btnexit.Text = "X";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 39, 58);
            panel1.Controls.Add(lbl1company);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(217, 64);
            panel1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(1087, 4);
            button1.Name = "button1";
            button1.Size = new Size(36, 22);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(51, 51, 76);
            panel3.Controls.Add(btnLogout);
            panel3.Controls.Add(btnAccount);
            panel3.Controls.Add(btnRecords);
            panel3.Controls.Add(btnOrder);
            panel3.Controls.Add(btnManage);
            panel3.Controls.Add(btnHome);
            panel3.Controls.Add(button2);
            panel3.Location = new Point(0, 67);
            panel3.Name = "panel3";
            panel3.Size = new Size(216, 653);
            panel3.TabIndex = 10;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(51, 51, 76);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 356);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(217, 64);
            btnLogout.TabIndex = 12;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnAccount
            // 
            btnAccount.BackColor = Color.FromArgb(51, 51, 76);
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.FlatStyle = FlatStyle.Flat;
            btnAccount.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAccount.ForeColor = Color.White;
            btnAccount.Location = new Point(0, 286);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(217, 64);
            btnAccount.TabIndex = 11;
            btnAccount.Text = "Account";
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnRecords
            // 
            btnRecords.BackColor = Color.FromArgb(51, 51, 76);
            btnRecords.FlatAppearance.BorderSize = 0;
            btnRecords.FlatStyle = FlatStyle.Flat;
            btnRecords.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRecords.ForeColor = Color.White;
            btnRecords.Location = new Point(0, 216);
            btnRecords.Name = "btnRecords";
            btnRecords.Size = new Size(217, 64);
            btnRecords.TabIndex = 10;
            btnRecords.Text = "Records";
            btnRecords.UseVisualStyleBackColor = false;
            btnRecords.Click += btnRecords_Click;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.FromArgb(51, 51, 76);
            btnOrder.FlatAppearance.BorderSize = 0;
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrder.ForeColor = Color.White;
            btnOrder.Location = new Point(0, 146);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(217, 64);
            btnOrder.TabIndex = 9;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnManage
            // 
            btnManage.BackColor = Color.FromArgb(51, 51, 76);
            btnManage.FlatAppearance.BorderSize = 0;
            btnManage.FlatStyle = FlatStyle.Flat;
            btnManage.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnManage.ForeColor = Color.White;
            btnManage.Location = new Point(0, 76);
            btnManage.Name = "btnManage";
            btnManage.Size = new Size(217, 64);
            btnManage.TabIndex = 8;
            btnManage.Text = "Manage";
            btnManage.UseVisualStyleBackColor = false;
            btnManage.Click += btnManage_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(51, 51, 76);
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(0, 6);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(217, 64);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Location = new Point(1102, 4);
            button2.Name = "button2";
            button2.Size = new Size(36, 22);
            button2.TabIndex = 0;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = true;
            // 
            // formMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.FromArgb(51, 51, 76);
            ClientSize = new Size(1280, 720);
            Controls.Add(panelMain);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "formMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += Form2_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lbl1company;
        public Panel panelMain;
        private Panel panel2;
        private Button btnexit;
        private Panel panel1;
        private Button button1;
        private Panel panel3;
        private Button button2;
        private Button btnHome;
        private Button btnLogout;
        private Button btnAccount;
        private Button btnRecords;
        private Button btnOrder;
        private Button btnManage;
        private Button btnMinimize;
    }
}
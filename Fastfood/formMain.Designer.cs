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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            lbl1company = new Label();
            panelMain = new Panel();
            panel2 = new Panel();
            pbActive = new PictureBox();
            btnMinimize = new Button();
            btnExit = new Button();
            panel1 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            lblDateTime = new Label();
            btnLogout = new Button();
            btnAccount = new Button();
            btnRecords = new Button();
            btnOrder = new Button();
            btnManage = new Button();
            btnHome = new Button();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbActive).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lbl1company
            // 
            lbl1company.AutoSize = true;
            lbl1company.BackColor = Color.Transparent;
            lbl1company.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1company.ForeColor = Color.White;
            lbl1company.Location = new Point(36, 44);
            lbl1company.Name = "lbl1company";
            lbl1company.Size = new Size(142, 30);
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
            panel2.BackColor = Color.FromArgb(25, 26, 62);
            panel2.Controls.Add(pbActive);
            panel2.Controls.Add(btnMinimize);
            panel2.Controls.Add(btnExit);
            panel2.Location = new Point(215, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1064, 64);
            panel2.TabIndex = 8;
            // 
            // pbActive
            // 
            pbActive.BackgroundImageLayout = ImageLayout.Center;
            pbActive.Location = new Point(23, 18);
            pbActive.Name = "pbActive";
            pbActive.Size = new Size(27, 27);
            pbActive.TabIndex = 16;
            pbActive.TabStop = false;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.Location = new Point(1000, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(30, 25);
            btnMinimize.TabIndex = 1;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.Transparent;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseOverBackColor = Color.Red;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(1032, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(30, 25);
            btnExit.TabIndex = 0;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnexit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 30, 68);
            panel1.Controls.Add(lbl1company);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(217, 126);
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
            panel3.BackColor = Color.FromArgb(31, 30, 68);
            panel3.Controls.Add(lblDateTime);
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
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.BackColor = Color.Transparent;
            lblDateTime.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateTime.ForeColor = Color.White;
            lblDateTime.Location = new Point(24, 627);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(169, 17);
            lblDateTime.TabIndex = 13;
            lblDateTime.Text = "dd-MMM-yyyy hh:mm:ss tt";
            lblDateTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(31, 30, 68);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 414);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(15, 0, 0, 0);
            btnLogout.Size = new Size(217, 64);
            btnLogout.TabIndex = 12;
            btnLogout.Text = "     Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnAccount
            // 
            btnAccount.BackColor = Color.FromArgb(31, 30, 68);
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.FlatStyle = FlatStyle.Flat;
            btnAccount.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAccount.ForeColor = Color.White;
            btnAccount.Image = (Image)resources.GetObject("btnAccount.Image");
            btnAccount.ImageAlign = ContentAlignment.MiddleLeft;
            btnAccount.Location = new Point(0, 344);
            btnAccount.Name = "btnAccount";
            btnAccount.Padding = new Padding(15, 0, 0, 0);
            btnAccount.Size = new Size(217, 64);
            btnAccount.TabIndex = 11;
            btnAccount.Text = "     Account";
            btnAccount.TextAlign = ContentAlignment.MiddleLeft;
            btnAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnRecords
            // 
            btnRecords.BackColor = Color.FromArgb(31, 30, 68);
            btnRecords.FlatAppearance.BorderSize = 0;
            btnRecords.FlatStyle = FlatStyle.Flat;
            btnRecords.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRecords.ForeColor = Color.White;
            btnRecords.Image = (Image)resources.GetObject("btnRecords.Image");
            btnRecords.ImageAlign = ContentAlignment.MiddleLeft;
            btnRecords.Location = new Point(0, 274);
            btnRecords.Name = "btnRecords";
            btnRecords.Padding = new Padding(15, 0, 0, 0);
            btnRecords.Size = new Size(217, 64);
            btnRecords.TabIndex = 10;
            btnRecords.Text = "     Records";
            btnRecords.TextAlign = ContentAlignment.MiddleLeft;
            btnRecords.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRecords.UseVisualStyleBackColor = false;
            btnRecords.Click += btnRecords_Click;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.FromArgb(31, 30, 68);
            btnOrder.FlatAppearance.BorderSize = 0;
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrder.ForeColor = Color.White;
            btnOrder.Image = (Image)resources.GetObject("btnOrder.Image");
            btnOrder.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrder.Location = new Point(0, 204);
            btnOrder.Name = "btnOrder";
            btnOrder.Padding = new Padding(15, 0, 0, 0);
            btnOrder.Size = new Size(217, 64);
            btnOrder.TabIndex = 9;
            btnOrder.Text = "     Order";
            btnOrder.TextAlign = ContentAlignment.MiddleLeft;
            btnOrder.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnManage
            // 
            btnManage.BackColor = Color.FromArgb(31, 30, 68);
            btnManage.FlatAppearance.BorderSize = 0;
            btnManage.FlatStyle = FlatStyle.Flat;
            btnManage.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnManage.ForeColor = Color.White;
            btnManage.Image = (Image)resources.GetObject("btnManage.Image");
            btnManage.ImageAlign = ContentAlignment.MiddleLeft;
            btnManage.Location = new Point(0, 134);
            btnManage.Name = "btnManage";
            btnManage.Padding = new Padding(15, 0, 0, 0);
            btnManage.Size = new Size(217, 64);
            btnManage.TabIndex = 8;
            btnManage.Text = "     Manage";
            btnManage.TextAlign = ContentAlignment.MiddleLeft;
            btnManage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnManage.UseVisualStyleBackColor = false;
            btnManage.Click += btnManage_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(31, 30, 68);
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 64);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(15, 0, 0, 0);
            btnHome.Size = new Size(217, 64);
            btnHome.TabIndex = 0;
            btnHome.Text = "     Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
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
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // formMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.FromArgb(31, 30, 68);
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
            ((System.ComponentModel.ISupportInitialize)pbActive).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl1company;
        public Panel panelMain;
        private Panel panel2;
        private Button btnExit;
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
        private PictureBox pbActive;
        private Label lblDateTime;
        private System.Windows.Forms.Timer timer1;
    }
}
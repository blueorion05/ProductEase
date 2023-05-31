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
            lbl1Company = new Label();
            panelMain = new Panel();
            panelHeader = new Panel();
            button1 = new Button();
            pbActive = new PictureBox();
            btnMinimize = new Button();
            btnExit = new Button();
            panelCompany = new Panel();
            panelMenu = new Panel();
            lblDateTime = new Label();
            btnLogout = new Button();
            btnSettings = new Button();
            btnTransactions = new Button();
            btnPOS = new Button();
            btnManage = new Button();
            btnHome = new Button();
            timerDateTime = new System.Windows.Forms.Timer(components);
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbActive).BeginInit();
            panelCompany.SuspendLayout();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // lbl1Company
            // 
            lbl1Company.AutoSize = true;
            lbl1Company.BackColor = Color.Transparent;
            lbl1Company.Dock = DockStyle.Top;
            lbl1Company.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1Company.ForeColor = Color.White;
            lbl1Company.Location = new Point(0, 0);
            lbl1Company.MaximumSize = new Size(216, 0);
            lbl1Company.MinimumSize = new Size(216, 0);
            lbl1Company.Name = "lbl1Company";
            lbl1Company.Padding = new Padding(0, 20, 0, 0);
            lbl1Company.Size = new Size(216, 50);
            lbl1Company.TabIndex = 0;
            lbl1Company.Text = "COMPANY";
            lbl1Company.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMain.BackColor = Color.WhiteSmoke;
            panelMain.Location = new Point(215, 66);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1064, 654);
            panelMain.TabIndex = 2;
            // 
            // panelHeader
            // 
            panelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelHeader.BackColor = Color.FromArgb(25, 26, 62);
            panelHeader.Controls.Add(button1);
            panelHeader.Controls.Add(pbActive);
            panelHeader.Controls.Add(btnMinimize);
            panelHeader.Controls.Add(btnExit);
            panelHeader.Location = new Point(215, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1065, 720);
            panelHeader.TabIndex = 8;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(1003, 0);
            button1.Name = "button1";
            button1.Size = new Size(30, 25);
            button1.TabIndex = 17;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            btnMinimize.Location = new Point(971, 0);
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
            btnExit.Location = new Point(1035, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(30, 25);
            btnExit.TabIndex = 0;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnexit_Click;
            // 
            // panelCompany
            // 
            panelCompany.BackColor = Color.FromArgb(31, 30, 68);
            panelCompany.Controls.Add(lbl1Company);
            panelCompany.Location = new Point(-1, 3);
            panelCompany.Name = "panelCompany";
            panelCompany.Size = new Size(217, 126);
            panelCompany.TabIndex = 9;
            // 
            // panelMenu
            // 
            panelMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelMenu.BackColor = Color.FromArgb(31, 30, 68);
            panelMenu.Controls.Add(lblDateTime);
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Controls.Add(btnSettings);
            panelMenu.Controls.Add(btnTransactions);
            panelMenu.Controls.Add(btnPOS);
            panelMenu.Controls.Add(btnManage);
            panelMenu.Controls.Add(btnHome);
            panelMenu.Location = new Point(0, 67);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(216, 653);
            panelMenu.TabIndex = 10;
            // 
            // lblDateTime
            // 
            lblDateTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDateTime.AutoSize = true;
            lblDateTime.BackColor = Color.Transparent;
            lblDateTime.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateTime.ForeColor = Color.White;
            lblDateTime.Location = new Point(0, 616);
            lblDateTime.MaximumSize = new Size(216, 0);
            lblDateTime.MinimumSize = new Size(216, 0);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Padding = new Padding(0, 0, 0, 20);
            lblDateTime.Size = new Size(216, 37);
            lblDateTime.TabIndex = 13;
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
            // btnSettings
            // 
            btnSettings.BackColor = Color.FromArgb(31, 30, 68);
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSettings.ForeColor = Color.White;
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(0, 344);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(15, 0, 0, 0);
            btnSettings.Size = new Size(217, 64);
            btnSettings.TabIndex = 11;
            btnSettings.Text = "     Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnAccount_Click;
            // 
            // btnTransactions
            // 
            btnTransactions.BackColor = Color.FromArgb(31, 30, 68);
            btnTransactions.FlatAppearance.BorderSize = 0;
            btnTransactions.FlatStyle = FlatStyle.Flat;
            btnTransactions.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnTransactions.ForeColor = Color.White;
            btnTransactions.Image = (Image)resources.GetObject("btnTransactions.Image");
            btnTransactions.ImageAlign = ContentAlignment.MiddleLeft;
            btnTransactions.Location = new Point(0, 274);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Padding = new Padding(15, 0, 0, 0);
            btnTransactions.Size = new Size(217, 64);
            btnTransactions.TabIndex = 10;
            btnTransactions.Text = "     Transactions";
            btnTransactions.TextAlign = ContentAlignment.MiddleLeft;
            btnTransactions.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTransactions.UseVisualStyleBackColor = false;
            btnTransactions.Click += btnRecords_Click;
            // 
            // btnPOS
            // 
            btnPOS.BackColor = Color.FromArgb(31, 30, 68);
            btnPOS.FlatAppearance.BorderSize = 0;
            btnPOS.FlatStyle = FlatStyle.Flat;
            btnPOS.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPOS.ForeColor = Color.White;
            btnPOS.Image = (Image)resources.GetObject("btnPOS.Image");
            btnPOS.ImageAlign = ContentAlignment.MiddleLeft;
            btnPOS.Location = new Point(0, 204);
            btnPOS.Name = "btnPOS";
            btnPOS.Padding = new Padding(15, 0, 0, 0);
            btnPOS.Size = new Size(217, 64);
            btnPOS.TabIndex = 9;
            btnPOS.Text = "     POS";
            btnPOS.TextAlign = ContentAlignment.MiddleLeft;
            btnPOS.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPOS.UseVisualStyleBackColor = false;
            btnPOS.Click += btnOrder_Click;
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
            // timerDateTime
            // 
            timerDateTime.Enabled = true;
            timerDateTime.Interval = 1000;
            timerDateTime.Tick += timer1_Tick;
            // 
            // formMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.FromArgb(31, 30, 68);
            ClientSize = new Size(1280, 720);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            Controls.Add(panelCompany);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "formMain";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form2_Load;
            panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbActive).EndInit();
            panelCompany.ResumeLayout(false);
            panelCompany.PerformLayout();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Label lbl1Company;
        public Panel panelMain;
        private Panel panelHeader;
        private Button btnExit;
        private Panel panelCompany;
        private Panel panelMenu;
        private Button btnHome;
        private Button btnLogout;
        private Button btnSettings;
        private Button btnTransactions;
        private Button btnPOS;
        private Button btnManage;
        private Button btnMinimize;
        private PictureBox pbActive;
        private Label lblDateTime;
        private System.Windows.Forms.Timer timerDateTime;
        private Button button1;
    }
}
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
            pbActive = new PictureBox();
            btnMinimize = new Button();
            btnExit = new Button();
            panelCompany = new Panel();
            panelMenu = new Panel();
            lblDateTime = new Label();
            btnLogout = new Button();
            btnAccount = new Button();
            btnRecords = new Button();
            btnOrder = new Button();
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
            lbl1Company.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1Company.ForeColor = Color.White;
            lbl1Company.Location = new Point(36, 44);
            lbl1Company.Name = "lbl1Company";
            lbl1Company.Size = new Size(142, 30);
            lbl1Company.TabIndex = 0;
            lbl1Company.Text = "COMPANY";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.WhiteSmoke;
            panelMain.Location = new Point(215, 66);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1064, 654);
            panelMain.TabIndex = 2;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(25, 26, 62);
            panelHeader.Controls.Add(pbActive);
            panelHeader.Controls.Add(btnMinimize);
            panelHeader.Controls.Add(btnExit);
            panelHeader.Location = new Point(215, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1064, 64);
            panelHeader.TabIndex = 8;
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
            panelMenu.BackColor = Color.FromArgb(31, 30, 68);
            panelMenu.Controls.Add(lblDateTime);
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Controls.Add(btnAccount);
            panelMenu.Controls.Add(btnRecords);
            panelMenu.Controls.Add(btnOrder);
            panelMenu.Controls.Add(btnManage);
            panelMenu.Controls.Add(btnHome);
            panelMenu.Location = new Point(0, 67);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(216, 653);
            panelMenu.TabIndex = 10;
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.BackColor = Color.Transparent;
            lblDateTime.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateTime.ForeColor = Color.White;
            lblDateTime.Location = new Point(24, 627);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(0, 17);
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
            Text = "Main";
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

        private Label lbl1Company;
        public Panel panelMain;
        private Panel panelHeader;
        private Button btnExit;
        private Panel panelCompany;
        private Panel panelMenu;
        private Button btnHome;
        private Button btnLogout;
        private Button btnAccount;
        private Button btnRecords;
        private Button btnOrder;
        private Button btnManage;
        private Button btnMinimize;
        private PictureBox pbActive;
        private Label lblDateTime;
        private System.Windows.Forms.Timer timerDateTime;
    }
}
namespace Fastfood
{
    partial class formLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            btnLogin = new Button();
            btnExit = new Button();
            lblWelcome = new Label();
            tbUser = new TextBox();
            tbPass = new TextBox();
            pbUser = new PictureBox();
            pbPass = new PictureBox();
            panelHeader = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPass).BeginInit();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 150, 136);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(259, 258);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(102, 46);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnlogin_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(0, 150, 136);
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(391, 258);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(102, 46);
            btnExit.TabIndex = 6;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnexit_Click_1;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblWelcome.ForeColor = SystemColors.ButtonHighlight;
            lblWelcome.Location = new Point(12, 150);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(179, 39);
            lblWelcome.TabIndex = 10;
            lblWelcome.Text = "WELCOME";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbUser
            // 
            tbUser.BorderStyle = BorderStyle.FixedSingle;
            tbUser.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbUser.Location = new Point(292, 161);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(201, 23);
            tbUser.TabIndex = 2;
            // 
            // tbPass
            // 
            tbPass.BorderStyle = BorderStyle.FixedSingle;
            tbPass.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbPass.Location = new Point(292, 199);
            tbPass.Name = "tbPass";
            tbPass.PasswordChar = '*';
            tbPass.Size = new Size(201, 23);
            tbPass.TabIndex = 3;
            tbPass.UseSystemPasswordChar = true;
            // 
            // pbUser
            // 
            pbUser.Image = (Image)resources.GetObject("pbUser.Image");
            pbUser.Location = new Point(259, 157);
            pbUser.Name = "pbUser";
            pbUser.Size = new Size(27, 27);
            pbUser.SizeMode = PictureBoxSizeMode.CenterImage;
            pbUser.TabIndex = 7;
            pbUser.TabStop = false;
            // 
            // pbPass
            // 
            pbPass.Image = (Image)resources.GetObject("pbPass.Image");
            pbPass.Location = new Point(259, 199);
            pbPass.Name = "pbPass";
            pbPass.Size = new Size(27, 27);
            pbPass.SizeMode = PictureBoxSizeMode.CenterImage;
            pbPass.TabIndex = 8;
            pbPass.TabStop = false;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(25, 26, 62);
            panelHeader.Controls.Add(lblWelcome);
            panelHeader.Dock = DockStyle.Left;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(207, 386);
            panelHeader.TabIndex = 11;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(546, 386);
            Controls.Add(panelHeader);
            Controls.Add(pbPass);
            Controls.Add(tbPass);
            Controls.Add(pbUser);
            Controls.Add(btnExit);
            Controls.Add(tbUser);
            Controls.Add(btnLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPass).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLogin;
        private Button btnExit;
        private Label lblWelcome;
        public TextBox tbUser;
        public TextBox tbPass;
        private PictureBox pbUser;
        private PictureBox pbPass;
        private Panel panelHeader;
    }
}
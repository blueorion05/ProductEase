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
            btnlogin = new Button();
            btnexit = new Button();
            label1 = new Label();
            tbuser = new TextBox();
            tbpass = new TextBox();
            pbUser = new PictureBox();
            pbPass = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPass).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.FromArgb(0, 150, 136);
            btnlogin.FlatAppearance.BorderSize = 0;
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnlogin.ForeColor = Color.White;
            btnlogin.Location = new Point(259, 258);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(102, 46);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "LOGIN";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // btnexit
            // 
            btnexit.BackColor = Color.FromArgb(0, 150, 136);
            btnexit.FlatAppearance.BorderSize = 0;
            btnexit.FlatStyle = FlatStyle.Flat;
            btnexit.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnexit.ForeColor = Color.White;
            btnexit.Location = new Point(391, 258);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(102, 46);
            btnexit.TabIndex = 6;
            btnexit.Text = "EXIT";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 150);
            label1.Name = "label1";
            label1.Size = new Size(179, 39);
            label1.TabIndex = 10;
            label1.Text = "WELCOME";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbuser
            // 
            tbuser.BorderStyle = BorderStyle.FixedSingle;
            tbuser.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbuser.Location = new Point(292, 199);
            tbuser.Name = "tbuser";
            tbuser.Size = new Size(201, 23);
            tbuser.TabIndex = 2;
            // 
            // tbpass
            // 
            tbpass.BorderStyle = BorderStyle.FixedSingle;
            tbpass.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbpass.Location = new Point(292, 161);
            tbpass.Name = "tbpass";
            tbpass.PasswordChar = '*';
            tbpass.Size = new Size(201, 23);
            tbpass.TabIndex = 3;
            tbpass.UseSystemPasswordChar = true;
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 26, 62);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 386);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint_1;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(546, 386);
            Controls.Add(panel1);
            Controls.Add(pbPass);
            Controls.Add(tbpass);
            Controls.Add(pbUser);
            Controls.Add(btnexit);
            Controls.Add(tbuser);
            Controls.Add(btnlogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPass).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnlogin;
        private Button btnexit;
        private Label label1;
        private TextBox tbuser;
        private TextBox tbpass;
        private PictureBox pbUser;
        private PictureBox pbPass;
        private Panel panel1;
    }
}
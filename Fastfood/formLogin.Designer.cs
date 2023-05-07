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
            tbuser = new TextBox();
            tbpass = new TextBox();
            btnlogin = new Button();
            panel1 = new Panel();
            btnexit = new Button();
            pbUser = new PictureBox();
            pbPass = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPass).BeginInit();
            SuspendLayout();
            // 
            // tbuser
            // 
            tbuser.BorderStyle = BorderStyle.FixedSingle;
            tbuser.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbuser.Location = new Point(75, 227);
            tbuser.Name = "tbuser";
            tbuser.Size = new Size(201, 23);
            tbuser.TabIndex = 2;
            // 
            // tbpass
            // 
            tbpass.BorderStyle = BorderStyle.FixedSingle;
            tbpass.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbpass.Location = new Point(75, 282);
            tbpass.Name = "tbpass";
            tbpass.PasswordChar = '*';
            tbpass.Size = new Size(201, 23);
            tbpass.TabIndex = 3;
            tbpass.UseSystemPasswordChar = true;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.FromArgb(0, 150, 136);
            btnlogin.FlatAppearance.BorderSize = 0;
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnlogin.ForeColor = Color.White;
            btnlogin.Location = new Point(37, 349);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(102, 46);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "LOGIN";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 26, 62);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 173);
            panel1.TabIndex = 5;
            // 
            // btnexit
            // 
            btnexit.BackColor = Color.FromArgb(0, 150, 136);
            btnexit.FlatAppearance.BorderSize = 0;
            btnexit.FlatStyle = FlatStyle.Flat;
            btnexit.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnexit.ForeColor = Color.White;
            btnexit.Location = new Point(174, 349);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(102, 46);
            btnexit.TabIndex = 6;
            btnexit.Text = "EXIT";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click_1;
            // 
            // pbUser
            // 
            pbUser.Image = Properties.Resources.account;
            pbUser.Location = new Point(42, 227);
            pbUser.Name = "pbUser";
            pbUser.Size = new Size(27, 27);
            pbUser.SizeMode = PictureBoxSizeMode.CenterImage;
            pbUser.TabIndex = 7;
            pbUser.TabStop = false;
            // 
            // pbPass
            // 
            pbPass.Image = Properties.Resources.password;
            pbPass.Location = new Point(42, 282);
            pbPass.Name = "pbPass";
            pbPass.Size = new Size(27, 27);
            pbPass.SizeMode = PictureBoxSizeMode.CenterImage;
            pbPass.TabIndex = 8;
            pbPass.TabStop = false;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(312, 429);
            Controls.Add(pbPass);
            Controls.Add(pbUser);
            Controls.Add(btnexit);
            Controls.Add(panel1);
            Controls.Add(btnlogin);
            Controls.Add(tbpass);
            Controls.Add(tbuser);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbuser;
        private TextBox tbpass;
        private Button btnlogin;
        private Panel panel1;
        private Button btnexit;
        private PictureBox pbUser;
        private PictureBox pbPass;
    }
}
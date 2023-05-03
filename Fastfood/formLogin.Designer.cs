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
            pbuser = new PictureBox();
            pbpass = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbuser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbpass).BeginInit();
            SuspendLayout();
            // 
            // tbuser
            // 
            tbuser.BorderStyle = BorderStyle.FixedSingle;
            tbuser.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbuser.Location = new Point(75, 227);
            tbuser.Name = "tbuser";
            tbuser.Size = new Size(201, 25);
            tbuser.TabIndex = 2;
            // 
            // tbpass
            // 
            tbpass.BorderStyle = BorderStyle.FixedSingle;
            tbpass.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbpass.Location = new Point(75, 282);
            tbpass.Name = "tbpass";
            tbpass.PasswordChar = '*';
            tbpass.Size = new Size(201, 25);
            tbpass.TabIndex = 3;
            tbpass.UseSystemPasswordChar = true;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.DarkCyan;
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
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
            panel1.BackColor = Color.SteelBlue;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 173);
            panel1.TabIndex = 5;
            // 
            // btnexit
            // 
            btnexit.BackColor = Color.DarkCyan;
            btnexit.FlatStyle = FlatStyle.Flat;
            btnexit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnexit.ForeColor = Color.White;
            btnexit.Location = new Point(174, 349);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(102, 46);
            btnexit.TabIndex = 6;
            btnexit.Text = "EXIT";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click_1;
            // 
            // pbuser
            // 
            pbuser.Image = Properties.Resources.download__1_;
            pbuser.Location = new Point(42, 227);
            pbuser.Name = "pbuser";
            pbuser.Size = new Size(27, 27);
            pbuser.SizeMode = PictureBoxSizeMode.Zoom;
            pbuser.TabIndex = 7;
            pbuser.TabStop = false;
            // 
            // pbpass
            // 
            pbpass.Image = Properties.Resources.download;
            pbpass.Location = new Point(42, 282);
            pbpass.Name = "pbpass";
            pbpass.Size = new Size(27, 27);
            pbpass.SizeMode = PictureBoxSizeMode.Zoom;
            pbpass.TabIndex = 8;
            pbpass.TabStop = false;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(312, 429);
            Controls.Add(pbpass);
            Controls.Add(pbuser);
            Controls.Add(btnexit);
            Controls.Add(panel1);
            Controls.Add(btnlogin);
            Controls.Add(tbpass);
            Controls.Add(tbuser);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbuser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbpass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbuser;
        private TextBox tbpass;
        private Button btnlogin;
        private Panel panel1;
        private Button btnexit;
        private PictureBox pbuser;
        private PictureBox pbpass;
    }
}
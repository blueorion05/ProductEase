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
            this.tbuser = new System.Windows.Forms.TextBox();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.pbuser = new System.Windows.Forms.PictureBox();
            this.pbpass = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpass)).BeginInit();
            this.SuspendLayout();
            // 
            // tbuser
            // 
            this.tbuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbuser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbuser.Location = new System.Drawing.Point(75, 227);
            this.tbuser.Name = "tbuser";
            this.tbuser.Size = new System.Drawing.Size(201, 25);
            this.tbuser.TabIndex = 2;
            // 
            // tbpass
            // 
            this.tbpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbpass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbpass.Location = new System.Drawing.Point(75, 282);
            this.tbpass.Name = "tbpass";
            this.tbpass.PasswordChar = '*';
            this.tbpass.Size = new System.Drawing.Size(201, 25);
            this.tbpass.TabIndex = 3;
            this.tbpass.UseSystemPasswordChar = true;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.DarkCyan;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(37, 349);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(102, 46);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "LOGIN";
            this.btnlogin.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 173);
            this.panel1.TabIndex = 5;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.DarkCyan;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(174, 349);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(102, 46);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = false;
            // 
            // pbuser
            // 
            this.pbuser.Image = global::Fastfood.Properties.Resources.download__1_;
            this.pbuser.Location = new System.Drawing.Point(42, 227);
            this.pbuser.Name = "pbuser";
            this.pbuser.Size = new System.Drawing.Size(27, 27);
            this.pbuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbuser.TabIndex = 7;
            this.pbuser.TabStop = false;
            // 
            // pbpass
            // 
            this.pbpass.Image = global::Fastfood.Properties.Resources.download;
            this.pbpass.Location = new System.Drawing.Point(42, 282);
            this.pbpass.Name = "pbpass";
            this.pbpass.Size = new System.Drawing.Size(27, 27);
            this.pbpass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbpass.TabIndex = 8;
            this.pbpass.TabStop = false;
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(312, 429);
            this.Controls.Add(this.pbpass);
            this.Controls.Add(this.pbuser);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.tbpass);
            this.Controls.Add(this.tbuser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
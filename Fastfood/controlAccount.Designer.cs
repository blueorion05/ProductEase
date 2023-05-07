namespace Fastfood
{
    partial class controlAccount
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            textBox3 = new TextBox();
            lblConfirmPass = new Label();
            textBox2 = new TextBox();
            lblNewPass = new Label();
            textBox1 = new TextBox();
            lblCurrentPass = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(lblConfirmPass);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(lblNewPass);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(lblCurrentPass);
            panel1.Location = new Point(27, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(420, 264);
            panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(0, 150, 136);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(122, 197);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 150, 136);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(31, 197);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(31, 143);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(354, 23);
            textBox3.TabIndex = 10;
            textBox3.UseSystemPasswordChar = true;
            // 
            // lblConfirmPass
            // 
            lblConfirmPass.AutoSize = true;
            lblConfirmPass.BackColor = Color.Transparent;
            lblConfirmPass.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblConfirmPass.ForeColor = Color.Black;
            lblConfirmPass.Location = new Point(31, 123);
            lblConfirmPass.Name = "lblConfirmPass";
            lblConfirmPass.Size = new Size(142, 17);
            lblConfirmPass.TabIndex = 9;
            lblConfirmPass.Text = "Confirm New Password";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(31, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(354, 23);
            textBox2.TabIndex = 8;
            textBox2.UseSystemPasswordChar = true;
            // 
            // lblNewPass
            // 
            lblNewPass.AutoSize = true;
            lblNewPass.BackColor = Color.Transparent;
            lblNewPass.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNewPass.ForeColor = Color.Black;
            lblNewPass.Location = new Point(31, 77);
            lblNewPass.Name = "lblNewPass";
            lblNewPass.Size = new Size(93, 17);
            lblNewPass.TabIndex = 7;
            lblNewPass.Text = "New Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(31, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(354, 23);
            textBox1.TabIndex = 6;
            textBox1.UseSystemPasswordChar = true;
            // 
            // lblCurrentPass
            // 
            lblCurrentPass.AutoSize = true;
            lblCurrentPass.BackColor = Color.Transparent;
            lblCurrentPass.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentPass.ForeColor = Color.Black;
            lblCurrentPass.Location = new Point(31, 31);
            lblCurrentPass.Name = "lblCurrentPass";
            lblCurrentPass.Size = new Size(110, 17);
            lblCurrentPass.TabIndex = 5;
            lblCurrentPass.Text = "Current Password";
            // 
            // controlAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(panel1);
            Name = "controlAccount";
            Size = new Size(1064, 654);
            Load += controlAccount_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblCurrentPass;
        private TextBox textBox3;
        private Label lblConfirmPass;
        private TextBox textBox2;
        private Label lblNewPass;
        private TextBox textBox1;
        private Button btnCancel;
        private Button btnSave;
    }
}

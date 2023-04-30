namespace Fastfood
{
    partial class Form1
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
            lbl1login = new Label();
            lbl2company = new Label();
            txb1username = new TextBox();
            txb2password = new TextBox();
            btn1login = new Button();
            SuspendLayout();
            // 
            // lbl1login
            // 
            lbl1login.AutoSize = true;
            lbl1login.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1login.Location = new Point(55, 29);
            lbl1login.Name = "lbl1login";
            lbl1login.Size = new Size(120, 47);
            lbl1login.TabIndex = 0;
            lbl1login.Text = "LOGIN";
            // 
            // lbl2company
            // 
            lbl2company.AutoSize = true;
            lbl2company.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbl2company.Location = new Point(617, 9);
            lbl2company.Name = "lbl2company";
            lbl2company.Size = new Size(171, 45);
            lbl2company.TabIndex = 1;
            lbl2company.Text = "COMPANY";
            // 
            // txb1username
            // 
            txb1username.Location = new Point(91, 119);
            txb1username.Name = "txb1username";
            txb1username.Size = new Size(385, 23);
            txb1username.TabIndex = 2;
            // 
            // txb2password
            // 
            txb2password.Location = new Point(91, 164);
            txb2password.Name = "txb2password";
            txb2password.Size = new Size(385, 23);
            txb2password.TabIndex = 3;
            txb2password.UseSystemPasswordChar = true;
            // 
            // btn1login
            // 
            btn1login.Location = new Point(55, 215);
            btn1login.Name = "btn1login";
            btn1login.Size = new Size(421, 23);
            btn1login.TabIndex = 4;
            btn1login.Text = "LOGIN";
            btn1login.UseVisualStyleBackColor = true;
            btn1login.Click += btn1login_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 303);
            Controls.Add(btn1login);
            Controls.Add(txb2password);
            Controls.Add(txb1username);
            Controls.Add(lbl2company);
            Controls.Add(lbl1login);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1login;
        private Label lbl2company;
        private TextBox txb1username;
        private TextBox txb2password;
        private Button btn1login;
    }
}
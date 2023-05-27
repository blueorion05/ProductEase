namespace Fastfood
{
    partial class formInformation
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
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = Color.Black;
            textBox3.Location = new Point(157, 81);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(313, 22);
            textBox3.TabIndex = 83;
            textBox3.UseSystemPasswordChar = true;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(9, 86);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(145, 17);
            label3.TabIndex = 82;
            label3.Text = ":Confirm New Password";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(157, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(313, 22);
            textBox2.TabIndex = 81;
            textBox2.UseSystemPasswordChar = true;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(56, 56);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(96, 17);
            label2.TabIndex = 80;
            label2.Text = ":New Password";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(157, 25);
            textBox1.MaxLength = 500;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(313, 22);
            textBox1.TabIndex = 79;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(41, 30);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(113, 17);
            label1.TabIndex = 78;
            label1.Text = ":";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 150, 136);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(15, 141);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(102, 43);
            btnSave.TabIndex = 76;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(0, 150, 136);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(123, 141);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(102, 43);
            btnCancel.TabIndex = 77;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // formInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 26, 62);
            ClientSize = new Size(490, 200);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formInformation";
            Load += formInformation_Load;
            Enter += btnSave_Click;
            KeyPress += formInformation_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox textBox3;
        public Label label3;
        public TextBox textBox2;
        public Label label2;
        public TextBox textBox1;
        public Label label1;
        private Button btnSave;
        private Button btnCancel;
    }
}
namespace Fastfood
{
    partial class Account
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
            dateTimePicker1 = new DateTimePicker();
            groupBox1 = new GroupBox();
            PNTSCB = new CheckBox();
            FemaleCB = new CheckBox();
            MaleCB = new CheckBox();
            TB5 = new TextBox();
            label7 = new Label();
            TB4 = new TextBox();
            TB3 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            TB2 = new TextBox();
            label4 = new Label();
            TB1 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            lblConfirmPass = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox4 = new TextBox();
            label1 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            groupBox2 = new GroupBox();
            LBbirthday = new Label();
            LBEmail = new Label();
            LBContact = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(TB5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(TB4);
            panel1.Controls.Add(TB3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(TB2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(TB1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(lblConfirmPass);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(33, 265);
            panel1.Name = "panel1";
            panel1.Size = new Size(990, 237);
            panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(243, 136);
            dateTimePicker1.MaxDate = new DateTime(2023, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(125, 23);
            dateTimePicker1.TabIndex = 22;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(PNTSCB);
            groupBox1.Controls.Add(FemaleCB);
            groupBox1.Controls.Add(MaleCB);
            groupBox1.Location = new Point(25, 123);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(208, 43);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            // 
            // PNTSCB
            // 
            PNTSCB.AutoSize = true;
            PNTSCB.Location = new Point(136, 18);
            PNTSCB.Name = "PNTSCB";
            PNTSCB.Size = new Size(56, 19);
            PNTSCB.TabIndex = 2;
            PNTSCB.Text = "Other";
            PNTSCB.UseVisualStyleBackColor = true;
            PNTSCB.CheckedChanged += PNTSCB_CheckedChanged;
            // 
            // FemaleCB
            // 
            FemaleCB.AutoSize = true;
            FemaleCB.Location = new Point(64, 18);
            FemaleCB.Name = "FemaleCB";
            FemaleCB.Size = new Size(64, 19);
            FemaleCB.TabIndex = 1;
            FemaleCB.Text = "Female";
            FemaleCB.UseVisualStyleBackColor = true;
            FemaleCB.CheckedChanged += FemaleCB_CheckedChanged;
            // 
            // MaleCB
            // 
            MaleCB.AutoSize = true;
            MaleCB.Location = new Point(6, 18);
            MaleCB.Name = "MaleCB";
            MaleCB.Size = new Size(52, 19);
            MaleCB.TabIndex = 0;
            MaleCB.Text = "Male";
            MaleCB.UseVisualStyleBackColor = true;
            MaleCB.CheckedChanged += MaleCB_CheckedChanged;
            // 
            // TB5
            // 
            TB5.Location = new Point(243, 87);
            TB5.Name = "TB5";
            TB5.Size = new Size(209, 23);
            TB5.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(184, 89);
            label7.Name = "label7";
            label7.Size = new Size(42, 17);
            label7.TabIndex = 19;
            label7.Text = "Email:";
            // 
            // TB4
            // 
            TB4.Location = new Point(80, 85);
            TB4.Name = "TB4";
            TB4.Size = new Size(99, 23);
            TB4.TabIndex = 18;
            // 
            // TB3
            // 
            TB3.Location = new Point(320, 51);
            TB3.Name = "TB3";
            TB3.Size = new Size(132, 23);
            TB3.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(320, 31);
            label6.Name = "label6";
            label6.Size = new Size(89, 17);
            label6.TabIndex = 16;
            label6.Text = "Middle name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(21, 87);
            label5.Name = "label5";
            label5.Size = new Size(58, 17);
            label5.TabIndex = 15;
            label5.Text = "Contact";
            // 
            // TB2
            // 
            TB2.Location = new Point(161, 51);
            TB2.Name = "TB2";
            TB2.Size = new Size(153, 23);
            TB2.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(161, 31);
            label4.Name = "label4";
            label4.Size = new Size(72, 17);
            label4.TabIndex = 13;
            label4.Text = "Last name:";
            // 
            // TB1
            // 
            TB1.Location = new Point(21, 51);
            TB1.Name = "TB1";
            TB1.Size = new Size(132, 23);
            TB1.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(21, 31);
            label3.Name = "label3";
            label3.Size = new Size(71, 17);
            label3.TabIndex = 11;
            label3.Text = "First name:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(505, 143);
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
            lblConfirmPass.Location = new Point(505, 123);
            lblConfirmPass.Name = "lblConfirmPass";
            lblConfirmPass.Size = new Size(142, 17);
            lblConfirmPass.TabIndex = 9;
            lblConfirmPass.Text = "Confirm New Password";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(505, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(354, 23);
            textBox2.TabIndex = 8;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(505, 77);
            label2.Name = "label2";
            label2.Size = new Size(93, 17);
            label2.TabIndex = 7;
            label2.Text = "New Password";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(505, 51);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(354, 23);
            textBox4.TabIndex = 6;
            textBox4.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(505, 31);
            label1.Name = "label1";
            label1.Size = new Size(110, 17);
            label1.TabIndex = 5;
            label1.Text = "Current Password";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(0, 150, 136);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(122, 508);
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
            btnSave.Location = new Point(33, 508);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(LBbirthday);
            groupBox2.Controls.Add(LBEmail);
            groupBox2.Controls.Add(LBContact);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Location = new Point(33, 14);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(990, 220);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            // 
            // LBbirthday
            // 
            LBbirthday.AutoSize = true;
            LBbirthday.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LBbirthday.Location = new Point(243, 85);
            LBbirthday.Name = "LBbirthday";
            LBbirthday.Size = new Size(74, 21);
            LBbirthday.TabIndex = 4;
            LBbirthday.Text = "Birthday";
            // 
            // LBEmail
            // 
            LBEmail.AutoSize = true;
            LBEmail.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LBEmail.Location = new Point(243, 149);
            LBEmail.Name = "LBEmail";
            LBEmail.Size = new Size(51, 21);
            LBEmail.TabIndex = 3;
            LBEmail.Text = "Email";
            // 
            // LBContact
            // 
            LBContact.AutoSize = true;
            LBContact.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LBContact.Location = new Point(243, 117);
            LBContact.Name = "LBContact";
            LBContact.Size = new Size(78, 21);
            LBContact.TabIndex = 2;
            LBContact.Text = "Contact";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(243, 47);
            label8.Name = "label8";
            label8.Size = new Size(125, 24);
            label8.TabIndex = 1;
            label8.Text = "FULL NAME:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(80, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 123);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(groupBox2);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(panel1);
            Name = "Account";
            Size = new Size(1064, 654);
            Load += controlAccount_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox3;
        private Label lblConfirmPass;
        private TextBox textBox2;
        private Button btnCancel;
        private Button btnSave;
        private Label label3;
        private Label label2;
        private TextBox textBox4;
        private Label label1;
        private Label label5;
        private TextBox TB2;
        private Label label4;
        private TextBox TB1;
        private GroupBox groupBox1;
        private CheckBox PNTSCB;
        private CheckBox FemaleCB;
        private CheckBox MaleCB;
        private TextBox TB5;
        private Label label7;
        private TextBox TB4;
        private TextBox TB3;
        private Label label6;
        private GroupBox groupBox2;
        private Label label8;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private Label LBbirthday;
        private Label LBEmail;
        private Label LBContact;
    }
}

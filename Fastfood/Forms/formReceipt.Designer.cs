namespace Fastfood
{
    partial class formReceipt
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
            panel1 = new Panel();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(25, 26, 62);
            panel1.Location = new Point(5, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(354, 476);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 150, 136);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button4);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(364, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(126, 500);
            panel2.TabIndex = 21;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 150, 136);
            button2.Dock = DockStyle.Bottom;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 341);
            button2.Name = "button2";
            button2.Size = new Size(126, 53);
            button2.TabIndex = 23;
            button2.Text = "Confirm";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 150, 136);
            button1.Dock = DockStyle.Bottom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 394);
            button1.Name = "button1";
            button1.Size = new Size(126, 53);
            button1.TabIndex = 22;
            button1.Text = "Print";
            button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 150, 136);
            button4.Dock = DockStyle.Bottom;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(0, 447);
            button4.Name = "button4";
            button4.Size = new Size(126, 53);
            button4.TabIndex = 21;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // formReceipt
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 26, 62);
            ClientSize = new Size(490, 500);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formReceipt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formReceipt";
            Load += formReceipt_Load;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public Panel panel1;
        private Panel panel2;
        private Button button4;
        private Button button2;
        private Button button1;
    }
}
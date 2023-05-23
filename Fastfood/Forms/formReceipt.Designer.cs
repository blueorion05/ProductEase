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
            btnConfirm = new Button();
            btnPrint = new Button();
            btnCancel = new Button();
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
            panel2.Controls.Add(btnConfirm);
            panel2.Controls.Add(btnPrint);
            panel2.Controls.Add(btnCancel);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(364, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(126, 500);
            panel2.TabIndex = 21;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(0, 150, 136);
            btnConfirm.Dock = DockStyle.Bottom;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(0, 341);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(126, 53);
            btnConfirm.TabIndex = 23;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += button2_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(0, 150, 136);
            btnPrint.Dock = DockStyle.Bottom;
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(0, 394);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(126, 53);
            btnPrint.TabIndex = 22;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(0, 150, 136);
            btnCancel.Dock = DockStyle.Bottom;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(0, 447);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(126, 53);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += button4_Click;
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
        public Button btnCancel;
        public Button btnConfirm;
        public Button btnPrint;
    }
}
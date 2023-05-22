namespace Fastfood
{
    partial class Receipt
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
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblCash = new Label();
            lblChange = new Label();
            lblDiscount = new Label();
            lblAmountDue = new Label();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 73);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 360);
            panel2.Name = "panel2";
            panel2.Size = new Size(336, 67);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(lblCash);
            panel3.Controls.Add(lblChange);
            panel3.Controls.Add(lblDiscount);
            panel3.Controls.Add(lblAmountDue);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(336, 287);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 232);
            label1.Name = "label1";
            label1.Size = new Size(96, 17);
            label1.TabIndex = 7;
            label1.Text = "Cash Tendered";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 249);
            label2.Name = "label2";
            label2.Size = new Size(55, 17);
            label2.TabIndex = 6;
            label2.Text = "Change";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 198);
            label3.Name = "label3";
            label3.Size = new Size(60, 17);
            label3.TabIndex = 5;
            label3.Text = "Discount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(141, 181);
            label4.Name = "label4";
            label4.Size = new Size(82, 17);
            label4.TabIndex = 4;
            label4.Text = "Amount Due";
            // 
            // lblCash
            // 
            lblCash.AutoSize = true;
            lblCash.Location = new Point(240, 232);
            lblCash.Name = "lblCash";
            lblCash.Size = new Size(96, 17);
            lblCash.TabIndex = 3;
            lblCash.Text = "Cash Tendered";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Location = new Point(241, 249);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(55, 17);
            lblChange.TabIndex = 2;
            lblChange.Text = "Change";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(241, 198);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(60, 17);
            lblDiscount.TabIndex = 1;
            lblDiscount.Text = "Discount";
            // 
            // lblAmountDue
            // 
            lblAmountDue.AutoSize = true;
            lblAmountDue.Location = new Point(240, 181);
            lblAmountDue.Name = "lblAmountDue";
            lblAmountDue.Size = new Size(82, 17);
            lblAmountDue.TabIndex = 0;
            lblAmountDue.Text = "Amount Due";
            // 
            // Receipt
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Receipt";
            Size = new Size(336, 427);
            Load += Receipt_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        public Label lblCash;
        public Label lblChange;
        public Label lblDiscount;
        public Label lblAmountDue;
    }
}

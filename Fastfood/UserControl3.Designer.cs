namespace Fastfood
{
    partial class UserControl3
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
            lbl1order = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            lbl2orderno = new Label();
            pb1order = new PictureBox();
            lbl3item = new Label();
            lbl4quantity = new Label();
            lbl5cost = new Label();
            lbl6total = new Label();
            lbl7amount = new Label();
            btn1pay = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb1order).BeginInit();
            SuspendLayout();
            // 
            // lbl1order
            // 
            lbl1order.AutoSize = true;
            lbl1order.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1order.Location = new Point(0, 0);
            lbl1order.Name = "lbl1order";
            lbl1order.Size = new Size(66, 30);
            lbl1order.TabIndex = 2;
            lbl1order.Text = "Order";
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(501, 388);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn1pay);
            panel2.Controls.Add(lbl7amount);
            panel2.Controls.Add(lbl6total);
            panel2.Controls.Add(lbl5cost);
            panel2.Controls.Add(lbl4quantity);
            panel2.Controls.Add(lbl3item);
            panel2.Controls.Add(pb1order);
            panel2.Controls.Add(lbl2orderno);
            panel2.Location = new Point(510, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(222, 388);
            panel2.TabIndex = 4;
            // 
            // lbl2orderno
            // 
            lbl2orderno.AutoSize = true;
            lbl2orderno.Location = new Point(3, 4);
            lbl2orderno.Name = "lbl2orderno";
            lbl2orderno.Size = new Size(57, 15);
            lbl2orderno.TabIndex = 0;
            lbl2orderno.Text = "Order no.";
            lbl2orderno.Click += label1_Click;
            // 
            // pb1order
            // 
            pb1order.BackColor = SystemColors.ActiveCaptionText;
            pb1order.Location = new Point(3, 22);
            pb1order.Name = "pb1order";
            pb1order.Size = new Size(216, 36);
            pb1order.TabIndex = 1;
            pb1order.TabStop = false;
            // 
            // lbl3item
            // 
            lbl3item.AutoSize = true;
            lbl3item.BackColor = SystemColors.ActiveCaptionText;
            lbl3item.ForeColor = Color.White;
            lbl3item.Location = new Point(19, 32);
            lbl3item.Name = "lbl3item";
            lbl3item.Size = new Size(33, 15);
            lbl3item.TabIndex = 2;
            lbl3item.Text = "ITEM";
            // 
            // lbl4quantity
            // 
            lbl4quantity.AutoSize = true;
            lbl4quantity.BackColor = SystemColors.ActiveCaptionText;
            lbl4quantity.ForeColor = Color.White;
            lbl4quantity.Location = new Point(99, 32);
            lbl4quantity.Name = "lbl4quantity";
            lbl4quantity.Size = new Size(28, 15);
            lbl4quantity.TabIndex = 3;
            lbl4quantity.Text = "QTY";
            // 
            // lbl5cost
            // 
            lbl5cost.AutoSize = true;
            lbl5cost.BackColor = SystemColors.ActiveCaptionText;
            lbl5cost.ForeColor = Color.White;
            lbl5cost.Location = new Point(168, 32);
            lbl5cost.Name = "lbl5cost";
            lbl5cost.Size = new Size(36, 15);
            lbl5cost.TabIndex = 4;
            lbl5cost.Text = "COST";
            // 
            // lbl6total
            // 
            lbl6total.AutoSize = true;
            lbl6total.Location = new Point(19, 308);
            lbl6total.Name = "lbl6total";
            lbl6total.Size = new Size(32, 15);
            lbl6total.TabIndex = 5;
            lbl6total.Text = "Total";
            // 
            // lbl7amount
            // 
            lbl7amount.AutoSize = true;
            lbl7amount.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl7amount.Location = new Point(120, 300);
            lbl7amount.Name = "lbl7amount";
            lbl7amount.Size = new Size(84, 25);
            lbl7amount.TabIndex = 6;
            lbl7amount.Text = "Php 0.00";
            // 
            // btn1pay
            // 
            btn1pay.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn1pay.Location = new Point(19, 335);
            btn1pay.Name = "btn1pay";
            btn1pay.Size = new Size(185, 50);
            btn1pay.TabIndex = 7;
            btn1pay.Text = "PAY";
            btn1pay.UseVisualStyleBackColor = true;
            // 
            // UserControl3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lbl1order);
            Name = "UserControl3";
            Size = new Size(735, 424);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb1order).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1order;
        private Panel panel1;
        private Panel panel2;
        private Label lbl2orderno;
        private Button btn1pay;
        private Label lbl7amount;
        private Label lbl6total;
        private Label lbl5cost;
        private Label lbl4quantity;
        private Label lbl3item;
        private PictureBox pb1order;
    }
}

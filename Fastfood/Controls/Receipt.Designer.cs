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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
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
            dataGridView1 = new DataGridView();
            Empty = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            Product_Name = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel2.Location = new Point(0, 233);
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
            panel3.Location = new Point(0, 94);
            panel3.Name = "panel3";
            panel3.Size = new Size(336, 139);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 65);
            label1.Name = "label1";
            label1.Size = new Size(96, 17);
            label1.TabIndex = 7;
            label1.Text = "Cash Tendered";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 82);
            label2.Name = "label2";
            label2.Size = new Size(55, 17);
            label2.TabIndex = 6;
            label2.Text = "Change";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(133, 31);
            label3.Name = "label3";
            label3.Size = new Size(60, 17);
            label3.TabIndex = 5;
            label3.Text = "Discount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(132, 14);
            label4.Name = "label4";
            label4.Size = new Size(82, 17);
            label4.TabIndex = 4;
            label4.Text = "Amount Due";
            // 
            // lblCash
            // 
            lblCash.AutoSize = true;
            lblCash.Location = new Point(231, 65);
            lblCash.Name = "lblCash";
            lblCash.Size = new Size(96, 17);
            lblCash.TabIndex = 3;
            lblCash.Text = "Cash Tendered";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Location = new Point(232, 82);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(55, 17);
            lblChange.TabIndex = 2;
            lblChange.Text = "Change";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(232, 31);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(60, 17);
            lblDiscount.TabIndex = 1;
            lblDiscount.Text = "Discount";
            // 
            // lblAmountDue
            // 
            lblAmountDue.AutoSize = true;
            lblAmountDue.Location = new Point(231, 14);
            lblAmountDue.Name = "lblAmountDue";
            lblAmountDue.Size = new Size(82, 17);
            lblAmountDue.TabIndex = 0;
            lblAmountDue.Text = "Amount Due";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Empty, Id, Product_Name, Quantity, Price, Amount });
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Enabled = false;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(0, 73);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(336, 21);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellEnter += dataGridView1_CellEnter;
            dataGridView1.Enter += dataGridView1_Enter;
            // 
            // Empty
            // 
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            Empty.DefaultCellStyle = dataGridViewCellStyle2;
            Empty.HeaderText = "";
            Empty.Name = "Empty";
            Empty.ReadOnly = true;
            Empty.Width = 5;
            // 
            // Id
            // 
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 7F, FontStyle.Regular, GraphicsUnit.Point);
            Id.DefaultCellStyle = dataGridViewCellStyle3;
            Id.FillWeight = 108.8427F;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 73;
            // 
            // Product_Name
            // 
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 7F, FontStyle.Regular, GraphicsUnit.Point);
            Product_Name.DefaultCellStyle = dataGridViewCellStyle4;
            Product_Name.FillWeight = 99.6004639F;
            Product_Name.HeaderText = "Product Name";
            Product_Name.Name = "Product_Name";
            Product_Name.ReadOnly = true;
            Product_Name.Width = 67;
            // 
            // Quantity
            // 
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 7F, FontStyle.Regular, GraphicsUnit.Point);
            Quantity.DefaultCellStyle = dataGridViewCellStyle5;
            Quantity.FillWeight = 95.62374F;
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 65;
            // 
            // Price
            // 
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 7F, FontStyle.Regular, GraphicsUnit.Point);
            Price.DefaultCellStyle = dataGridViewCellStyle6;
            Price.FillWeight = 95.93309F;
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 64;
            // 
            // Amount
            // 
            dataGridViewCellStyle7.Font = new Font("Century Gothic", 7F, FontStyle.Regular, GraphicsUnit.Point);
            Amount.DefaultCellStyle = dataGridViewCellStyle7;
            Amount.FillWeight = 100.000015F;
            Amount.HeaderText = "Amount";
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            Amount.Width = 67;
            // 
            // Receipt
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel3);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Receipt";
            Size = new Size(336, 300);
            Resize += Receipt_Resize;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        public DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Empty;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Product_Name;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Amount;
    }
}

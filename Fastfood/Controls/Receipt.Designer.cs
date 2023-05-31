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
            panel1 = new Panel();
            lblDate = new Label();
            lblId = new Label();
            lblCompany = new Label();
            label5 = new Label();
            panel2 = new Panel();
            label6 = new Label();
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
            Product_Name = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            lblContactNum = new Label();
            lblEmail = new Label();
            lblAddress = new Label();
            lblStoreHours = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(lblId);
            panel1.Controls.Add(lblAddress);
            panel1.Controls.Add(lblCompany);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 126);
            panel1.TabIndex = 0;
            // 
            // lblDate
            // 
            lblDate.Dock = DockStyle.Top;
            lblDate.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.Location = new Point(0, 96);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(336, 16);
            lblDate.TabIndex = 1;
            lblDate.Text = "DateTime";
            lblDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblId
            // 
            lblId.Dock = DockStyle.Top;
            lblId.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblId.Location = new Point(0, 80);
            lblId.Name = "lblId";
            lblId.Size = new Size(336, 16);
            lblId.TabIndex = 0;
            lblId.Text = "Order No.";
            lblId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCompany
            // 
            lblCompany.Dock = DockStyle.Top;
            lblCompany.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCompany.Location = new Point(0, 48);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(336, 16);
            lblCompany.TabIndex = 3;
            lblCompany.Text = "Company";
            lblCompany.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 10, 0, 10);
            label5.Size = new Size(336, 48);
            label5.TabIndex = 2;
            label5.Text = "Receipt";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblStoreHours);
            panel2.Controls.Add(lblEmail);
            panel2.Controls.Add(lblContactNum);
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 247);
            panel2.Name = "panel2";
            panel2.Size = new Size(336, 125);
            panel2.TabIndex = 1;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Padding = new Padding(0, 10, 0, 10);
            label6.Size = new Size(336, 48);
            label6.TabIndex = 3;
            label6.Text = "Thank You For Purchasing!";
            label6.TextAlign = ContentAlignment.MiddleCenter;
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
            panel3.Location = new Point(0, 147);
            panel3.Name = "panel3";
            panel3.Size = new Size(336, 100);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(97, 50);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(150, 17);
            label1.TabIndex = 7;
            label1.Text = "₱  :Cash Tendered";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(164, 67);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(83, 17);
            label2.TabIndex = 6;
            label2.Text = "₱  :Change";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(164, 16);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(83, 17);
            label3.TabIndex = 5;
            label3.Text = "₱  :Discount";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(164, 33);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(83, 17);
            label4.TabIndex = 4;
            label4.Text = "₱  :Amount Due";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCash
            // 
            lblCash.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCash.Location = new Point(253, 50);
            lblCash.Name = "lblCash";
            lblCash.Size = new Size(83, 17);
            lblCash.TabIndex = 3;
            lblCash.Text = "0.00 ";
            lblCash.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblChange
            // 
            lblChange.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblChange.Location = new Point(253, 67);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(83, 17);
            lblChange.TabIndex = 2;
            lblChange.Text = "0.00 ";
            lblChange.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDiscount
            // 
            lblDiscount.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDiscount.Location = new Point(253, 16);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(83, 17);
            lblDiscount.TabIndex = 1;
            lblDiscount.Text = "0.00 ";
            lblDiscount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAmountDue
            // 
            lblAmountDue.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAmountDue.Location = new Point(253, 33);
            lblAmountDue.Name = "lblAmountDue";
            lblAmountDue.Size = new Size(83, 17);
            lblAmountDue.TabIndex = 0;
            lblAmountDue.Text = "0.00 ";
            lblAmountDue.TextAlign = ContentAlignment.MiddleLeft;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Empty, Product_Name, Quantity, Price, Amount });
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Enabled = false;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(0, 126);
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
            // Product_Name
            // 
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Product_Name.DefaultCellStyle = dataGridViewCellStyle3;
            Product_Name.FillWeight = 99.60046F;
            Product_Name.HeaderText = "Product Name";
            Product_Name.MinimumWidth = 130;
            Product_Name.Name = "Product_Name";
            Product_Name.ReadOnly = true;
            Product_Name.Width = 130;
            // 
            // Quantity
            // 
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Quantity.DefaultCellStyle = dataGridViewCellStyle4;
            Quantity.FillWeight = 95.62374F;
            Quantity.HeaderText = "Qty";
            Quantity.MinimumWidth = 40;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 40;
            // 
            // Price
            // 
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Price.DefaultCellStyle = dataGridViewCellStyle5;
            Price.FillWeight = 95.93309F;
            Price.HeaderText = "Price";
            Price.MinimumWidth = 80;
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 80;
            // 
            // Amount
            // 
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Amount.DefaultCellStyle = dataGridViewCellStyle6;
            Amount.HeaderText = "Total";
            Amount.MinimumWidth = 80;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            Amount.Width = 80;
            // 
            // lblContactNum
            // 
            lblContactNum.Dock = DockStyle.Top;
            lblContactNum.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblContactNum.Location = new Point(0, 48);
            lblContactNum.Name = "lblContactNum";
            lblContactNum.Size = new Size(336, 16);
            lblContactNum.TabIndex = 4;
            lblContactNum.Text = "Contact Num";
            lblContactNum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            lblEmail.Dock = DockStyle.Top;
            lblEmail.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(0, 64);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(336, 16);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAddress
            // 
            lblAddress.Dock = DockStyle.Top;
            lblAddress.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddress.Location = new Point(0, 64);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(336, 16);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address";
            lblAddress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStoreHours
            // 
            lblStoreHours.Dock = DockStyle.Top;
            lblStoreHours.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblStoreHours.Location = new Point(0, 80);
            lblStoreHours.Name = "lblStoreHours";
            lblStoreHours.Size = new Size(336, 16);
            lblStoreHours.TabIndex = 6;
            lblStoreHours.Text = "Store Hours";
            lblStoreHours.TextAlign = ContentAlignment.MiddleCenter;
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
            Size = new Size(336, 372);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label label2;
        public Label label3;
        private Label label4;
        public Label lblCash;
        public Label lblChange;
        public Label lblDiscount;
        public Label lblAmountDue;
        public DataGridView dataGridView1;
        public Label lblId;
        public Label lblDate;
        private DataGridViewTextBoxColumn Empty;
        private DataGridViewTextBoxColumn Product_Name;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Amount;
        public Label label5;
        public Label label6;
        public Label lblCompany;
        public Label lblAddress;
        public Label lblEmail;
        public Label lblContactNum;
        public Label lblStoreHours;
    }
}

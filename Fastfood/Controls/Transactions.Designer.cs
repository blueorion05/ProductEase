namespace Fastfood
{
    partial class Transactions
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
            dataGridView1 = new DataGridView();
            label2 = new Label();
            button3 = new Button();
            Date = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            Products = new DataGridViewTextBoxColumn();
            AmountDue = new DataGridViewTextBoxColumn();
            Discount = new DataGridViewTextBoxColumn();
            CashTendered = new DataGridViewTextBoxColumn();
            Change = new DataGridViewTextBoxColumn();
            Receipt = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Date, Id, Products, AmountDue, Discount, CashTendered, Change, Receipt });
            dataGridView1.GridColor = SystemColors.ActiveCaptionText;
            dataGridView1.Location = new Point(34, 128);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.RowTemplate.Height = 100;
            dataGridView1.Size = new Size(909, 480);
            dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(34, 97);
            label2.Name = "label2";
            label2.Size = new Size(136, 21);
            label2.TabIndex = 7;
            label2.Text = "ORDER HISTORY";
            label2.Click += label2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(176, 97);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "SEARCH";
            button3.UseVisualStyleBackColor = true;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Products
            // 
            Products.HeaderText = "Products";
            Products.Name = "Products";
            Products.ReadOnly = true;
            Products.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // AmountDue
            // 
            AmountDue.HeaderText = "Amount Due";
            AmountDue.Name = "AmountDue";
            AmountDue.ReadOnly = true;
            AmountDue.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Discount
            // 
            Discount.HeaderText = "Discount";
            Discount.Name = "Discount";
            Discount.ReadOnly = true;
            Discount.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // CashTendered
            // 
            CashTendered.HeaderText = "Cash Tendered";
            CashTendered.Name = "CashTendered";
            CashTendered.ReadOnly = true;
            CashTendered.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Change
            // 
            Change.HeaderText = "Change";
            Change.Name = "Change";
            Change.ReadOnly = true;
            Change.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Receipt
            // 
            Receipt.HeaderText = "Receipt";
            Receipt.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Receipt.Name = "Receipt";
            Receipt.ReadOnly = true;
            // 
            // Transactions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Name = "Transactions";
            Size = new Size(1064, 654);
            Load += controlRecords_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label2;
        private Button button3;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Products;
        private DataGridViewTextBoxColumn AmountDue;
        private DataGridViewTextBoxColumn Discount;
        private DataGridViewTextBoxColumn CashTendered;
        private DataGridViewTextBoxColumn Change;
        private DataGridViewImageColumn Receipt;
    }
}

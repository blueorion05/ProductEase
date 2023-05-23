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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            Date = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            Products = new DataGridViewTextBoxColumn();
            AmountDue = new DataGridViewTextBoxColumn();
            Discount = new DataGridViewTextBoxColumn();
            CashTendered = new DataGridViewTextBoxColumn();
            Change = new DataGridViewTextBoxColumn();
            Receipt = new DataGridViewButtonColumn();
            pbFooter = new PictureBox();
            pbHeader = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFooter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHeader).BeginInit();
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
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Date, Id, Products, AmountDue, Discount, CashTendered, Change, Receipt });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(3, 59);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.RowTemplate.ReadOnly = true;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(1058, 536);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.RowHeightInfoNeeded += dataGridView1_RowHeightInfoNeeded;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.SortMode = DataGridViewColumnSortMode.NotSortable;
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            Receipt.DefaultCellStyle = dataGridViewCellStyle2;
            Receipt.FlatStyle = FlatStyle.Flat;
            Receipt.HeaderText = "Receipt";
            Receipt.Name = "Receipt";
            Receipt.ReadOnly = true;
            Receipt.Resizable = DataGridViewTriState.False;
            Receipt.Text = "View";
            Receipt.UseColumnTextForButtonValue = true;
            // 
            // pbFooter
            // 
            pbFooter.BackColor = Color.FromArgb(0, 150, 136);
            pbFooter.BackgroundImageLayout = ImageLayout.None;
            pbFooter.Dock = DockStyle.Bottom;
            pbFooter.Location = new Point(0, 601);
            pbFooter.Name = "pbFooter";
            pbFooter.Size = new Size(1064, 53);
            pbFooter.TabIndex = 17;
            pbFooter.TabStop = false;
            // 
            // pbHeader
            // 
            pbHeader.BackColor = Color.FromArgb(0, 150, 136);
            pbHeader.BackgroundImageLayout = ImageLayout.None;
            pbHeader.Dock = DockStyle.Top;
            pbHeader.Location = new Point(0, 0);
            pbHeader.Name = "pbHeader";
            pbHeader.Size = new Size(1064, 53);
            pbHeader.TabIndex = 16;
            pbHeader.TabStop = false;
            // 
            // Transactions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(dataGridView1);
            Controls.Add(pbFooter);
            Controls.Add(pbHeader);
            Name = "Transactions";
            Size = new Size(1064, 654);
            Load += controlRecords_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFooter).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHeader).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private PictureBox pbFooter;
        private PictureBox pbHeader;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Products;
        private DataGridViewTextBoxColumn AmountDue;
        private DataGridViewTextBoxColumn Discount;
        private DataGridViewTextBoxColumn CashTendered;
        private DataGridViewTextBoxColumn Change;
        private DataGridViewButtonColumn Receipt;
    }
}

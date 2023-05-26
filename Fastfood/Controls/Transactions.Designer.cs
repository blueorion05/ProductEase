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
            dtStart = new DateTimePicker();
            dtEnd = new DateTimePicker();
            textBox1 = new TextBox();
            label1 = new Label();
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
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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
            pbHeader.Click += pbHeader_Click;
            // 
            // dtStart
            // 
            dtStart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtStart.CalendarFont = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtStart.CalendarForeColor = Color.Black;
            dtStart.CalendarMonthBackground = Color.Transparent;
            dtStart.CalendarTitleBackColor = Color.Transparent;
            dtStart.CalendarTitleForeColor = Color.Black;
            dtStart.CustomFormat = "dd-MMM-yyyy";
            dtStart.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtStart.Format = DateTimePickerFormat.Custom;
            dtStart.Location = new Point(825, 15);
            dtStart.MaxDate = new DateTime(3000, 12, 31, 0, 0, 0, 0);
            dtStart.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtStart.Name = "dtStart";
            dtStart.Size = new Size(98, 22);
            dtStart.TabIndex = 18;
            dtStart.ValueChanged += dtStart_ValueChanged;
            // 
            // dtEnd
            // 
            dtEnd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtEnd.CalendarFont = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtEnd.CalendarForeColor = Color.Black;
            dtEnd.CalendarMonthBackground = Color.Transparent;
            dtEnd.CalendarTitleBackColor = Color.Transparent;
            dtEnd.CalendarTitleForeColor = Color.Black;
            dtEnd.CustomFormat = "dd-MMM-yyyy";
            dtEnd.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtEnd.Format = DateTimePickerFormat.Custom;
            dtEnd.Location = new Point(951, 15);
            dtEnd.MaxDate = new DateTime(3000, 12, 31, 0, 0, 0, 0);
            dtEnd.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtEnd.Name = "dtEnd";
            dtEnd.Size = new Size(98, 22);
            dtEnd.TabIndex = 19;
            dtEnd.ValueChanged += dtEnd_ValueChanged;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(14, 15);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search Product Name here.";
            textBox1.Size = new Size(422, 22);
            textBox1.TabIndex = 24;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.BackColor = Color.FromArgb(0, 150, 136);
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(924, 2);
            label1.Name = "label1";
            label1.Size = new Size(21, 33);
            label1.TabIndex = 25;
            label1.Text = "-";
            // 
            // Transactions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dtEnd);
            Controls.Add(dtStart);
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
            PerformLayout();
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
        private DateTimePicker dtStart;
        private DateTimePicker dtEnd;
        private TextBox textBox1;
        private Label label1;
    }
}

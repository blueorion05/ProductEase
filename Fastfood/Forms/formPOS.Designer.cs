namespace Fastfood
{
    partial class formPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPOS));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            lbl1Company = new Label();
            button5 = new Button();
            btnMinimize = new Button();
            btnExit = new Button();
            btnSearch = new Button();
            textBox1 = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            button9 = new Button();
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
            Product_Name = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Add = new DataGridViewButtonColumn();
            Reduce = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            panel6 = new Panel();
            lbl7amount = new Label();
            lbl6total = new Label();
            btn1pay = new Button();
            lbl2orderno = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panelHeader.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(25, 26, 62);
            panelHeader.Controls.Add(lbl1Company);
            panelHeader.Controls.Add(button5);
            panelHeader.Controls.Add(btnMinimize);
            panelHeader.Controls.Add(btnExit);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1064, 64);
            panelHeader.TabIndex = 9;
            // 
            // lbl1Company
            // 
            lbl1Company.AutoSize = true;
            lbl1Company.BackColor = Color.Transparent;
            lbl1Company.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1Company.ForeColor = Color.White;
            lbl1Company.Location = new Point(12, 16);
            lbl1Company.Name = "lbl1Company";
            lbl1Company.Size = new Size(142, 30);
            lbl1Company.TabIndex = 25;
            lbl1Company.Text = "COMPANY";
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.BackColor = Color.Transparent;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseOverBackColor = Color.Red;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(1034, 0);
            button5.Name = "button5";
            button5.Size = new Size(30, 25);
            button5.TabIndex = 25;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.Location = new Point(1864, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(30, 25);
            btnMinimize.TabIndex = 1;
            btnMinimize.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.Transparent;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseOverBackColor = Color.Red;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(1896, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(30, 25);
            btnExit.TabIndex = 0;
            btnExit.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 150, 136);
            btnSearch.Dock = DockStyle.Left;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(938, 0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(126, 53);
            btnSearch.TabIndex = 22;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(6, 14);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(422, 24);
            textBox1.TabIndex = 21;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 150, 136);
            button4.Dock = DockStyle.Left;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(378, 0);
            button4.Name = "button4";
            button4.Size = new Size(126, 53);
            button4.TabIndex = 19;
            button4.Text = "Dessert";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 150, 136);
            button3.Dock = DockStyle.Left;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(252, 0);
            button3.Name = "button3";
            button3.Size = new Size(126, 53);
            button3.TabIndex = 18;
            button3.Text = "Drinks";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 150, 136);
            button2.Dock = DockStyle.Left;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(126, 0);
            button2.Name = "button2";
            button2.Size = new Size(126, 53);
            button2.TabIndex = 17;
            button2.Text = "Food";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 150, 136);
            button1.Dock = DockStyle.Left;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(126, 53);
            button1.TabIndex = 16;
            button1.Text = "All";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 150, 136);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(1064, 53);
            panel1.TabIndex = 23;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(504, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(434, 53);
            panel3.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 150, 136);
            panel2.Controls.Add(button9);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 457);
            panel2.Name = "panel2";
            panel2.Size = new Size(1064, 53);
            panel2.TabIndex = 24;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(0, 150, 136);
            button9.Dock = DockStyle.Left;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button9.ForeColor = Color.White;
            button9.Location = new Point(0, 0);
            button9.Name = "button9";
            button9.Size = new Size(126, 53);
            button9.TabIndex = 16;
            button9.Text = "Cancel";
            button9.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(dataGridView1);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(lbl2orderno);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(725, 117);
            panel4.Name = "panel4";
            panel4.Size = new Size(339, 340);
            panel4.TabIndex = 25;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Product_Name, Quantity, Price, Add, Reduce, Delete });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(0, 17);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(339, 209);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Product_Name
            // 
            Product_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Product_Name.DataPropertyName = "Product_Name";
            Product_Name.HeaderText = "Name";
            Product_Name.MinimumWidth = 135;
            Product_Name.Name = "Product_Name";
            Product_Name.ReadOnly = true;
            Product_Name.Width = 135;
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Quantity.HeaderText = "Qty";
            Quantity.MinimumWidth = 54;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 54;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Price";
            Price.MinimumWidth = 65;
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 65;
            // 
            // Add
            // 
            Add.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.NullValue = "+";
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            Add.DefaultCellStyle = dataGridViewCellStyle2;
            Add.FlatStyle = FlatStyle.Flat;
            Add.HeaderText = "";
            Add.MinimumWidth = 27;
            Add.Name = "Add";
            Add.ReadOnly = true;
            Add.Resizable = DataGridViewTriState.True;
            Add.SortMode = DataGridViewColumnSortMode.Automatic;
            Add.UseColumnTextForButtonValue = true;
            Add.Width = 27;
            // 
            // Reduce
            // 
            Reduce.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.NullValue = "-";
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            Reduce.DefaultCellStyle = dataGridViewCellStyle3;
            Reduce.FlatStyle = FlatStyle.Flat;
            Reduce.HeaderText = "";
            Reduce.MinimumWidth = 27;
            Reduce.Name = "Reduce";
            Reduce.ReadOnly = true;
            Reduce.UseColumnTextForButtonValue = true;
            Reduce.Width = 27;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(219, 88, 96);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.NullValue = "X";
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(219, 88, 96);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            Delete.DefaultCellStyle = dataGridViewCellStyle4;
            Delete.FlatStyle = FlatStyle.Flat;
            Delete.HeaderText = "";
            Delete.MinimumWidth = 27;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 27;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(lbl7amount);
            panel6.Controls.Add(lbl6total);
            panel6.Controls.Add(btn1pay);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 226);
            panel6.Name = "panel6";
            panel6.Size = new Size(339, 114);
            panel6.TabIndex = 3;
            // 
            // lbl7amount
            // 
            lbl7amount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl7amount.AutoSize = true;
            lbl7amount.BackColor = Color.Transparent;
            lbl7amount.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl7amount.ForeColor = Color.Black;
            lbl7amount.Location = new Point(147, 16);
            lbl7amount.Name = "lbl7amount";
            lbl7amount.Size = new Size(89, 22);
            lbl7amount.TabIndex = 10;
            lbl7amount.Text = "Php 0.00";
            // 
            // lbl6total
            // 
            lbl6total.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl6total.AutoSize = true;
            lbl6total.BackColor = Color.Transparent;
            lbl6total.ForeColor = Color.Black;
            lbl6total.Location = new Point(105, 23);
            lbl6total.Name = "lbl6total";
            lbl6total.Size = new Size(37, 17);
            lbl6total.TabIndex = 9;
            lbl6total.Text = "Total";
            // 
            // btn1pay
            // 
            btn1pay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn1pay.BackColor = Color.FromArgb(0, 150, 136);
            btn1pay.FlatAppearance.BorderSize = 0;
            btn1pay.FlatStyle = FlatStyle.Flat;
            btn1pay.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn1pay.ForeColor = Color.White;
            btn1pay.Location = new Point(110, 55);
            btn1pay.Name = "btn1pay";
            btn1pay.Size = new Size(131, 53);
            btn1pay.TabIndex = 8;
            btn1pay.Text = "PAY";
            btn1pay.UseVisualStyleBackColor = false;
            // 
            // lbl2orderno
            // 
            lbl2orderno.AutoSize = true;
            lbl2orderno.BackColor = Color.Transparent;
            lbl2orderno.Dock = DockStyle.Top;
            lbl2orderno.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl2orderno.ForeColor = Color.Black;
            lbl2orderno.Location = new Point(0, 0);
            lbl2orderno.Name = "lbl2orderno";
            lbl2orderno.Size = new Size(63, 17);
            lbl2orderno.TabIndex = 2;
            lbl2orderno.Text = "Order no.";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 117);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(50, 0, 50, 0);
            flowLayoutPanel1.Size = new Size(725, 340);
            flowLayoutPanel1.TabIndex = 26;
            // 
            // formPOS
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 510);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelHeader);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formPOS";
            Text = "formPOS";
            WindowState = FormWindowState.Maximized;
            Load += formPOS_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Button btnMinimize;
        private Button btnExit;
        private Button btnSearch;
        private TextBox textBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel1;
        private Panel panel2;
        private Button button9;
        private Button button5;
        private Label lbl1Company;
        private Panel panel3;
        private Panel panel4;
        public DataGridView dataGridView1;
        private Label lbl2orderno;
        private Panel panel6;
        private Button btn1pay;
        private Label lbl6total;
        private Label lbl7amount;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridViewTextBoxColumn Product_Name;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewButtonColumn Add;
        private DataGridViewButtonColumn Reduce;
        private DataGridViewButtonColumn Delete;
    }
}
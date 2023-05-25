namespace Fastfood
{
    partial class Manage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage));
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            pbHeader = new PictureBox();
            pbFooter = new PictureBox();
            btnAdd = new Button();
            Id = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            tableProductC1 = new DataGridViewTextBoxColumn();
            tableProductC2 = new DataGridViewTextBoxColumn();
            tableProductC3 = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Image = new DataGridViewTextBoxColumn();
            tableProduct = new DataGridView();
            tableProductC4 = new DataGridViewTextBoxColumn();
            tableProductC5 = new DataGridViewTextBoxColumn();
            Product_Name = new DataGridViewTextBoxColumn();
            tableProductC6 = new DataGridViewTextBoxColumn();
            tableProductC7 = new DataGridViewImageColumn();
            Available = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbHeader).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFooter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tableProduct).BeginInit();
            SuspendLayout();
            // 
            // pbHeader
            // 
            pbHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbHeader.BackColor = Color.FromArgb(0, 150, 136);
            pbHeader.BackgroundImageLayout = ImageLayout.None;
            pbHeader.Location = new Point(0, 0);
            pbHeader.Name = "pbHeader";
            pbHeader.Size = new Size(1064, 53);
            pbHeader.TabIndex = 14;
            pbHeader.TabStop = false;
            // 
            // pbFooter
            // 
            pbFooter.BackColor = Color.FromArgb(0, 150, 136);
            pbFooter.BackgroundImageLayout = ImageLayout.None;
            pbFooter.Dock = DockStyle.Bottom;
            pbFooter.Location = new Point(0, 601);
            pbFooter.Name = "pbFooter";
            pbFooter.Size = new Size(1064, 53);
            pbFooter.TabIndex = 15;
            pbFooter.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 150, 136);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(0, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 53);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += button4_Click;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.Name = "Category";
            // 
            // tableProductC1
            // 
            tableProductC1.HeaderText = "Id";
            tableProductC1.Name = "tableProductC1";
            // 
            // tableProductC2
            // 
            tableProductC2.HeaderText = "Category";
            tableProductC2.Name = "tableProductC2";
            // 
            // tableProductC3
            // 
            tableProductC3.HeaderText = "Product_Name";
            tableProductC3.Name = "tableProductC3";
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.Name = "Price";
            // 
            // Image
            // 
            Image.HeaderText = "Image";
            Image.Name = "Image";
            // 
            // tableProduct
            // 
            tableProduct.AllowUserToAddRows = false;
            tableProduct.AllowUserToDeleteRows = false;
            tableProduct.AllowUserToResizeColumns = false;
            tableProduct.AllowUserToResizeRows = false;
            tableProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableProduct.BackgroundColor = Color.White;
            tableProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableProduct.Columns.AddRange(new DataGridViewColumn[] { tableProductC4, tableProductC5, Product_Name, tableProductC6, tableProductC7, Available, Edit, Delete });
            tableProduct.GridColor = Color.Black;
            tableProduct.Location = new Point(3, 59);
            tableProduct.MultiSelect = false;
            tableProduct.Name = "tableProduct";
            tableProduct.ReadOnly = true;
            tableProduct.RowHeadersVisible = false;
            tableProduct.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tableProduct.RowTemplate.Height = 50;
            tableProduct.ShowEditingIcon = false;
            tableProduct.Size = new Size(1058, 536);
            tableProduct.TabIndex = 0;
            tableProduct.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tableProductC4
            // 
            tableProductC4.DataPropertyName = "Id";
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tableProductC4.DefaultCellStyle = dataGridViewCellStyle1;
            tableProductC4.HeaderText = "Id";
            tableProductC4.Name = "tableProductC4";
            tableProductC4.ReadOnly = true;
            tableProductC4.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // tableProductC5
            // 
            tableProductC5.DataPropertyName = "Category";
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tableProductC5.DefaultCellStyle = dataGridViewCellStyle2;
            tableProductC5.HeaderText = "Category";
            tableProductC5.Name = "tableProductC5";
            tableProductC5.ReadOnly = true;
            tableProductC5.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Product_Name
            // 
            Product_Name.DataPropertyName = "Product_Name";
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Product_Name.DefaultCellStyle = dataGridViewCellStyle3;
            Product_Name.HeaderText = "Product Name";
            Product_Name.Name = "Product_Name";
            Product_Name.ReadOnly = true;
            Product_Name.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // tableProductC6
            // 
            tableProductC6.DataPropertyName = "Price";
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tableProductC6.DefaultCellStyle = dataGridViewCellStyle4;
            tableProductC6.HeaderText = "Price";
            tableProductC6.Name = "tableProductC6";
            tableProductC6.ReadOnly = true;
            tableProductC6.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // tableProductC7
            // 
            tableProductC7.DataPropertyName = "Image";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.NullValue = resources.GetObject("dataGridViewCellStyle5.NullValue");
            tableProductC7.DefaultCellStyle = dataGridViewCellStyle5;
            tableProductC7.HeaderText = "Image";
            tableProductC7.ImageLayout = DataGridViewImageCellLayout.Stretch;
            tableProductC7.Name = "tableProductC7";
            tableProductC7.ReadOnly = true;
            tableProductC7.Resizable = DataGridViewTriState.False;
            // 
            // Available
            // 
            Available.DataPropertyName = "Available";
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Available.DefaultCellStyle = dataGridViewCellStyle6;
            Available.HeaderText = "Is Available?";
            Available.Name = "Available";
            Available.ReadOnly = true;
            Available.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Edit
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle7.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            Edit.DefaultCellStyle = dataGridViewCellStyle7;
            Edit.FlatStyle = FlatStyle.Flat;
            Edit.HeaderText = "";
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(219, 88, 96);
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(219, 88, 96);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            Delete.DefaultCellStyle = dataGridViewCellStyle8;
            Delete.FlatStyle = FlatStyle.Flat;
            Delete.HeaderText = "";
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(115, 16);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search Product Name here.";
            textBox1.Size = new Size(422, 22);
            textBox1.TabIndex = 23;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Manage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(textBox1);
            Controls.Add(tableProduct);
            Controls.Add(btnAdd);
            Controls.Add(pbFooter);
            Controls.Add(pbHeader);
            ForeColor = Color.Black;
            Name = "Manage";
            Size = new Size(1064, 654);
            Load += controlManage_Load;
            Click += Manage_Click;
            ((System.ComponentModel.ISupportInitialize)pbHeader).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFooter).EndInit();
            ((System.ComponentModel.ISupportInitialize)tableProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbHeader;
        private PictureBox pbFooter;
        private Button btnAdd;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn tableProductC1;
        private DataGridViewTextBoxColumn tableProductC2;
        private DataGridViewTextBoxColumn tableProductC3;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Image;
        public DataGridView tableProduct;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn tableProductC4;
        private DataGridViewTextBoxColumn tableProductC5;
        private DataGridViewTextBoxColumn Product_Name;
        private DataGridViewTextBoxColumn tableProductC6;
        private DataGridViewImageColumn tableProductC7;
        private DataGridViewTextBoxColumn Available;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}

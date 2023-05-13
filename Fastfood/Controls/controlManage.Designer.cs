namespace Fastfood
{
    partial class controlManage
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            tableProductC7 = new DataGridViewTextBoxColumn();
            Available = new DataGridViewTextBoxColumn();
            Picture = new DataGridViewImageColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)pbHeader).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFooter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tableProduct).BeginInit();
            SuspendLayout();
            // 
            // pbHeader
            // 
            pbHeader.BackColor = Color.FromArgb(0, 150, 136);
            pbHeader.BackgroundImageLayout = ImageLayout.None;
            pbHeader.Dock = DockStyle.Top;
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
            tableProduct.Columns.AddRange(new DataGridViewColumn[] { tableProductC4, tableProductC5, Product_Name, tableProductC6, tableProductC7, Available, Picture, Edit, Delete });
            tableProduct.GridColor = Color.Black;
            tableProduct.Location = new Point(3, 59);
            tableProduct.MultiSelect = false;
            tableProduct.Name = "tableProduct";
            tableProduct.ReadOnly = true;
            tableProduct.RowHeadersVisible = false;
            tableProduct.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tableProduct.RowTemplate.Height = 25;
            tableProduct.ShowEditingIcon = false;
            tableProduct.Size = new Size(1058, 536);
            tableProduct.TabIndex = 0;
            tableProduct.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tableProductC4
            // 
            tableProductC4.DataPropertyName = "Id";
            tableProductC4.HeaderText = "Id";
            tableProductC4.Name = "tableProductC4";
            tableProductC4.ReadOnly = true;
            // 
            // tableProductC5
            // 
            tableProductC5.DataPropertyName = "Category";
            tableProductC5.HeaderText = "Category";
            tableProductC5.Name = "tableProductC5";
            tableProductC5.ReadOnly = true;
            // 
            // Product_Name
            // 
            Product_Name.DataPropertyName = "Product_Name";
            Product_Name.HeaderText = "Product Name";
            Product_Name.Name = "Product_Name";
            Product_Name.ReadOnly = true;
            // 
            // tableProductC6
            // 
            tableProductC6.DataPropertyName = "Price";
            tableProductC6.HeaderText = "Price";
            tableProductC6.Name = "tableProductC6";
            tableProductC6.ReadOnly = true;
            // 
            // tableProductC7
            // 
            tableProductC7.DataPropertyName = "Image";
            tableProductC7.HeaderText = "Image Path";
            tableProductC7.Name = "tableProductC7";
            tableProductC7.ReadOnly = true;
            // 
            // Available
            // 
            Available.DataPropertyName = "Available";
            Available.HeaderText = "Is Available?";
            Available.Name = "Available";
            Available.ReadOnly = true;
            // 
            // Picture
            // 
            Picture.DataPropertyName = "Picture";
            Picture.HeaderText = "Image";
            Picture.Name = "Picture";
            Picture.ReadOnly = true;
            // 
            // Edit
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            Edit.DefaultCellStyle = dataGridViewCellStyle3;
            Edit.FlatStyle = FlatStyle.Flat;
            Edit.HeaderText = "";
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(219, 88, 96);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(219, 88, 96);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            Delete.DefaultCellStyle = dataGridViewCellStyle4;
            Delete.FlatStyle = FlatStyle.Flat;
            Delete.HeaderText = "";
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // controlManage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(tableProduct);
            Controls.Add(btnAdd);
            Controls.Add(pbFooter);
            Controls.Add(pbHeader);
            ForeColor = Color.Black;
            Name = "controlManage";
            Size = new Size(1064, 654);
            Load += controlManage_Load;
            ((System.ComponentModel.ISupportInitialize)pbHeader).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFooter).EndInit();
            ((System.ComponentModel.ISupportInitialize)tableProduct).EndInit();
            ResumeLayout(false);
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
        private DataGridViewTextBoxColumn tableProductC4;
        private DataGridViewTextBoxColumn tableProductC5;
        private DataGridViewTextBoxColumn Product_Name;
        private DataGridViewTextBoxColumn tableProductC6;
        private DataGridViewTextBoxColumn tableProductC7;
        private DataGridViewTextBoxColumn Available;
        private DataGridViewImageColumn Picture;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}

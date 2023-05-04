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
            lbl1manage = new Label();
            tableItems = new DataGridView();
            btnAdd = new Button();
            lblId = new Label();
            lblCategory = new Label();
            lblItem = new Label();
            lblPrice = new Label();
            tbId = new TextBox();
            tbCategory = new TextBox();
            tbItem = new TextBox();
            tbPrice = new TextBox();
            pictureBox1 = new PictureBox();
            btnBrowse = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)tableItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl1manage
            // 
            lbl1manage.AutoSize = true;
            lbl1manage.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1manage.Location = new Point(0, 0);
            lbl1manage.Name = "lbl1manage";
            lbl1manage.Size = new Size(89, 30);
            lbl1manage.TabIndex = 1;
            lbl1manage.Text = "Manage";
            // 
            // tableItems
            // 
            tableItems.AllowUserToAddRows = false;
            tableItems.AllowUserToDeleteRows = false;
            tableItems.AllowUserToResizeColumns = false;
            tableItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableItems.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            tableItems.Location = new Point(42, 274);
            tableItems.Name = "tableItems";
            tableItems.ReadOnly = true;
            tableItems.RowTemplate.Height = 25;
            tableItems.Size = new Size(973, 150);
            tableItems.TabIndex = 2;
            tableItems.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(79, 204);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(79, 61);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 4;
            lblId.Text = "ID";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(79, 93);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 5;
            lblCategory.Text = "Category";
            lblCategory.Click += lblCategory_Click;
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Location = new Point(79, 122);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(31, 15);
            lblItem.TabIndex = 6;
            lblItem.Text = "Item";
            lblItem.Click += label2_Click;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(79, 151);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "Price";
            // 
            // tbId
            // 
            tbId.Location = new Point(152, 58);
            tbId.Name = "tbId";
            tbId.ReadOnly = true;
            tbId.Size = new Size(217, 23);
            tbId.TabIndex = 8;
            // 
            // tbCategory
            // 
            tbCategory.Location = new Point(152, 90);
            tbCategory.Name = "tbCategory";
            tbCategory.Size = new Size(217, 23);
            tbCategory.TabIndex = 9;
            // 
            // tbItem
            // 
            tbItem.Location = new Point(152, 119);
            tbItem.Name = "tbItem";
            tbItem.Size = new Size(217, 23);
            tbItem.TabIndex = 10;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(152, 148);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(217, 23);
            tbPrice.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(418, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(458, 184);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 13;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // Column1
            // 
            Column1.FillWeight = 126.903557F;
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.False;
            // 
            // Column2
            // 
            Column2.FillWeight = 93.27411F;
            Column2.HeaderText = "Category";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Resizable = DataGridViewTriState.False;
            Column2.Width = 174;
            // 
            // Column3
            // 
            Column3.FillWeight = 93.27411F;
            Column3.HeaderText = "Item";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Resizable = DataGridViewTriState.False;
            Column3.Width = 309;
            // 
            // Column4
            // 
            Column4.FillWeight = 93.27411F;
            Column4.HeaderText = "Price";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Resizable = DataGridViewTriState.False;
            Column4.Width = 174;
            // 
            // Column5
            // 
            Column5.FillWeight = 93.27411F;
            Column5.HeaderText = "Image";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Resizable = DataGridViewTriState.False;
            Column5.SortMode = DataGridViewColumnSortMode.Automatic;
            Column5.Width = 173;
            // 
            // controlManage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnBrowse);
            Controls.Add(pictureBox1);
            Controls.Add(tbPrice);
            Controls.Add(tbItem);
            Controls.Add(tbCategory);
            Controls.Add(tbId);
            Controls.Add(lblPrice);
            Controls.Add(lblItem);
            Controls.Add(lblCategory);
            Controls.Add(lblId);
            Controls.Add(btnAdd);
            Controls.Add(tableItems);
            Controls.Add(lbl1manage);
            Name = "controlManage";
            Size = new Size(1064, 654);
            Load += controlManage_Load;
            ((System.ComponentModel.ISupportInitialize)tableItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1manage;
        private DataGridView tableItems;
        private Button btnAdd;
        private Label lblId;
        private Label lblCategory;
        private Label lblItem;
        private Label lblPrice;
        private TextBox tbId;
        private TextBox tbCategory;
        private TextBox tbItem;
        private TextBox tbPrice;
        private PictureBox pictureBox1;
        private Button btnBrowse;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewImageColumn Column5;
    }
}

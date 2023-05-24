namespace Fastfood
{
    partial class Category
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
            tableCategory = new DataGridView();
            tableProductC5 = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)tableCategory).BeginInit();
            SuspendLayout();
            // 
            // tableCategory
            // 
            tableCategory.AllowUserToAddRows = false;
            tableCategory.AllowUserToDeleteRows = false;
            tableCategory.AllowUserToResizeColumns = false;
            tableCategory.AllowUserToResizeRows = false;
            tableCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableCategory.BackgroundColor = Color.White;
            tableCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableCategory.Columns.AddRange(new DataGridViewColumn[] { tableProductC5, Edit, Delete });
            tableCategory.GridColor = Color.Black;
            tableCategory.Location = new Point(17, 16);
            tableCategory.MultiSelect = false;
            tableCategory.Name = "tableCategory";
            tableCategory.ReadOnly = true;
            tableCategory.RowHeadersVisible = false;
            tableCategory.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tableCategory.RowTemplate.Height = 50;
            tableCategory.ShowEditingIcon = false;
            tableCategory.Size = new Size(535, 258);
            tableCategory.TabIndex = 1;
            tableCategory.CellContentClick += tableCategory_CellContentClick;
            // 
            // tableProductC5
            // 
            tableProductC5.DataPropertyName = "Category";
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tableProductC5.DefaultCellStyle = dataGridViewCellStyle1;
            tableProductC5.HeaderText = "Category";
            tableProductC5.Name = "tableProductC5";
            tableProductC5.ReadOnly = true;
            tableProductC5.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Edit
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            Edit.DefaultCellStyle = dataGridViewCellStyle2;
            Edit.FlatStyle = FlatStyle.Flat;
            Edit.HeaderText = "";
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(219, 88, 96);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(219, 88, 96);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            Delete.DefaultCellStyle = dataGridViewCellStyle3;
            Delete.FlatStyle = FlatStyle.Flat;
            Delete.HeaderText = "";
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(0, 150, 136);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(17, 280);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(97, 43);
            btnClose.TabIndex = 50;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // Category
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 26, 62);
            Controls.Add(btnClose);
            Controls.Add(tableCategory);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Category";
            Size = new Size(567, 342);
            Enter += Category_Enter;
            ((System.ComponentModel.ISupportInitialize)tableCategory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView tableCategory;
        private DataGridViewTextBoxColumn tableProductC5;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button btnClose;
    }
}

namespace Fastfood
{
    partial class formAddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAddProduct));
            cbAvailable = new ComboBox();
            btnSave = new Button();
            lblAvailable = new Label();
            cbCategory = new ComboBox();
            tbImage = new TextBox();
            btnBrowse = new Button();
            tbPrice = new TextBox();
            lblCategory = new Label();
            lblPrice = new Label();
            tbName = new TextBox();
            lblId = new Label();
            lblName = new Label();
            btnCancel = new Button();
            pbImage = new PictureBox();
            btnClear = new Button();
            lblRequired1 = new Label();
            lblRequired2 = new Label();
            lblRequired3 = new Label();
            lblRequired4 = new Label();
            lblRequired5 = new Label();
            lblRequired = new Label();
            lblIdNum = new Label();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // cbAvailable
            // 
            cbAvailable.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAvailable.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbAvailable.FormattingEnabled = true;
            cbAvailable.Items.AddRange(new object[] { "Yes", "No" });
            cbAvailable.Location = new Point(148, 146);
            cbAvailable.Name = "cbAvailable";
            cbAvailable.Size = new Size(201, 25);
            cbAvailable.TabIndex = 48;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 150, 136);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(27, 267);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(97, 43);
            btnSave.TabIndex = 47;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += button4_Click;
            // 
            // lblAvailable
            // 
            lblAvailable.AutoSize = true;
            lblAvailable.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAvailable.ForeColor = Color.White;
            lblAvailable.Location = new Point(27, 148);
            lblAvailable.Name = "lblAvailable";
            lblAvailable.Size = new Size(89, 17);
            lblAvailable.TabIndex = 46;
            lblAvailable.Text = "Is Available?";
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbCategory.FormattingEnabled = true;
            cbCategory.Items.AddRange(new object[] { "Food", "Drinks", "Dessert" });
            cbCategory.Location = new Point(148, 58);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(201, 25);
            cbCategory.TabIndex = 44;
            // 
            // tbImage
            // 
            tbImage.Enabled = false;
            tbImage.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbImage.Location = new Point(370, 197);
            tbImage.Name = "tbImage";
            tbImage.PlaceholderText = "Browse to add/replace image.";
            tbImage.ReadOnly = true;
            tbImage.Size = new Size(166, 22);
            tbImage.TabIndex = 43;
            tbImage.TextChanged += tbImage_TextChanged;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.FromArgb(0, 150, 136);
            btnBrowse.FlatAppearance.BorderSize = 0;
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBrowse.ForeColor = Color.White;
            btnBrowse.Location = new Point(370, 221);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(97, 35);
            btnBrowse.TabIndex = 41;
            btnBrowse.Text = "BROWSE";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += button3_Click;
            // 
            // tbPrice
            // 
            tbPrice.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbPrice.Location = new Point(148, 118);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(201, 22);
            tbPrice.TabIndex = 40;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategory.ForeColor = Color.White;
            lblCategory.Location = new Point(27, 60);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(73, 17);
            lblCategory.TabIndex = 39;
            lblCategory.Text = "Category:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrice.ForeColor = Color.White;
            lblPrice.Location = new Point(27, 120);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(43, 17);
            lblPrice.TabIndex = 38;
            lblPrice.Text = "Price:";
            // 
            // tbName
            // 
            tbName.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbName.Location = new Point(148, 89);
            tbName.Name = "tbName";
            tbName.Size = new Size(201, 22);
            tbName.TabIndex = 37;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblId.ForeColor = Color.White;
            lblId.Location = new Point(27, 34);
            lblId.Name = "lblId";
            lblId.Size = new Size(80, 17);
            lblId.TabIndex = 35;
            lblId.Text = "Product ID:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(27, 91);
            lblName.Name = "lblName";
            lblName.Size = new Size(105, 17);
            lblName.TabIndex = 34;
            lblName.Text = "Product name:";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(0, 150, 136);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(148, 267);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(97, 43);
            btnCancel.TabIndex = 49;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += button1_Click;
            // 
            // pbImage
            // 
            pbImage.BackColor = Color.Transparent;
            pbImage.BackgroundImage = (Image)resources.GetObject("pbImage.BackgroundImage");
            pbImage.BackgroundImageLayout = ImageLayout.Stretch;
            pbImage.BorderStyle = BorderStyle.FixedSingle;
            pbImage.ErrorImage = (Image)resources.GetObject("pbImage.ErrorImage");
            pbImage.InitialImage = (Image)resources.GetObject("pbImage.InitialImage");
            pbImage.Location = new Point(370, 29);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(166, 166);
            pbImage.TabIndex = 50;
            pbImage.TabStop = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(0, 150, 136);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(473, 221);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(63, 35);
            btnClear.TabIndex = 51;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += button2_Click;
            // 
            // lblRequired1
            // 
            lblRequired1.AutoSize = true;
            lblRequired1.BackColor = Color.Transparent;
            lblRequired1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblRequired1.ForeColor = Color.Red;
            lblRequired1.Location = new Point(130, 61);
            lblRequired1.Name = "lblRequired1";
            lblRequired1.Size = new Size(14, 17);
            lblRequired1.TabIndex = 52;
            lblRequired1.Text = "*";
            // 
            // lblRequired2
            // 
            lblRequired2.AutoSize = true;
            lblRequired2.BackColor = Color.Transparent;
            lblRequired2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblRequired2.ForeColor = Color.Red;
            lblRequired2.Location = new Point(130, 91);
            lblRequired2.Name = "lblRequired2";
            lblRequired2.Size = new Size(14, 17);
            lblRequired2.TabIndex = 54;
            lblRequired2.Text = "*";
            // 
            // lblRequired3
            // 
            lblRequired3.AutoSize = true;
            lblRequired3.BackColor = Color.Transparent;
            lblRequired3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblRequired3.ForeColor = Color.Red;
            lblRequired3.Location = new Point(130, 119);
            lblRequired3.Name = "lblRequired3";
            lblRequired3.Size = new Size(14, 17);
            lblRequired3.TabIndex = 55;
            lblRequired3.Text = "*";
            // 
            // lblRequired4
            // 
            lblRequired4.AutoSize = true;
            lblRequired4.BackColor = Color.Transparent;
            lblRequired4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblRequired4.ForeColor = Color.Red;
            lblRequired4.Location = new Point(130, 149);
            lblRequired4.Name = "lblRequired4";
            lblRequired4.Size = new Size(14, 17);
            lblRequired4.TabIndex = 56;
            lblRequired4.Text = "*";
            // 
            // lblRequired5
            // 
            lblRequired5.AutoSize = true;
            lblRequired5.BackColor = Color.Transparent;
            lblRequired5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblRequired5.ForeColor = Color.Red;
            lblRequired5.Location = new Point(208, 174);
            lblRequired5.Name = "lblRequired5";
            lblRequired5.Size = new Size(14, 17);
            lblRequired5.TabIndex = 57;
            lblRequired5.Text = "*";
            // 
            // lblRequired
            // 
            lblRequired.AutoSize = true;
            lblRequired.BackColor = Color.Transparent;
            lblRequired.Font = new Font("Century Gothic", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblRequired.ForeColor = Color.White;
            lblRequired.Location = new Point(148, 171);
            lblRequired.Name = "lblRequired";
            lblRequired.Size = new Size(64, 15);
            lblRequired.TabIndex = 58;
            lblRequired.Text = "Fill all with ";
            // 
            // lblIdNum
            // 
            lblIdNum.AutoSize = true;
            lblIdNum.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdNum.ForeColor = Color.White;
            lblIdNum.Location = new Point(148, 34);
            lblIdNum.Name = "lblIdNum";
            lblIdNum.Size = new Size(0, 17);
            lblIdNum.TabIndex = 59;
            // 
            // formAddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 26, 62);
            ClientSize = new Size(567, 342);
            Controls.Add(lblIdNum);
            Controls.Add(lblRequired);
            Controls.Add(lblRequired5);
            Controls.Add(lblRequired4);
            Controls.Add(lblRequired3);
            Controls.Add(lblRequired2);
            Controls.Add(lblRequired1);
            Controls.Add(btnClear);
            Controls.Add(pbImage);
            Controls.Add(btnCancel);
            Controls.Add(cbAvailable);
            Controls.Add(btnSave);
            Controls.Add(lblAvailable);
            Controls.Add(cbCategory);
            Controls.Add(tbImage);
            Controls.Add(btnBrowse);
            Controls.Add(tbPrice);
            Controls.Add(lblCategory);
            Controls.Add(lblPrice);
            Controls.Add(tbName);
            Controls.Add(lblId);
            Controls.Add(lblName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formAddProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formAddProduct";
            Load += formAddProduct_Load;
            Click += formAddProduct_Click;
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbAvailable;
        private Button btnSave;
        private Label lblAvailable;
        private ComboBox cbCategory;
        private TextBox tbImage;
        private Button btnBrowse;
        private TextBox tbPrice;
        private Label lblCategory;
        private Label lblPrice;
        private TextBox tbName;
        private Label lblId;
        private Label lblName;
        private Button btnCancel;
        private PictureBox pbImage;
        private Button btnClear;
        private Label lblRequired1;
        private Label lblRequired2;
        private Label lblRequired3;
        private Label lblRequired4;
        private Label lblRequired5;
        private Label lblRequired;
        private Label lblIdNum;
    }
}
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
            comboBox1 = new ComboBox();
            button4 = new Button();
            label6 = new Label();
            label1 = new Label();
            cbCategory = new ComboBox();
            tbImage = new TextBox();
            button3 = new Button();
            tbPrice = new TextBox();
            label2 = new Label();
            label5 = new Label();
            tbName = new TextBox();
            tbId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Yes", "No" });
            comboBox1.Location = new Point(148, 176);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(201, 25);
            comboBox1.TabIndex = 48;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 150, 136);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(27, 267);
            button4.Name = "button4";
            button4.Size = new Size(97, 43);
            button4.TabIndex = 47;
            button4.Text = "SAVE";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(27, 178);
            label6.Name = "label6";
            label6.Size = new Size(89, 17);
            label6.TabIndex = 46;
            label6.Text = "Is Available?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 149);
            label1.Name = "label1";
            label1.Size = new Size(88, 17);
            label1.TabIndex = 45;
            label1.Text = "Image Path:";
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbCategory.FormattingEnabled = true;
            cbCategory.Items.AddRange(new object[] { "Food", "Drinks", "Dessert" });
            cbCategory.Location = new Point(148, 31);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(201, 25);
            cbCategory.TabIndex = 44;
            // 
            // tbImage
            // 
            tbImage.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbImage.Location = new Point(148, 147);
            tbImage.Name = "tbImage";
            tbImage.ReadOnly = true;
            tbImage.Size = new Size(201, 22);
            tbImage.TabIndex = 43;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 150, 136);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(402, 201);
            button3.Name = "button3";
            button3.Size = new Size(97, 35);
            button3.TabIndex = 41;
            button3.Text = "BROWSE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // tbPrice
            // 
            tbPrice.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbPrice.Location = new Point(148, 118);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(201, 22);
            tbPrice.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 33);
            label2.Name = "label2";
            label2.Size = new Size(73, 17);
            label2.TabIndex = 39;
            label2.Text = "Category:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(27, 120);
            label5.Name = "label5";
            label5.Size = new Size(43, 17);
            label5.TabIndex = 38;
            label5.Text = "Price:";
            // 
            // tbName
            // 
            tbName.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbName.Location = new Point(148, 89);
            tbName.Name = "tbName";
            tbName.Size = new Size(201, 22);
            tbName.TabIndex = 37;
            // 
            // tbId
            // 
            tbId.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbId.Location = new Point(148, 60);
            tbId.Name = "tbId";
            tbId.ReadOnly = true;
            tbId.Size = new Size(201, 22);
            tbId.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(27, 62);
            label4.Name = "label4";
            label4.Size = new Size(80, 17);
            label4.TabIndex = 35;
            label4.Text = "Product ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(27, 91);
            label3.Name = "label3";
            label3.Size = new Size(105, 17);
            label3.TabIndex = 34;
            label3.Text = "Product name:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 150, 136);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(148, 267);
            button1.Name = "button1";
            button1.Size = new Size(97, 43);
            button1.TabIndex = 49;
            button1.Text = "CANCEL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(0, 150, 136);
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(370, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 166);
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // formAddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 26, 62);
            ClientSize = new Size(567, 342);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(button4);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(cbCategory);
            Controls.Add(tbImage);
            Controls.Add(button3);
            Controls.Add(tbPrice);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(tbName);
            Controls.Add(tbId);
            Controls.Add(label4);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formAddProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formAddProduct";
            Load += formAddProduct_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button4;
        private Label label6;
        private Label label1;
        private ComboBox cbCategory;
        private TextBox tbImage;
        private Button button3;
        private TextBox tbPrice;
        private Label label2;
        private Label label5;
        private TextBox tbName;
        private TextBox tbId;
        private Label label4;
        private Label label3;
        private Button button1;
        private PictureBox pictureBox1;
    }
}
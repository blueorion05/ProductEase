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
            button2 = new Button();
            lblRequired1 = new Label();
            lblRequired2 = new Label();
            lblRequired3 = new Label();
            lblRequired4 = new Label();
            lblRequired5 = new Label();
            lblRequired = new Label();
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
            tbImage.PlaceholderText = "Click browse to add image path.";
            tbImage.ReadOnly = true;
            tbImage.Size = new Size(132, 22);
            tbImage.TabIndex = 43;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 150, 136);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(407, 201);
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
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(370, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 166);
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 150, 136);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(286, 147);
            button2.Name = "button2";
            button2.Size = new Size(63, 22);
            button2.TabIndex = 51;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lblRequired1
            // 
            lblRequired1.AutoSize = true;
            lblRequired1.BackColor = Color.Transparent;
            lblRequired1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblRequired1.ForeColor = Color.Red;
            lblRequired1.Location = new Point(130, 34);
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
            lblRequired4.Location = new Point(130, 179);
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
            lblRequired5.Location = new Point(208, 204);
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
            lblRequired.Location = new Point(148, 201);
            lblRequired.Name = "lblRequired";
            lblRequired.Size = new Size(64, 15);
            lblRequired.TabIndex = 58;
            lblRequired.Text = "Fill all with ";
            // 
            // formAddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 26, 62);
            ClientSize = new Size(567, 342);
            Controls.Add(lblRequired);
            Controls.Add(lblRequired5);
            Controls.Add(lblRequired4);
            Controls.Add(lblRequired3);
            Controls.Add(lblRequired2);
            Controls.Add(lblRequired1);
            Controls.Add(button2);
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
        private Button button2;
        private Label lblRequired1;
        private Label lblRequired2;
        private Label lblRequired3;
        private Label lblRequired4;
        private Label lblRequired5;
        private Label lblRequired;
    }
}
namespace Fastfood
{
    partial class controlOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controlOrder));
            lbl1order = new Label();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            ColID = new DataGridViewTextBoxColumn();
            ColName = new DataGridViewTextBoxColumn();
            ColDate = new DataGridViewTextBoxColumn();
            ColType = new DataGridViewTextBoxColumn();
            ColItem = new DataGridViewTextBoxColumn();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            label3 = new Label();
            label2 = new Label();
            Tb3 = new TextBox();
            Tb2 = new TextBox();
            Tb1 = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            btn1pay = new Button();
            lbl7amount = new Label();
            lbl6total = new Label();
            lbl5cost = new Label();
            lbl4quantity = new Label();
            lbl3item = new Label();
            pb1order = new PictureBox();
            lbl2orderno = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            toolStrip1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb1order).BeginInit();
            SuspendLayout();
            // 
            // lbl1order
            // 
            lbl1order.AutoSize = true;
            lbl1order.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1order.Location = new Point(0, 0);
            lbl1order.Margin = new Padding(4, 0, 4, 0);
            lbl1order.Name = "lbl1order";
            lbl1order.Size = new Size(102, 45);
            lbl1order.TabIndex = 2;
            lbl1order.Text = "Order";
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(toolStrip1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Tb3);
            panel1.Controls.Add(Tb2);
            panel1.Controls.Add(Tb1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(4, 55);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(781, 647);
            panel1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Product Type 1", "Product Type 2", "Product Type 3" });
            comboBox1.Location = new Point(98, 18);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(205, 33);
            comboBox1.TabIndex = 9;
            comboBox1.Text = "Category";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColID, ColName, ColDate, ColType, ColItem });
            dataGridView1.Location = new Point(3, 285);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(778, 362);
            dataGridView1.TabIndex = 8;
            // 
            // ColID
            // 
            ColID.HeaderText = "Product ID";
            ColID.MinimumWidth = 8;
            ColID.Name = "ColID";
            ColID.Width = 150;
            // 
            // ColName
            // 
            ColName.HeaderText = "Customer Name";
            ColName.MinimumWidth = 8;
            ColName.Name = "ColName";
            ColName.Width = 150;
            // 
            // ColDate
            // 
            ColDate.HeaderText = "Date Ordered";
            ColDate.MinimumWidth = 8;
            ColDate.Name = "ColDate";
            ColDate.Width = 150;
            // 
            // ColType
            // 
            ColType.HeaderText = "Product Type";
            ColType.MinimumWidth = 8;
            ColType.Name = "ColType";
            ColType.Width = 150;
            // 
            // ColItem
            // 
            ColItem.HeaderText = "Item";
            ColItem.MinimumWidth = 8;
            ColItem.Name = "ColItem";
            ColItem.Width = 150;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(3, 249);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(382, 34);
            toolStrip1.TabIndex = 7;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(101, 29);
            toolStripButton1.Text = "Add Order";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(117, 29);
            toolStripButton2.Text = "Delete Order";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(100, 29);
            toolStripButton3.Text = "Sort Order";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 148);
            label3.Name = "label3";
            label3.Size = new Size(48, 25);
            label3.TabIndex = 5;
            label3.Text = "Item";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 108);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // Tb3
            // 
            Tb3.Location = new Point(98, 145);
            Tb3.Name = "Tb3";
            Tb3.Size = new Size(205, 31);
            Tb3.TabIndex = 3;
            // 
            // Tb2
            // 
            Tb2.Location = new Point(98, 108);
            Tb2.Name = "Tb2";
            Tb2.Size = new Size(205, 31);
            Tb2.TabIndex = 2;
            // 
            // Tb1
            // 
            Tb1.Location = new Point(98, 66);
            Tb1.Name = "Tb1";
            Tb1.Size = new Size(205, 31);
            Tb1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 69);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // panel2
            // 
            panel2.Controls.Add(btn1pay);
            panel2.Controls.Add(lbl7amount);
            panel2.Controls.Add(lbl6total);
            panel2.Controls.Add(lbl5cost);
            panel2.Controls.Add(lbl4quantity);
            panel2.Controls.Add(lbl3item);
            panel2.Controls.Add(pb1order);
            panel2.Controls.Add(lbl2orderno);
            panel2.Location = new Point(789, 55);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(317, 647);
            panel2.TabIndex = 4;
            // 
            // btn1pay
            // 
            btn1pay.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn1pay.Location = new Point(27, 558);
            btn1pay.Margin = new Padding(4, 5, 4, 5);
            btn1pay.Name = "btn1pay";
            btn1pay.Size = new Size(264, 83);
            btn1pay.TabIndex = 7;
            btn1pay.Text = "PAY";
            btn1pay.UseVisualStyleBackColor = true;
            // 
            // lbl7amount
            // 
            lbl7amount.AutoSize = true;
            lbl7amount.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl7amount.Location = new Point(171, 500);
            lbl7amount.Margin = new Padding(4, 0, 4, 0);
            lbl7amount.Name = "lbl7amount";
            lbl7amount.Size = new Size(128, 40);
            lbl7amount.TabIndex = 6;
            lbl7amount.Text = "Php 0.00";
            // 
            // lbl6total
            // 
            lbl6total.AutoSize = true;
            lbl6total.Location = new Point(27, 513);
            lbl6total.Margin = new Padding(4, 0, 4, 0);
            lbl6total.Name = "lbl6total";
            lbl6total.Size = new Size(49, 25);
            lbl6total.TabIndex = 5;
            lbl6total.Text = "Total";
            // 
            // lbl5cost
            // 
            lbl5cost.AutoSize = true;
            lbl5cost.BackColor = SystemColors.ActiveCaptionText;
            lbl5cost.ForeColor = Color.White;
            lbl5cost.Location = new Point(240, 53);
            lbl5cost.Margin = new Padding(4, 0, 4, 0);
            lbl5cost.Name = "lbl5cost";
            lbl5cost.Size = new Size(56, 25);
            lbl5cost.TabIndex = 4;
            lbl5cost.Text = "COST";
            // 
            // lbl4quantity
            // 
            lbl4quantity.AutoSize = true;
            lbl4quantity.BackColor = SystemColors.ActiveCaptionText;
            lbl4quantity.ForeColor = Color.White;
            lbl4quantity.Location = new Point(141, 53);
            lbl4quantity.Margin = new Padding(4, 0, 4, 0);
            lbl4quantity.Name = "lbl4quantity";
            lbl4quantity.Size = new Size(44, 25);
            lbl4quantity.TabIndex = 3;
            lbl4quantity.Text = "QTY";
            // 
            // lbl3item
            // 
            lbl3item.AutoSize = true;
            lbl3item.BackColor = SystemColors.ActiveCaptionText;
            lbl3item.ForeColor = Color.White;
            lbl3item.Location = new Point(27, 53);
            lbl3item.Margin = new Padding(4, 0, 4, 0);
            lbl3item.Name = "lbl3item";
            lbl3item.Size = new Size(51, 25);
            lbl3item.TabIndex = 2;
            lbl3item.Text = "ITEM";
            // 
            // pb1order
            // 
            pb1order.BackColor = SystemColors.ActiveCaptionText;
            pb1order.Location = new Point(4, 37);
            pb1order.Margin = new Padding(4, 5, 4, 5);
            pb1order.Name = "pb1order";
            pb1order.Size = new Size(309, 60);
            pb1order.TabIndex = 1;
            pb1order.TabStop = false;
            // 
            // lbl2orderno
            // 
            lbl2orderno.AutoSize = true;
            lbl2orderno.Location = new Point(4, 7);
            lbl2orderno.Margin = new Padding(4, 0, 4, 0);
            lbl2orderno.Name = "lbl2orderno";
            lbl2orderno.Size = new Size(88, 25);
            lbl2orderno.TabIndex = 0;
            lbl2orderno.Text = "Order no.";
            // 
            // controlOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lbl1order);
            Margin = new Padding(4, 5, 4, 5);
            Name = "controlOrder";
            Size = new Size(1180, 970);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb1order).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1order;
        private Panel panel1;
        private Panel panel2;
        private Label lbl2orderno;
        private Button btn1pay;
        private Label lbl7amount;
        private Label lbl6total;
        private Label lbl5cost;
        private Label lbl4quantity;
        private Label lbl3item;
        private PictureBox pb1order;
        private Label label1;
        private DataGridView dataGridView1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private Label label3;
        private Label label2;
        private TextBox Tb3;
        private TextBox Tb2;
        private TextBox Tb1;
        private ComboBox comboBox1;
        private DataGridViewTextBoxColumn ColID;
        private DataGridViewTextBoxColumn ColName;
        private DataGridViewTextBoxColumn ColDate;
        private DataGridViewTextBoxColumn ColType;
        private DataGridViewTextBoxColumn ColItem;
    }
}

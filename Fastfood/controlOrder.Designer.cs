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
            label3 = new Label();
            label2 = new Label();
            Tb3 = new TextBox();
            Tb2 = new TextBox();
            Tb1 = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            dataGridView1 = new DataGridView();
            ColID = new DataGridViewTextBoxColumn();
            ColName = new DataGridViewTextBoxColumn();
            ColDate = new DataGridViewTextBoxColumn();
            ColType = new DataGridViewTextBoxColumn();
            ColItem = new DataGridViewTextBoxColumn();
            lbl2orderno = new Label();
            pb1order = new PictureBox();
            lbl3item = new Label();
            lbl4quantity = new Label();
            lbl5cost = new Label();
            lbl6total = new Label();
            lbl7amount = new Label();
            btn1pay = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb1order).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lbl1order
            // 
            lbl1order.AutoSize = true;
            lbl1order.BackColor = Color.Gainsboro;
            lbl1order.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1order.ForeColor = Color.Black;
            lbl1order.Location = new Point(0, 0);
            lbl1order.Name = "lbl1order";
            lbl1order.Size = new Size(66, 30);
            lbl1order.TabIndex = 2;
            lbl1order.Text = "Order";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Tb3);
            panel1.Controls.Add(Tb2);
            panel1.Controls.Add(Tb1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(826, 582);
            panel1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Product Type 1", "Product Type 2", "Product Type 3" });
            comboBox1.Location = new Point(91, 52);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(145, 23);
            comboBox1.TabIndex = 9;
            comboBox1.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SteelBlue;
            label3.ForeColor = Color.White;
            label3.Location = new Point(39, 136);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 5;
            label3.Text = "Item";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SteelBlue;
            label2.ForeColor = Color.White;
            label2.Location = new Point(39, 112);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // Tb3
            // 
            Tb3.Location = new Point(91, 136);
            Tb3.Margin = new Padding(2);
            Tb3.Name = "Tb3";
            Tb3.Size = new Size(145, 23);
            Tb3.TabIndex = 3;
            // 
            // Tb2
            // 
            Tb2.Location = new Point(91, 109);
            Tb2.Margin = new Padding(2);
            Tb2.Name = "Tb2";
            Tb2.Size = new Size(145, 23);
            Tb2.TabIndex = 2;
            // 
            // Tb1
            // 
            Tb1.Location = new Point(91, 81);
            Tb1.Margin = new Padding(2);
            Tb1.Name = "Tb1";
            Tb1.Size = new Size(145, 23);
            Tb1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.ForeColor = Color.White;
            label1.Location = new Point(39, 82);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Controls.Add(toolStrip1);
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(9, 41);
            panel3.Name = "panel3";
            panel3.Size = new Size(436, 424);
            panel3.TabIndex = 10;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(15, 139);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(220, 25);
            toolStrip1.TabIndex = 7;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(66, 22);
            toolStripButton1.Text = "Add Order";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(77, 22);
            toolStripButton2.Text = "Delete Order";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(65, 22);
            toolStripButton3.Text = "Sort Order";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColID, ColName, ColDate, ColType, ColItem });
            dataGridView1.Location = new Point(15, 161);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(397, 237);
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
            // lbl2orderno
            // 
            lbl2orderno.AutoSize = true;
            lbl2orderno.Location = new Point(29, 24);
            lbl2orderno.Name = "lbl2orderno";
            lbl2orderno.Size = new Size(57, 15);
            lbl2orderno.TabIndex = 0;
            lbl2orderno.Text = "Order no.";
            lbl2orderno.Click += lbl2orderno_Click;
            // 
            // pb1order
            // 
            pb1order.BackColor = Color.SteelBlue;
            pb1order.Location = new Point(29, 42);
            pb1order.Name = "pb1order";
            pb1order.Size = new Size(281, 36);
            pb1order.TabIndex = 1;
            pb1order.TabStop = false;
            // 
            // lbl3item
            // 
            lbl3item.AutoSize = true;
            lbl3item.BackColor = Color.SteelBlue;
            lbl3item.ForeColor = Color.White;
            lbl3item.Location = new Point(71, 54);
            lbl3item.Name = "lbl3item";
            lbl3item.Size = new Size(33, 15);
            lbl3item.TabIndex = 2;
            lbl3item.Text = "ITEM";
            // 
            // lbl4quantity
            // 
            lbl4quantity.AutoSize = true;
            lbl4quantity.BackColor = Color.SteelBlue;
            lbl4quantity.ForeColor = Color.White;
            lbl4quantity.Location = new Point(181, 54);
            lbl4quantity.Name = "lbl4quantity";
            lbl4quantity.Size = new Size(28, 15);
            lbl4quantity.TabIndex = 3;
            lbl4quantity.Text = "QTY";
            // 
            // lbl5cost
            // 
            lbl5cost.AutoSize = true;
            lbl5cost.BackColor = Color.SteelBlue;
            lbl5cost.ForeColor = Color.White;
            lbl5cost.Location = new Point(243, 54);
            lbl5cost.Name = "lbl5cost";
            lbl5cost.Size = new Size(36, 15);
            lbl5cost.TabIndex = 4;
            lbl5cost.Text = "COST";
            // 
            // lbl6total
            // 
            lbl6total.AutoSize = true;
            lbl6total.Location = new Point(80, 370);
            lbl6total.Name = "lbl6total";
            lbl6total.Size = new Size(32, 15);
            lbl6total.TabIndex = 5;
            lbl6total.Text = "Total";
            // 
            // lbl7amount
            // 
            lbl7amount.AutoSize = true;
            lbl7amount.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl7amount.Location = new Point(181, 362);
            lbl7amount.Name = "lbl7amount";
            lbl7amount.Size = new Size(84, 25);
            lbl7amount.TabIndex = 6;
            lbl7amount.Text = "Php 0.00";
            // 
            // btn1pay
            // 
            btn1pay.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn1pay.Location = new Point(80, 397);
            btn1pay.Name = "btn1pay";
            btn1pay.Size = new Size(185, 50);
            btn1pay.TabIndex = 7;
            btn1pay.Text = "PAY";
            btn1pay.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btn1pay);
            panel2.Controls.Add(lbl7amount);
            panel2.Controls.Add(lbl6total);
            panel2.Controls.Add(lbl5cost);
            panel2.Controls.Add(lbl4quantity);
            panel2.Controls.Add(lbl3item);
            panel2.Controls.Add(pb1order);
            panel2.Controls.Add(lbl2orderno);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(487, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(339, 582);
            panel2.TabIndex = 4;
            // 
            // controlOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbl1order);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "controlOrder";
            Size = new Size(826, 582);
            Load += controlOrder_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb1order).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1order;
        private Panel panel1;
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
        private Label lbl2orderno;
        private PictureBox pb1order;
        private Label lbl3item;
        private Label lbl4quantity;
        private Label lbl5cost;
        private Label lbl6total;
        private Label lbl7amount;
        private Button btn1pay;
        private Panel panel2;
        private Panel panel3;
    }
}

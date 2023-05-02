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
            this.lbl1order = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tb3 = new System.Windows.Forms.TextBox();
            this.Tb2 = new System.Windows.Forms.TextBox();
            this.Tb1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn1pay = new System.Windows.Forms.Button();
            this.lbl7amount = new System.Windows.Forms.Label();
            this.lbl6total = new System.Windows.Forms.Label();
            this.lbl5cost = new System.Windows.Forms.Label();
            this.lbl4quantity = new System.Windows.Forms.Label();
            this.lbl3item = new System.Windows.Forms.Label();
            this.pb1order = new System.Windows.Forms.PictureBox();
            this.lbl2orderno = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1order)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1order
            // 
            this.lbl1order.AutoSize = true;
            this.lbl1order.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl1order.Location = new System.Drawing.Point(0, 0);
            this.lbl1order.Name = "lbl1order";
            this.lbl1order.Size = new System.Drawing.Size(66, 30);
            this.lbl1order.TabIndex = 2;
            this.lbl1order.Text = "Order";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Tb3);
            this.panel1.Controls.Add(this.Tb2);
            this.panel1.Controls.Add(this.Tb1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 388);
            this.panel1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Product Type 1",
            "Product Type 2",
            "Product Type 3"});
            this.comboBox1.Location = new System.Drawing.Point(69, 11);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 23);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "Category";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColName,
            this.ColDate,
            this.ColType,
            this.ColItem});
            this.dataGridView1.Location = new System.Drawing.Point(2, 171);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(545, 217);
            this.dataGridView1.TabIndex = 8;
            // 
            // ColID
            // 
            this.ColID.HeaderText = "Product ID";
            this.ColID.MinimumWidth = 8;
            this.ColID.Name = "ColID";
            this.ColID.Width = 150;
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Customer Name";
            this.ColName.MinimumWidth = 8;
            this.ColName.Name = "ColName";
            this.ColName.Width = 150;
            // 
            // ColDate
            // 
            this.ColDate.HeaderText = "Date Ordered";
            this.ColDate.MinimumWidth = 8;
            this.ColDate.Name = "ColDate";
            this.ColDate.Width = 150;
            // 
            // ColType
            // 
            this.ColType.HeaderText = "Product Type";
            this.ColType.MinimumWidth = 8;
            this.ColType.Name = "ColType";
            this.ColType.Width = 150;
            // 
            // ColItem
            // 
            this.ColItem.HeaderText = "Item";
            this.ColItem.MinimumWidth = 8;
            this.ColItem.Name = "ColItem";
            this.ColItem.Width = 150;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(2, 149);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(220, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(66, 22);
            this.toolStripButton1.Text = "Add Order";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(77, 22);
            this.toolStripButton2.Text = "Delete Order";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(65, 22);
            this.toolStripButton3.Text = "Sort Order";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // Tb3
            // 
            this.Tb3.Location = new System.Drawing.Point(69, 95);
            this.Tb3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Tb3.Name = "Tb3";
            this.Tb3.Size = new System.Drawing.Size(145, 23);
            this.Tb3.TabIndex = 3;
            // 
            // Tb2
            // 
            this.Tb2.Location = new System.Drawing.Point(69, 68);
            this.Tb2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Tb2.Name = "Tb2";
            this.Tb2.Size = new System.Drawing.Size(145, 23);
            this.Tb2.TabIndex = 2;
            // 
            // Tb1
            // 
            this.Tb1.Location = new System.Drawing.Point(69, 40);
            this.Tb1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Tb1.Name = "Tb1";
            this.Tb1.Size = new System.Drawing.Size(145, 23);
            this.Tb1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.btn1pay);
            this.panel2.Controls.Add(this.lbl7amount);
            this.panel2.Controls.Add(this.lbl6total);
            this.panel2.Controls.Add(this.lbl5cost);
            this.panel2.Controls.Add(this.lbl4quantity);
            this.panel2.Controls.Add(this.lbl3item);
            this.panel2.Controls.Add(this.pb1order);
            this.panel2.Controls.Add(this.lbl2orderno);
            this.panel2.Location = new System.Drawing.Point(552, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 388);
            this.panel2.TabIndex = 4;
            // 
            // btn1pay
            // 
            this.btn1pay.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1pay.Location = new System.Drawing.Point(19, 335);
            this.btn1pay.Name = "btn1pay";
            this.btn1pay.Size = new System.Drawing.Size(185, 50);
            this.btn1pay.TabIndex = 7;
            this.btn1pay.Text = "PAY";
            this.btn1pay.UseVisualStyleBackColor = true;
            // 
            // lbl7amount
            // 
            this.lbl7amount.AutoSize = true;
            this.lbl7amount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl7amount.Location = new System.Drawing.Point(120, 300);
            this.lbl7amount.Name = "lbl7amount";
            this.lbl7amount.Size = new System.Drawing.Size(84, 25);
            this.lbl7amount.TabIndex = 6;
            this.lbl7amount.Text = "Php 0.00";
            // 
            // lbl6total
            // 
            this.lbl6total.AutoSize = true;
            this.lbl6total.Location = new System.Drawing.Point(19, 308);
            this.lbl6total.Name = "lbl6total";
            this.lbl6total.Size = new System.Drawing.Size(32, 15);
            this.lbl6total.TabIndex = 5;
            this.lbl6total.Text = "Total";
            // 
            // lbl5cost
            // 
            this.lbl5cost.AutoSize = true;
            this.lbl5cost.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl5cost.ForeColor = System.Drawing.Color.White;
            this.lbl5cost.Location = new System.Drawing.Point(168, 32);
            this.lbl5cost.Name = "lbl5cost";
            this.lbl5cost.Size = new System.Drawing.Size(36, 15);
            this.lbl5cost.TabIndex = 4;
            this.lbl5cost.Text = "COST";
            // 
            // lbl4quantity
            // 
            this.lbl4quantity.AutoSize = true;
            this.lbl4quantity.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl4quantity.ForeColor = System.Drawing.Color.White;
            this.lbl4quantity.Location = new System.Drawing.Point(99, 32);
            this.lbl4quantity.Name = "lbl4quantity";
            this.lbl4quantity.Size = new System.Drawing.Size(28, 15);
            this.lbl4quantity.TabIndex = 3;
            this.lbl4quantity.Text = "QTY";
            // 
            // lbl3item
            // 
            this.lbl3item.AutoSize = true;
            this.lbl3item.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl3item.ForeColor = System.Drawing.Color.White;
            this.lbl3item.Location = new System.Drawing.Point(19, 32);
            this.lbl3item.Name = "lbl3item";
            this.lbl3item.Size = new System.Drawing.Size(33, 15);
            this.lbl3item.TabIndex = 2;
            this.lbl3item.Text = "ITEM";
            // 
            // pb1order
            // 
            this.pb1order.BackColor = System.Drawing.Color.SteelBlue;
            this.pb1order.Location = new System.Drawing.Point(3, 22);
            this.pb1order.Name = "pb1order";
            this.pb1order.Size = new System.Drawing.Size(216, 36);
            this.pb1order.TabIndex = 1;
            this.pb1order.TabStop = false;
            // 
            // lbl2orderno
            // 
            this.lbl2orderno.AutoSize = true;
            this.lbl2orderno.Location = new System.Drawing.Point(3, 4);
            this.lbl2orderno.Name = "lbl2orderno";
            this.lbl2orderno.Size = new System.Drawing.Size(57, 15);
            this.lbl2orderno.TabIndex = 0;
            this.lbl2orderno.Text = "Order no.";
            // 
            // controlOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl1order);
            this.Name = "controlOrder";
            this.Size = new System.Drawing.Size(826, 582);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1order)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

namespace Fastfood
{
    partial class Transactions
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 128);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(341, 480);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(596, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(284, 30);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(214, 7);
            button2.Name = "button2";
            button2.Size = new Size(66, 23);
            button2.TabIndex = 2;
            button2.Text = "REFRESH";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(133, 7);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "SEARCH";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 7);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Location = new Point(424, 128);
            panel1.Name = "panel1";
            panel1.Size = new Size(537, 235);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(602, 75);
            label1.Name = "label1";
            label1.Size = new Size(119, 21);
            label1.TabIndex = 6;
            label1.Text = "PRODUCT LIST";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(34, 97);
            label2.Name = "label2";
            label2.Size = new Size(136, 21);
            label2.TabIndex = 7;
            label2.Text = "ORDER HISTORY";
            label2.Click += label2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(176, 97);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "SEARCH";
            button3.UseVisualStyleBackColor = true;
            // 
            // controlRecords
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "controlRecords";
            Size = new Size(1064, 654);
            Load += controlRecords_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
        private ComboBox comboBox1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button button3;
    }
}

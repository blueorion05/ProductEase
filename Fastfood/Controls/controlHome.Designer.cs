namespace Fastfood
{
    partial class controlHome
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
            pbOrders = new PictureBox();
            lblOrders = new Label();
            pbSales = new PictureBox();
            lblSales = new Label();
            lblOrdersnum = new Label();
            lblSalesnum = new Label();
            panelDashboard = new Panel();
            lblWelcome = new Label();
            ((System.ComponentModel.ISupportInitialize)pbOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSales).BeginInit();
            panelDashboard.SuspendLayout();
            SuspendLayout();
            // 
            // pbOrders
            // 
            pbOrders.BackColor = Color.FromArgb(0, 150, 136);
            pbOrders.Location = new Point(58, 104);
            pbOrders.Name = "pbOrders";
            pbOrders.Size = new Size(164, 91);
            pbOrders.TabIndex = 1;
            pbOrders.TabStop = false;
            pbOrders.Click += pb1totalorders_Click;
            // 
            // lblOrders
            // 
            lblOrders.AutoSize = true;
            lblOrders.BackColor = Color.FromArgb(0, 150, 136);
            lblOrders.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblOrders.ForeColor = Color.White;
            lblOrders.Location = new Point(64, 114);
            lblOrders.Name = "lblOrders";
            lblOrders.Size = new Size(119, 22);
            lblOrders.TabIndex = 2;
            lblOrders.Text = "Total Orders";
            // 
            // pbSales
            // 
            pbSales.BackColor = Color.FromArgb(0, 150, 136);
            pbSales.Location = new Point(58, 285);
            pbSales.Name = "pbSales";
            pbSales.Size = new Size(164, 91);
            pbSales.TabIndex = 3;
            pbSales.TabStop = false;
            // 
            // lblSales
            // 
            lblSales.AutoSize = true;
            lblSales.BackColor = Color.FromArgb(0, 150, 136);
            lblSales.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSales.ForeColor = Color.White;
            lblSales.Location = new Point(64, 295);
            lblSales.Name = "lblSales";
            lblSales.Size = new Size(102, 22);
            lblSales.TabIndex = 4;
            lblSales.Text = "Total Sales";
            // 
            // lblOrdersnum
            // 
            lblOrdersnum.AutoSize = true;
            lblOrdersnum.BackColor = Color.FromArgb(0, 150, 136);
            lblOrdersnum.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblOrdersnum.ForeColor = Color.White;
            lblOrdersnum.Location = new Point(127, 145);
            lblOrdersnum.Name = "lblOrdersnum";
            lblOrdersnum.Size = new Size(30, 33);
            lblOrdersnum.TabIndex = 5;
            lblOrdersnum.Text = "0";
            // 
            // lblSalesnum
            // 
            lblSalesnum.AutoSize = true;
            lblSalesnum.BackColor = Color.FromArgb(0, 150, 136);
            lblSalesnum.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSalesnum.ForeColor = Color.White;
            lblSalesnum.Location = new Point(127, 328);
            lblSalesnum.Name = "lblSalesnum";
            lblSalesnum.Size = new Size(30, 33);
            lblSalesnum.TabIndex = 6;
            lblSalesnum.Text = "0";
            // 
            // panelDashboard
            // 
            panelDashboard.BackColor = Color.WhiteSmoke;
            panelDashboard.Controls.Add(lblSalesnum);
            panelDashboard.Controls.Add(lblSales);
            panelDashboard.Controls.Add(lblOrdersnum);
            panelDashboard.Controls.Add(lblOrders);
            panelDashboard.Controls.Add(pbOrders);
            panelDashboard.Controls.Add(pbSales);
            panelDashboard.Dock = DockStyle.Right;
            panelDashboard.Location = new Point(784, 0);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(280, 654);
            panelDashboard.TabIndex = 7;
            panelDashboard.Paint += panel1_Paint;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Century Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblWelcome.ForeColor = Color.Black;
            lblWelcome.Location = new Point(20, 16);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(180, 42);
            lblWelcome.TabIndex = 8;
            lblWelcome.Text = "Welcome";
            // 
            // controlHome
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.WhiteSmoke;
            Controls.Add(lblWelcome);
            Controls.Add(panelDashboard);
            Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "controlHome";
            Size = new Size(1064, 654);
            Load += controlHome_Load_1;
            ((System.ComponentModel.ISupportInitialize)pbOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSales).EndInit();
            panelDashboard.ResumeLayout(false);
            panelDashboard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pbOrders;
        private Label lblOrders;
        private PictureBox pbSales;
        private Label lblSales;
        private Label lblOrdersnum;
        private Label lblSalesnum;
        private Panel panelDashboard;
        private Label lblWelcome;
    }
}

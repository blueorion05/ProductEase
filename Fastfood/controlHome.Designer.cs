﻿namespace Fastfood
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
            lbl1home = new Label();
            pb1totalorders = new PictureBox();
            lbl2totalorders = new Label();
            pictureBox1 = new PictureBox();
            lbl3totalsales = new Label();
            ((System.ComponentModel.ISupportInitialize)pb1totalorders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl1home
            // 
            lbl1home.AutoSize = true;
            lbl1home.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1home.Location = new Point(3, 0);
            lbl1home.Name = "lbl1home";
            lbl1home.Size = new Size(69, 30);
            lbl1home.TabIndex = 0;
            lbl1home.Text = "Home";
            // 
            // pb1totalorders
            // 
            pb1totalorders.BackColor = Color.SteelBlue;
            pb1totalorders.Location = new Point(510, 79);
            pb1totalorders.Name = "pb1totalorders";
            pb1totalorders.Size = new Size(164, 91);
            pb1totalorders.TabIndex = 1;
            pb1totalorders.TabStop = false;
            // 
            // lbl2totalorders
            // 
            lbl2totalorders.AutoSize = true;
            lbl2totalorders.BackColor = Color.SteelBlue;
            lbl2totalorders.ForeColor = Color.White;
            lbl2totalorders.Location = new Point(521, 101);
            lbl2totalorders.Name = "lbl2totalorders";
            lbl2totalorders.Size = new Size(70, 15);
            lbl2totalorders.TabIndex = 2;
            lbl2totalorders.Text = "Total Orders";
            lbl2totalorders.Click += lbl2totalorders_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SteelBlue;
            pictureBox1.Location = new Point(510, 260);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 91);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lbl3totalsales
            // 
            lbl3totalsales.AutoSize = true;
            lbl3totalsales.BackColor = Color.SteelBlue;
            lbl3totalsales.ForeColor = Color.White;
            lbl3totalsales.Location = new Point(530, 285);
            lbl3totalsales.Name = "lbl3totalsales";
            lbl3totalsales.Size = new Size(61, 15);
            lbl3totalsales.TabIndex = 4;
            lbl3totalsales.Text = "Total Sales";
            lbl3totalsales.Click += lbl3totalsales_Click;
            // 
            // controlHome
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(lbl3totalsales);
            Controls.Add(pictureBox1);
            Controls.Add(lbl2totalorders);
            Controls.Add(pb1totalorders);
            Controls.Add(lbl1home);
            Name = "controlHome";
            Size = new Size(824, 586);
            Load += controlHome_Load;
            ((System.ComponentModel.ISupportInitialize)pb1totalorders).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1home;
        private PictureBox pb1totalorders;
        private Label lbl2totalorders;
        private PictureBox pictureBox1;
        private Label lbl3totalsales;
    }
}

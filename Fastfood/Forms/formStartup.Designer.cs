namespace Fastfood
{
    partial class formStartup
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formStartup));
            lblTitle = new Label();
            timerLoad = new System.Windows.Forms.Timer(components);
            progressBar1 = new ProgressBar();
            lblSubtitle = new Label();
            pbLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(163, 96);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(124, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ProductEase";
            // 
            // timerLoad
            // 
            timerLoad.Tick += timer1_Tick;
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.FromArgb(51, 51, 76);
            progressBar1.Location = new Point(-1, 203);
            progressBar1.Margin = new Padding(2);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(435, 7);
            progressBar1.TabIndex = 1;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubtitle.ForeColor = Color.White;
            lblSubtitle.Location = new Point(163, 119);
            lblSubtitle.Margin = new Padding(2, 0, 2, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(76, 17);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Version 1.0";
            // 
            // pbLogo
            // 
            pbLogo.BackColor = Color.FromArgb(31, 30, 68);
            pbLogo.BackgroundImage = (Image)resources.GetObject("pbLogo.BackgroundImage");
            pbLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pbLogo.Location = new Point(60, 64);
            pbLogo.Margin = new Padding(2);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(99, 77);
            pbLogo.TabIndex = 3;
            pbLogo.TabStop = false;
            // 
            // formStartup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 26, 62);
            ClientSize = new Size(430, 210);
            Controls.Add(pbLogo);
            Controls.Add(lblSubtitle);
            Controls.Add(progressBar1);
            Controls.Add(lblTitle);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "formStartup";
            StartPosition = FormStartPosition.CenterScreen;
            Load += StartUp_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private System.Windows.Forms.Timer timerLoad;
        private ProgressBar progressBar1;
        private Label lblSubtitle;
        private PictureBox pbLogo;
    }
}
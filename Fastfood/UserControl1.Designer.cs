namespace Fastfood
{
    partial class UserControl1
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
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbl1home);
            Name = "UserControl1";
            Size = new Size(735, 424);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1home;
    }
}

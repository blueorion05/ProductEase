namespace Fastfood
{
    partial class controlAccount
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
            lbl1account = new Label();
            SuspendLayout();
            // 
            // lbl1account
            // 
            lbl1account.AutoSize = true;
            lbl1account.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1account.Location = new Point(0, 0);
            lbl1account.Name = "lbl1account";
            lbl1account.Size = new Size(90, 30);
            lbl1account.TabIndex = 4;
            lbl1account.Text = "Account";
            // 
            // controlAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbl1account);
            Name = "controlAccount";
            Size = new Size(1064, 654);
            Load += controlAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1account;
    }
}

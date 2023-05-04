namespace Fastfood
{
    partial class controlRecords
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
            lbl1records = new Label();
            SuspendLayout();
            // 
            // lbl1records
            // 
            lbl1records.AutoSize = true;
            lbl1records.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1records.Location = new Point(0, 0);
            lbl1records.Name = "lbl1records";
            lbl1records.Size = new Size(86, 30);
            lbl1records.TabIndex = 3;
            lbl1records.Text = "Records";
            // 
            // controlRecords
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbl1records);
            Name = "controlRecords";
            Size = new Size(1064, 654);
            Load += controlRecords_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1records;
    }
}

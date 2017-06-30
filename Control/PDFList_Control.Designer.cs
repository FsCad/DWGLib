namespace DWGLib.Controls
{
    partial class PDFList_Control
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
            this.Label = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label.AutoSize = true;
            this.Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label.Location = new System.Drawing.Point(3, 6);
            this.Label.Margin = new System.Windows.Forms.Padding(5);
            this.Label.Name = "Label";
            this.Label.Padding = new System.Windows.Forms.Padding(4);
            this.Label.Size = new System.Drawing.Size(56, 24);
            this.Label.TabIndex = 1;
            this.Label.TabStop = true;
            this.Label.Text = "Label";
            this.Label.Click += new System.EventHandler(this.Open_PDFFile);
            // 
            // PDFList_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.Label);
            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.MaximumSize = new System.Drawing.Size(294, 40);
            this.MinimumSize = new System.Drawing.Size(294, 40);
            this.Name = "PDFList_Control";
            this.Size = new System.Drawing.Size(294, 40);
            this.Click += new System.EventHandler(this.Open_PDFFile);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.LinkLabel Label;
    }
}

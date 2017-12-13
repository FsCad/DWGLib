namespace DWGLib.Dialog
{
    partial class PathSelect
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
            this.Path = new System.Windows.Forms.TextBox();
            this.Select = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Path
            // 
            this.Path.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Path.Location = new System.Drawing.Point(2, 8);
            this.Path.Margin = new System.Windows.Forms.Padding(6);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(284, 14);
            this.Path.TabIndex = 0;
            // 
            // Select
            // 
            this.Select.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Select.Location = new System.Drawing.Point(322, 29);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(75, 33);
            this.Select.TabIndex = 1;
            this.Select.TabStop = false;
            this.Select.Text = "选择";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Path);
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 33);
            this.panel1.TabIndex = 2;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(322, 88);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 33);
            this.OK.TabIndex = 3;
            this.OK.Text = "确定";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // PathSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 133);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Select);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(440, 172);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(440, 172);
            this.Name = "PathSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "路径选择";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox Path;
        public new System.Windows.Forms.Button Select;
        public System.Windows.Forms.Button OK;
    }
}
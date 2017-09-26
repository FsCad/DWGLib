namespace DWGLib.Dialog
{
    partial class Setting
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Set = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.AboutBtn = new System.Windows.Forms.Button();
            this.OpenPDFFolder = new System.Windows.Forms.Button();
            this.LibOpenBtn = new System.Windows.Forms.Button();
            this.Set.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(18, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "配置路径|SETTING";
            // 
            // Set
            // 
            this.Set.Controls.Add(this.OpenPDFFolder);
            this.Set.Controls.Add(this.label2);
            this.Set.Controls.Add(this.LibOpenBtn);
            this.Set.Controls.Add(this.label1);
            this.Set.Dock = System.Windows.Forms.DockStyle.Top;
            this.Set.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Set.Location = new System.Drawing.Point(15, 15);
            this.Set.Margin = new System.Windows.Forms.Padding(15, 15, 15, 20);
            this.Set.Name = "Set";
            this.Set.Padding = new System.Windows.Forms.Padding(15);
            this.Set.Size = new System.Drawing.Size(264, 172);
            this.Set.TabIndex = 3;
            this.Set.TabStop = false;
            this.Set.Text = "设置";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(18, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 2);
            this.label2.TabIndex = 8;
            // 
            // AboutBtn
            // 
            this.AboutBtn.Location = new System.Drawing.Point(33, 199);
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Size = new System.Drawing.Size(89, 32);
            this.AboutBtn.TabIndex = 9;
            this.AboutBtn.Text = "关于";
            this.AboutBtn.UseVisualStyleBackColor = true;
            this.AboutBtn.Click += new System.EventHandler(this.AboutBtn_Click);
            // 
            // OpenPDFFolder
            // 
            this.OpenPDFFolder.Location = new System.Drawing.Point(161, 108);
            this.OpenPDFFolder.Name = "OpenPDFFolder";
            this.OpenPDFFolder.Padding = new System.Windows.Forms.Padding(3);
            this.OpenPDFFolder.Size = new System.Drawing.Size(83, 32);
            this.OpenPDFFolder.TabIndex = 10;
            this.OpenPDFFolder.Text = "文档文件夹";
            this.OpenPDFFolder.UseVisualStyleBackColor = true;
            this.OpenPDFFolder.Click += new System.EventHandler(this.OpenPDFFolder_Click);
            // 
            // LibOpenBtn
            // 
            this.LibOpenBtn.Location = new System.Drawing.Point(18, 108);
            this.LibOpenBtn.Name = "LibOpenBtn";
            this.LibOpenBtn.Padding = new System.Windows.Forms.Padding(3);
            this.LibOpenBtn.Size = new System.Drawing.Size(89, 32);
            this.LibOpenBtn.TabIndex = 9;
            this.LibOpenBtn.Text = "图库文件夹";
            this.LibOpenBtn.UseVisualStyleBackColor = true;
            this.LibOpenBtn.Click += new System.EventHandler(this.LibOpenBtn_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AboutBtn);
            this.Controls.Add(this.Set);
            this.Name = "Setting";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Size = new System.Drawing.Size(294, 525);
            this.Set.ResumeLayout(false);
            this.Set.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Set;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button AboutBtn;
        private System.Windows.Forms.Button OpenPDFFolder;
        private System.Windows.Forms.Button LibOpenBtn;
    }
}

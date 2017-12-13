namespace DWGLib.Dialog
{
    partial class PreProcessDwg
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
            this.ProcessProgress = new System.Windows.Forms.ProgressBar();
            this.SelectFolder = new System.Windows.Forms.Button();
            this.StartProcess = new System.Windows.Forms.Button();
            this.BlackColor = new System.Windows.Forms.Panel();
            this.WhiteColor = new System.Windows.Forms.Panel();
            this.ProcessFolder = new System.Windows.Forms.Label();
            this.CurrentProcessFile = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Percent = new System.Windows.Forms.Label();
            this.PreProcessWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // ProcessProgress
            // 
            this.ProcessProgress.Location = new System.Drawing.Point(12, 121);
            this.ProcessProgress.Name = "ProcessProgress";
            this.ProcessProgress.Size = new System.Drawing.Size(494, 23);
            this.ProcessProgress.TabIndex = 0;
            // 
            // SelectFolder
            // 
            this.SelectFolder.Location = new System.Drawing.Point(13, 40);
            this.SelectFolder.Name = "SelectFolder";
            this.SelectFolder.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SelectFolder.Size = new System.Drawing.Size(100, 32);
            this.SelectFolder.TabIndex = 1;
            this.SelectFolder.Text = "选择文件夹";
            this.SelectFolder.UseVisualStyleBackColor = true;
            // 
            // StartProcess
            // 
            this.StartProcess.Location = new System.Drawing.Point(138, 40);
            this.StartProcess.Name = "StartProcess";
            this.StartProcess.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.StartProcess.Size = new System.Drawing.Size(100, 32);
            this.StartProcess.TabIndex = 2;
            this.StartProcess.Text = "开始处理";
            this.StartProcess.UseVisualStyleBackColor = true;
            // 
            // BlackColor
            // 
            this.BlackColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BlackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BlackColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BlackColor.Location = new System.Drawing.Point(362, 40);
            this.BlackColor.Name = "BlackColor";
            this.BlackColor.Size = new System.Drawing.Size(37, 32);
            this.BlackColor.TabIndex = 4;
            // 
            // WhiteColor
            // 
            this.WhiteColor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WhiteColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WhiteColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WhiteColor.Location = new System.Drawing.Point(289, 40);
            this.WhiteColor.Name = "WhiteColor";
            this.WhiteColor.Size = new System.Drawing.Size(37, 32);
            this.WhiteColor.TabIndex = 6;
            // 
            // ProcessFolder
            // 
            this.ProcessFolder.AutoSize = true;
            this.ProcessFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProcessFolder.Location = new System.Drawing.Point(12, 90);
            this.ProcessFolder.Name = "ProcessFolder";
            this.ProcessFolder.Size = new System.Drawing.Size(149, 12);
            this.ProcessFolder.TabIndex = 7;
            this.ProcessFolder.Text = "这里显显示所选择的文件夹";
            // 
            // CurrentProcessFile
            // 
            this.CurrentProcessFile.AutoSize = true;
            this.CurrentProcessFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CurrentProcessFile.Location = new System.Drawing.Point(12, 164);
            this.CurrentProcessFile.Name = "CurrentProcessFile";
            this.CurrentProcessFile.Size = new System.Drawing.Size(125, 12);
            this.CurrentProcessFile.TabIndex = 8;
            this.CurrentProcessFile.Text = "这里显示当前处理文件";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(495, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "%";
            // 
            // Percent
            // 
            this.Percent.AutoSize = true;
            this.Percent.Location = new System.Drawing.Point(475, 91);
            this.Percent.Name = "Percent";
            this.Percent.Size = new System.Drawing.Size(17, 12);
            this.Percent.TabIndex = 10;
            this.Percent.Text = "__";
            // 
            // PreProcessDwg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 229);
            this.Controls.Add(this.Percent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CurrentProcessFile);
            this.Controls.Add(this.ProcessFolder);
            this.Controls.Add(this.BlackColor);
            this.Controls.Add(this.WhiteColor);
            this.Controls.Add(this.StartProcess);
            this.Controls.Add(this.SelectFolder);
            this.Controls.Add(this.ProcessProgress);
            this.Icon = global::DWGLib.Properties.Resources.logo;
            this.Name = "PreProcessDwg";
            this.Text = "缩略图获取预处理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar ProcessProgress;
        private System.Windows.Forms.Button SelectFolder;
        private System.Windows.Forms.Button StartProcess;
        private System.Windows.Forms.Panel BlackColor;
        private System.Windows.Forms.Panel WhiteColor;
        private System.Windows.Forms.Label ProcessFolder;
        private System.Windows.Forms.Label CurrentProcessFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Percent;
        private System.ComponentModel.BackgroundWorker PreProcessWorker;
    }
}
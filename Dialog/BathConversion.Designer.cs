namespace DWGLib.Dialog
{
    partial class BathConversion
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
            this.FolderBrowser = new System.Windows.Forms.Button();
            this.StartConvert = new System.Windows.Forms.Button();
            this.VersionGroup = new System.Windows.Forms.GroupBox();
            this.ProcessGroup = new System.Windows.Forms.GroupBox();
            this.CurrentFile = new System.Windows.Forms.Label();
            this.RootPath = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ProcessGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // FolderBrowser
            // 
            this.FolderBrowser.Location = new System.Drawing.Point(15, 27);
            this.FolderBrowser.Name = "FolderBrowser";
            this.FolderBrowser.Size = new System.Drawing.Size(75, 32);
            this.FolderBrowser.TabIndex = 0;
            this.FolderBrowser.Text = "选择文件夹";
            this.FolderBrowser.UseVisualStyleBackColor = true;
            this.FolderBrowser.Click += new System.EventHandler(this.BrowserFileFolder);
            // 
            // StartConvert
            // 
            this.StartConvert.Location = new System.Drawing.Point(120, 27);
            this.StartConvert.Name = "StartConvert";
            this.StartConvert.Size = new System.Drawing.Size(75, 32);
            this.StartConvert.TabIndex = 1;
            this.StartConvert.Text = "开始转换";
            this.StartConvert.UseVisualStyleBackColor = true;
            this.StartConvert.Click += new System.EventHandler(this.Start_Convert);
            // 
            // VersionGroup
            // 
            this.VersionGroup.Location = new System.Drawing.Point(15, 77);
            this.VersionGroup.Name = "VersionGroup";
            this.VersionGroup.Padding = new System.Windows.Forms.Padding(10);
            this.VersionGroup.Size = new System.Drawing.Size(118, 201);
            this.VersionGroup.TabIndex = 3;
            this.VersionGroup.TabStop = false;
            this.VersionGroup.Text = "选择版本";
            // 
            // ProcessGroup
            // 
            this.ProcessGroup.Controls.Add(this.CurrentFile);
            this.ProcessGroup.Controls.Add(this.RootPath);
            this.ProcessGroup.Controls.Add(this.progressBar);
            this.ProcessGroup.Location = new System.Drawing.Point(140, 77);
            this.ProcessGroup.Name = "ProcessGroup";
            this.ProcessGroup.Size = new System.Drawing.Size(401, 201);
            this.ProcessGroup.TabIndex = 4;
            this.ProcessGroup.TabStop = false;
            this.ProcessGroup.Text = "处理状态";
            // 
            // CurrentFile
            // 
            this.CurrentFile.AutoSize = true;
            this.CurrentFile.Location = new System.Drawing.Point(6, 151);
            this.CurrentFile.Name = "CurrentFile";
            this.CurrentFile.Size = new System.Drawing.Size(53, 12);
            this.CurrentFile.TabIndex = 2;
            this.CurrentFile.Text = "当前文件";
            // 
            // RootPath
            // 
            this.RootPath.AutoSize = true;
            this.RootPath.Location = new System.Drawing.Point(14, 61);
            this.RootPath.Name = "RootPath";
            this.RootPath.Size = new System.Drawing.Size(41, 12);
            this.RootPath.TabIndex = 1;
            this.RootPath.Text = "根目录";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(6, 101);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(388, 27);
            this.progressBar.TabIndex = 0;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ConvertFile_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.ConvertFileChange);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.CompleteConvert);
            // 
            // BathConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 290);
            this.Controls.Add(this.ProcessGroup);
            this.Controls.Add(this.VersionGroup);
            this.Controls.Add(this.StartConvert);
            this.Controls.Add(this.FolderBrowser);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BathConversion";
            this.Text = "批量转换";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BathConversion_FormClosing);
            this.Load += new System.EventHandler(this.BathConversion_Load);
            this.ProcessGroup.ResumeLayout(false);
            this.ProcessGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FolderBrowser;
        private System.Windows.Forms.Button StartConvert;
        private System.Windows.Forms.GroupBox VersionGroup;
        private System.Windows.Forms.GroupBox ProcessGroup;
        private System.Windows.Forms.Label CurrentFile;
        private System.Windows.Forms.Label RootPath;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}
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
            this.SettingContainer = new System.Windows.Forms.GroupBox();
            this.StdBlockLibOpenBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PluginsBtn = new System.Windows.Forms.Button();
            this.PrintStyleBtn = new System.Windows.Forms.Button();
            this.FontFolderBtn = new System.Windows.Forms.Button();
            this.OpenPDFFolderBtn = new System.Windows.Forms.Button();
            this.StdSysLibOpenBtn = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.AboutBtn = new System.Windows.Forms.Button();
            this.SettingContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingContainer
            // 
            this.SettingContainer.Controls.Add(this.StdBlockLibOpenBtn);
            this.SettingContainer.Controls.Add(this.label2);
            this.SettingContainer.Controls.Add(this.label1);
            this.SettingContainer.Controls.Add(this.PluginsBtn);
            this.SettingContainer.Controls.Add(this.PrintStyleBtn);
            this.SettingContainer.Controls.Add(this.FontFolderBtn);
            this.SettingContainer.Controls.Add(this.OpenPDFFolderBtn);
            this.SettingContainer.Controls.Add(this.StdSysLibOpenBtn);
            this.SettingContainer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SettingContainer.Location = new System.Drawing.Point(14, 30);
            this.SettingContainer.Margin = new System.Windows.Forms.Padding(15, 15, 15, 20);
            this.SettingContainer.Name = "SettingContainer";
            this.SettingContainer.Padding = new System.Windows.Forms.Padding(15);
            this.SettingContainer.Size = new System.Drawing.Size(264, 264);
            this.SettingContainer.TabIndex = 3;
            this.SettingContainer.TabStop = false;
            this.SettingContainer.Text = "设置";
            // 
            // StdBlockLibOpenBtn
            // 
            this.StdBlockLibOpenBtn.Location = new System.Drawing.Point(144, 97);
            this.StdBlockLibOpenBtn.Name = "StdBlockLibOpenBtn";
            this.StdBlockLibOpenBtn.Padding = new System.Windows.Forms.Padding(3);
            this.StdBlockLibOpenBtn.Size = new System.Drawing.Size(89, 32);
            this.StdBlockLibOpenBtn.TabIndex = 16;
            this.StdBlockLibOpenBtn.Text = "图块管理";
            this.StdBlockLibOpenBtn.UseVisualStyleBackColor = true;
            this.StdBlockLibOpenBtn.Click += new System.EventHandler(this.StdBlockLibOpenBtn_Click);
            this.StdBlockLibOpenBtn.MouseHover += new System.EventHandler(this.StdBlockLibOpenBtn_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(20, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "鼠标悬停在按钮上以查看帮助";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "点击下列按钮可以打开相应的文件夹";
            // 
            // PluginsBtn
            // 
            this.PluginsBtn.Location = new System.Drawing.Point(24, 201);
            this.PluginsBtn.Name = "PluginsBtn";
            this.PluginsBtn.Padding = new System.Windows.Forms.Padding(3);
            this.PluginsBtn.Size = new System.Drawing.Size(89, 32);
            this.PluginsBtn.TabIndex = 13;
            this.PluginsBtn.Text = "插件管理";
            this.PluginsBtn.UseVisualStyleBackColor = true;
            this.PluginsBtn.Click += new System.EventHandler(this.PluginsBtn_Click);
            this.PluginsBtn.MouseHover += new System.EventHandler(this.PluginsBtn_MouseHover);
            // 
            // PrintStyleBtn
            // 
            this.PrintStyleBtn.Location = new System.Drawing.Point(144, 201);
            this.PrintStyleBtn.Name = "PrintStyleBtn";
            this.PrintStyleBtn.Padding = new System.Windows.Forms.Padding(3);
            this.PrintStyleBtn.Size = new System.Drawing.Size(89, 32);
            this.PrintStyleBtn.TabIndex = 12;
            this.PrintStyleBtn.Text = "打印样式";
            this.PrintStyleBtn.UseVisualStyleBackColor = true;
            this.PrintStyleBtn.Click += new System.EventHandler(this.PrintStyleBtn_Click);
            this.PrintStyleBtn.MouseHover += new System.EventHandler(this.PrintStyleBtn_MouseHover);
            // 
            // FontFolderBtn
            // 
            this.FontFolderBtn.Location = new System.Drawing.Point(24, 149);
            this.FontFolderBtn.Name = "FontFolderBtn";
            this.FontFolderBtn.Padding = new System.Windows.Forms.Padding(3);
            this.FontFolderBtn.Size = new System.Drawing.Size(89, 32);
            this.FontFolderBtn.TabIndex = 11;
            this.FontFolderBtn.Text = "字体管理";
            this.FontFolderBtn.UseVisualStyleBackColor = true;
            this.FontFolderBtn.Click += new System.EventHandler(this.FontFolderBtn_Click);
            this.FontFolderBtn.MouseHover += new System.EventHandler(this.FontFolderBtn_MouseHover);
            // 
            // OpenPDFFolderBtn
            // 
            this.OpenPDFFolderBtn.Location = new System.Drawing.Point(144, 149);
            this.OpenPDFFolderBtn.Name = "OpenPDFFolderBtn";
            this.OpenPDFFolderBtn.Padding = new System.Windows.Forms.Padding(3);
            this.OpenPDFFolderBtn.Size = new System.Drawing.Size(89, 32);
            this.OpenPDFFolderBtn.TabIndex = 10;
            this.OpenPDFFolderBtn.Text = "文档管理";
            this.OpenPDFFolderBtn.UseVisualStyleBackColor = true;
            this.OpenPDFFolderBtn.Click += new System.EventHandler(this.OpenPDFFolder_Click);
            this.OpenPDFFolderBtn.MouseHover += new System.EventHandler(this.OpenPDFFolderBtn_MouseHover);
            // 
            // StdSysLibOpenBtn
            // 
            this.StdSysLibOpenBtn.Location = new System.Drawing.Point(24, 97);
            this.StdSysLibOpenBtn.Name = "StdSysLibOpenBtn";
            this.StdSysLibOpenBtn.Padding = new System.Windows.Forms.Padding(3);
            this.StdSysLibOpenBtn.Size = new System.Drawing.Size(89, 32);
            this.StdSysLibOpenBtn.TabIndex = 9;
            this.StdSysLibOpenBtn.Text = "标准系统";
            this.StdSysLibOpenBtn.UseVisualStyleBackColor = true;
            this.StdSysLibOpenBtn.Click += new System.EventHandler(this.StdSysLibOpenBtn_Click);
            this.StdSysLibOpenBtn.MouseHover += new System.EventHandler(this.StdSysLibOpenBtn_MouseHover);
            // 
            // AboutBtn
            // 
            this.AboutBtn.Location = new System.Drawing.Point(38, 317);
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Size = new System.Drawing.Size(89, 32);
            this.AboutBtn.TabIndex = 9;
            this.AboutBtn.Text = "关于";
            this.AboutBtn.UseVisualStyleBackColor = true;
            this.AboutBtn.Click += new System.EventHandler(this.AboutBtn_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AboutBtn);
            this.Controls.Add(this.SettingContainer);
            this.Name = "Setting";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Size = new System.Drawing.Size(294, 525);
            this.SettingContainer.ResumeLayout(false);
            this.SettingContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button AboutBtn;
        private System.Windows.Forms.Button OpenPDFFolderBtn;
        private System.Windows.Forms.Button StdSysLibOpenBtn;
        private System.Windows.Forms.Button PrintStyleBtn;
        private System.Windows.Forms.Button FontFolderBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PluginsBtn;
        public System.Windows.Forms.GroupBox SettingContainer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StdBlockLibOpenBtn;
    }
}

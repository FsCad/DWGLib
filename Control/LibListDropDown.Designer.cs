namespace DWGLib.Controls
{
    partial class LibListDropDown
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Filter = new System.Windows.Forms.GroupBox();
            this.SubFolderFilter = new System.Windows.Forms.ComboBox();
            this.FolderFilter = new System.Windows.Forms.ComboBox();
            this.ItemLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Statusbar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.Filter.SuspendLayout();
            this.Statusbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Filter, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ItemLayoutPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Statusbar, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(339, 585);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // Filter
            // 
            this.Filter.Controls.Add(this.SubFolderFilter);
            this.Filter.Controls.Add(this.FolderFilter);
            this.Filter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Filter.Location = new System.Drawing.Point(13, 13);
            this.Filter.Name = "Filter";
            this.Filter.Padding = new System.Windows.Forms.Padding(10);
            this.Filter.Size = new System.Drawing.Size(313, 94);
            this.Filter.TabIndex = 0;
            this.Filter.TabStop = false;
            this.Filter.Text = "过滤";
            // 
            // SubFolderFilter
            // 
            this.SubFolderFilter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SubFolderFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubFolderFilter.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SubFolderFilter.FormattingEnabled = true;
            this.SubFolderFilter.Location = new System.Drawing.Point(10, 60);
            this.SubFolderFilter.Name = "SubFolderFilter";
            this.SubFolderFilter.Size = new System.Drawing.Size(293, 24);
            this.SubFolderFilter.TabIndex = 1;
            this.SubFolderFilter.SelectedValueChanged += new System.EventHandler(this.SubFolderChanged);
            // 
            // FolderFilter
            // 
            this.FolderFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.FolderFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FolderFilter.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FolderFilter.FormattingEnabled = true;
            this.FolderFilter.Location = new System.Drawing.Point(10, 24);
            this.FolderFilter.Name = "FolderFilter";
            this.FolderFilter.Size = new System.Drawing.Size(293, 24);
            this.FolderFilter.TabIndex = 0;
            this.FolderFilter.SelectedValueChanged += new System.EventHandler(this.RootPathChanged);
            // 
            // ItemLayoutPanel
            // 
            this.ItemLayoutPanel.AllowDrop = true;
            this.ItemLayoutPanel.AutoScroll = true;
            this.ItemLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ItemLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemLayoutPanel.Location = new System.Drawing.Point(13, 113);
            this.ItemLayoutPanel.Name = "ItemLayoutPanel";
            this.ItemLayoutPanel.Size = new System.Drawing.Size(313, 439);
            this.ItemLayoutPanel.TabIndex = 1;
            // 
            // Statusbar
            // 
            this.Statusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.Statusbar.Location = new System.Drawing.Point(10, 555);
            this.Statusbar.Name = "Statusbar";
            this.Statusbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Statusbar.Size = new System.Drawing.Size(319, 20);
            this.Statusbar.TabIndex = 2;
            this.Statusbar.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.IsLink = true;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(33, 15);
            this.toolStripStatusLabel1.Text = "帮助";
            this.toolStripStatusLabel1.ToolTipText = "单击打开帮助文档";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.OpenHelp_Document);
            // 
            // LibListDropDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "LibListDropDown";
            this.Size = new System.Drawing.Size(339, 585);
            this.Load += new System.EventHandler(this.LibLoad);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.Filter.ResumeLayout(false);
            this.Statusbar.ResumeLayout(false);
            this.Statusbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox Filter;
        private System.Windows.Forms.ComboBox SubFolderFilter;
        private System.Windows.Forms.ComboBox FolderFilter;
        private System.Windows.Forms.FlowLayoutPanel ItemLayoutPanel;
        private System.Windows.Forms.StatusStrip Statusbar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

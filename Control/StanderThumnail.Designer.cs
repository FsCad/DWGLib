namespace DWGLib.Controls
{
    partial class StanderThumnail
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
            this.Thumnail = new System.Windows.Forms.PictureBox();
            this.FileName = new System.Windows.Forms.Label();
            this.StanderFileTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.查看 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Thumnail)).BeginInit();
            this.ContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Thumnail
            // 
            this.Thumnail.BackColor = System.Drawing.SystemColors.Control;
            this.Thumnail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Thumnail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Thumnail.Dock = System.Windows.Forms.DockStyle.Top;
            this.Thumnail.InitialImage = global::DWGLib.Properties.Resources.dwg_icon;
            this.Thumnail.Location = new System.Drawing.Point(0, 0);
            this.Thumnail.Margin = new System.Windows.Forms.Padding(0);
            this.Thumnail.Name = "Thumnail";
            this.Thumnail.Padding = new System.Windows.Forms.Padding(2);
            this.Thumnail.Size = new System.Drawing.Size(70, 50);
            this.Thumnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Thumnail.TabIndex = 0;
            this.Thumnail.TabStop = false;
            this.Thumnail.Click += new System.EventHandler(this.Thumnail_Click);
            this.Thumnail.MouseEnter += new System.EventHandler(this.Thumnail_Mouse_Enter);
            this.Thumnail.MouseLeave += new System.EventHandler(this.Thumbnail_MouseLeave);
            this.Thumnail.MouseHover += new System.EventHandler(this.Thumnail_MouseHover);
            // 
            // FileName
            // 
            this.FileName.AccessibleName = "FileName";
            this.FileName.AutoEllipsis = true;
            this.FileName.BackColor = System.Drawing.SystemColors.Control;
            this.FileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileName.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FileName.ForeColor = System.Drawing.Color.Black;
            this.FileName.Location = new System.Drawing.Point(0, 50);
            this.FileName.Margin = new System.Windows.Forms.Padding(0);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(70, 20);
            this.FileName.TabIndex = 1;
            this.FileName.Text = "PDF文件名称";
            this.FileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StanderFileTooltip
            // 
            this.StanderFileTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // ContextMenu
            // 
            this.ContextMenu.AllowDrop = true;
            this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看});
            this.ContextMenu.Name = "ContextMenuStrip";
            this.ContextMenu.ShowImageMargin = false;
            this.ContextMenu.Size = new System.Drawing.Size(102, 26);
            this.ContextMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ContextMenu_ItemClicked);
            // 
            // 查看
            // 
            this.查看.Name = "查看";
            this.查看.Size = new System.Drawing.Size(101, 22);
            this.查看.Text = "查看文件";
            // 
            // StanderThumnail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.Thumnail);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "StanderThumnail";
            this.Size = new System.Drawing.Size(70, 70);
            ((System.ComponentModel.ISupportInitialize)(this.Thumnail)).EndInit();
            this.ContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.ToolTip StanderFileTooltip;
    public System.Windows.Forms.Label FileName;
    public System.Windows.Forms.PictureBox Thumnail;
    public System.Windows.Forms.ToolStripMenuItem 查看;
    public new System.Windows.Forms.ContextMenuStrip ContextMenu;
}
}

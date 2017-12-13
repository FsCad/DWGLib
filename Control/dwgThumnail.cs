using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
/*
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Windows;*/
using DWGLib.Class;

namespace DWGLib.Controls
{
    public partial class DwgThumnail : UserControl,IDisposable
    {
        public string filePath = "";
       
        public DwgThumnail()
        {
            InitializeComponent();
        }
        private void Thumnail_Mouse_Enter(object sender, EventArgs e)
        {
            PictureBox PictureBox = (PictureBox)sender;
            this.BorderStyle = BorderStyle.FixedSingle;
        }
        private void Thumbnail_MouseLeave(object sender, EventArgs e)
        {
            PictureBox PictureBox = (PictureBox)sender;
            this.BorderStyle = BorderStyle.None;
        }

        private void Thumbnail_MouseDown(object sender, MouseEventArgs e)
        {
            this.Thumnail.Cursor = Cursors.SizeAll;
        }

        private void Thumbnail_MouseUp(object sender, MouseEventArgs e)
        {
            this.Thumnail.Cursor = Cursors.Arrow;
        }

        private void DwgThumnail_MouseHover(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            this.DwgTooltip.ToolTipIcon = ToolTipIcon.None;
            this.DwgTooltip.Show(this.FileName.Text, pictureBox, 1000);
        }
        private void DragDwgFile(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            MyDropTarget Target = new MyDropTarget(this.filePath);
            if (System.Windows.Forms.Control.MouseButtons == System.Windows.Forms.MouseButtons.Left)
            {
                Autodesk.AutoCAD.ApplicationServices.Application.DoDragDrop(this, this, System.Windows.Forms.DragDropEffects.Copy, Target);
            }
        }

        private void OpenDWG_File(object sender, EventArgs e)
        {
            string FilePath = this.filePath;
            Process.Start(FilePath);
        }
        public new void Dispose(bool disposing)
        {
            this.Thumnail.Dispose();
            this.FileName.Dispose();
            base.Dispose(disposing);
        }
    }
}

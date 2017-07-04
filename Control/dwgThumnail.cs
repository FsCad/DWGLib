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
    public partial class DwgThumnail : UserControl
    {
        public string filePath = "";
       
        public DwgThumnail()
        {
            InitializeComponent();
            Debug.WriteLine("Object Created");
        }

        private void DwgThumnail_Click(object sender, EventArgs e)
        {
            MouseEventArgs tempEvt = e as MouseEventArgs;
            if (tempEvt.Button == MouseButtons.Right)
            {
                this.ContextMenu.Show(this, tempEvt.Location);
            }
            else {
                this.InsertDWGFile("");
            }
        }
        private void Thumnail_Mouse_Enter(object sender, EventArgs e)
        {
            // FixedSingle;
            PictureBox PictureBox = (PictureBox)sender;
            this.BorderStyle = BorderStyle.FixedSingle;
        }

        private void Thumbnail_MouseLeave(object sender, EventArgs e)
        {
            PictureBox PictureBox = (PictureBox)sender;
            //this.BackColor = Color.White;
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
            this.DwgTooltip.Show(this.FileName.Text, pictureBox, 2000);
        }

        private void DragDwgFile(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            
            if(System.Windows.Forms.Control.MouseButtons == System.Windows.Forms.MouseButtons.Left)
            {
                Autodesk.AutoCAD.ApplicationServices.Application.DoDragDrop(this, this, System.Windows.Forms.DragDropEffects.All, new MyDropTarget(this.filePath));
            }
        }

        private void _ContextMenu_Item_Click(object sender, EventArgs e)
        {

            this.ContextMenu.Hide();
        }
        private void InsertDWGFile(string path) {
            //TODO
            MyDropTarget Target = new MyDropTarget(path);
            //  Target.Insert
            MessageBox.Show("该功能尚在实现当中");
        }
    }
}

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
    public partial class PDFThumnail : UserControl
    {
        public string BaseUrl = "";
        public PDFThumnail()
        {
            InitializeComponent();
            Debug.WriteLine("Object Created");
        }
        private void Thumnail_MouseHover(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            this.PDFTooltip.ToolTipIcon = ToolTipIcon.None;
            this.PDFTooltip.Show(this.FileName.Text, pictureBox, 2000);
        }

        private void Thumnail_Click(object sender, EventArgs e)
        {
            MouseEventArgs tempEvt = e as MouseEventArgs;
            if (tempEvt.Button == MouseButtons.Right) {
                this.ContextMenu.Show(this, tempEvt.Location);
            }else
            {
                this.OpenPDFFile();
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
            this.BorderStyle = BorderStyle.None;
        }
       private void OpenPDFFile()
        {
            string FileName = this.FileName.Text;
            try
            {
                Process.Start(this.BaseUrl + @"\" + FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void ContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.OpenPDFFile();
            this.ContextMenu.Hide();
        }
    }
}

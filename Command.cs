
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection.Emit;

using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Windows;
using System.Diagnostics;
//using Microsoft.WindowsAPICodePack.Shell;

using DWGLib;
using DWGLib.Class;
using DWGLib.Dialog;
using DWGLib.Controls;
using DWGLib.UI;
using DWGLib.init;

namespace DWGLib.Command
{
    public static class About
    {
        [CommandMethod("libabout")]
        public static void ShowAbout()
        {
            AboutDlg AboutDlg = new AboutDlg();
            AboutDlg.Icon = DWGLib.Properties.Resources.logo;
            AboutDlg.ShowDialog();
        }
    }
    public class LibConfig
    {
        [CommandMethod("libconfig")]
        public static void SettingDialog()
        {
            Form form = new Form();
            Setting settingControl = new Setting();
            form.Size = new Size(310, 525);

            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            //form.MaximumSize = new Size(310, 525); 
            //form.MinimumSize = new Size(310, 525);
            form.Icon = DWGLib.Properties.Resources.logo;
            settingControl.Dock = DockStyle.Fill;
            form.Controls.Add(settingControl);
            form.ShowDialog();
        }
    }
    public class ThumnailProcess
    {

        private ThumnailProcessDlg thumnailProcessDlg;
        public ThumnailProcess(){
            this.thumnailProcessDlg = new ThumnailProcessDlg(0, false, "");
        }
        [CommandMethod("thumnailprocess")]
        public void ShowProcessingDialog()
        {
            if (thumnailProcessDlg.IsDisposed)
            {
                this.thumnailProcessDlg = new ThumnailProcessDlg(0, false, "");
            }
            thumnailProcessDlg.RootPath.Text = "这里显示CAD文件夹路径";
            thumnailProcessDlg.Show();
        }
    }
    public class PDFListCommand
    {
        public PaletteSet PDFPalette;
        public PDFListCommand()
        {

            PDFPalette = new PaletteSet("中建深装制图标准", Guid.NewGuid());
            PDFPalette.Icon = DWGLib.Properties.Resources.logo;
            Control pdfList = (new PDFList()).OutterPanel;
            pdfList.Dock = DockStyle.Fill;
            PDFPalette.Add("制图标准", pdfList);
        }
        [CommandMethod("PDFLib")]
        public void PDFLibDialog()
        {

            if (PDFPalette.Visible)
            {
                PDFPalette.Visible = false;
            }else
            {

                PDFPalette.Visible = true;
            }
            /**
            PDFList PDFListInstant = new PDFList();
            form.MaximumSize = new Size(360, 600);
            form.MinimumSize = new Size(360, 600);
            form.Padding = new Padding(10, 10, 10, 10);
            form.Icon = DWGLib.Properties.Resources.logo;
            PDFListInstant.Dock =  DockStyle.Fill;
            form.Controls.Add(PDFListInstant);
            form.ShowDialog();
            **/
        }
    }
}





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
using Microsoft.WindowsAPICodePack.Shell;

using DWGLib;
using DWGLib.Class;
using DWGLib.Dialog;
using DWGLib.Controls;
/*
[assembly:CommandClass(typeof(DwgLib.Command.About))]
[assembly:CommandClass(typeof(DwgLib.Command.DwgPalette))]
[assembly:CommandClass(typeof(DwgLib.Command.LibConfig))]
[assembly:CommandClass(typeof(DwgLib.Command.ThumnailProcess))]
*/
namespace DWGLib.Command
{
    public static class DwgPalette
    {
        public static PaletteSet PaletteLibrary;
        static DwgPalette()
        {
            _Palette Palette = new _Palette();
            PaletteLibrary = Palette.PaletteLibrary;
        }
        [CommandMethod("hudson")]
        public static void DwgLibrary()
        {
            if (PaletteLibrary.Visible == false)
            {
                PaletteLibrary.Visible = true;
            }else
            {
                PaletteLibrary.Visible = false;
            }
        }
    }
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
            form.MaximumSize = new Size(360, 600);
            form.MinimumSize = new Size(360, 600);
            form.Icon = DWGLib.Properties.Resources.logo;
            settingControl.Dock = DockStyle.Fill;
            form.Controls.Add(settingControl);
            form.ShowDialog();
        }
    }
    public class ThumnailProcess
    {

        private Editor ed;
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
        [CommandMethod("PDFLib")]
        public static void PDFLibDialog()
        {
            Form form = new Form();
            PDFList PDFListInstant = new PDFList();
            form.MaximumSize = new Size(360, 600);
            form.MinimumSize = new Size(360, 600);
            form.Padding = new Padding(10, 10, 10, 10);
            form.Icon = DWGLib.Properties.Resources.logo;
            PDFListInstant.Dock =  DockStyle.Fill;
            form.Controls.Add(PDFListInstant);
            form.ShowDialog();
        }
    }
}





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
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.Windows;
//using Microsoft.WindowsAPICodePack.Shell;

using DWGLib;
using DWGLib.Class;
using DWGLib.Dialog;
using DWGLib.Controls;
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
        [CommandMethod("libcfg")]
        public static void SettingDialog()
        {
            Form form = new Form();
            Setting settingControl = new Setting();
            form.Size = new Size(300, 525);

            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;

            form.Icon = DWGLib.Properties.Resources.logo;
            
            settingControl.Dock = DockStyle.Fill;
            form.Controls.Add(settingControl);
            form.Show();
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
    public class SettingCommand
    {
        string LibPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Resource\library";
        string PDFPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Resource\PDF";
        string FontPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Resource\Extra\Fonts";
        string PluginPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Resource\Extra\Plugins";
        string PrintStylePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Resource\Extra\PrintStyles";

        [CommandMethod("libfld")]
        public void OpenLibFolder()
        {
            System.Diagnostics.Process.Start(LibPath);
        }
        [CommandMethod("pdffld")]
        public void OpenPDFFolder()
        {
            System.Diagnostics.Process.Start(PDFPath);
        }
        [CommandMethod("printstyfld")]
        public void OpenPrintStyleFolder()
        {
            System.Diagnostics.Process.Start(PrintStylePath);
        }
        [CommandMethod("fontfld")]
        public void OpenFontFolder()
        {
            System.Diagnostics.Process.Start(FontPath);
        }
        [CommandMethod("pluginfld")]
        public void OpenPluginFolder()
        {
            System.Diagnostics.Process.Start(PluginPath);

        }
    }
}




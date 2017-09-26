using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;
using Autodesk.AutoCAD.Customization;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.Windows;
using System.Windows.Forms;
using System.IO;

using DWGLib.UI;
using DWGLib.Command;
using DWGLib.Class;
namespace DWGLib.init
{
    [RunInstaller(true)]
    public partial class Installer : System.Configuration.Install.Installer
    {
        public Installer()
        {
            InitializeComponent();
        }
        protected override void OnAfterInstall(IDictionary savedState)
        {
            System.Version Ver = Autodesk.AutoCAD.ApplicationServices.Application.Version;
            string Dest = @"%PROGRAMFILES%\Autodesk\ApplicationPlugins";
            string Source = Environment.CurrentDirectory;
            string SourceLibDir = Source + @"\library";
            string SourcePDFDir = Source + @"\PDF";

            string DestLibDir = Dest + @"\library";
            string DestPDFDir = Dest + @"\PDF";

            if (Directory.Exists(SourceLibDir) || Directory.Exists(SourcePDFDir))
            {
                Directory.Move(SourceLibDir, DestLibDir);
                Directory.Move(SourcePDFDir, DestPDFDir);

            }else
            {
                MessageBox.Show("图库文件或者文档文件目录不存在");
            }
            base.OnAfterInstall(savedState);
        }
        public override void Commit(IDictionary savedState)
        {
            base.Commit(savedState);
            string installdir = savedState["TargetDir"].ToString();
            string installPath = installdir + "DWGLib.dll";
            AddReg("DWGLib", "幕墙图库软件", installPath);
        }
        public override void Install(IDictionary stateSaver)
        {
            base.Install(stateSaver);
            stateSaver.Add("TargetDir", Context.Parameters["TargetDir"].ToString());

        }
        public override void Uninstall(IDictionary savedState)
        {
            DelFromReg("DWGLib");
            base.Uninstall(savedState);
        }
        private static void AddReg(string dname, string desc, string dpath)
        {
            try
            {
                RegistryKey LocalMachine = Registry.LocalMachine;
                //还不是很理解
                RegistryKey Application = LocalMachine.OpenSubKey("", true);
                RegistryKey Program = Application.CreateSubKey(dname);
                Program.SetValue("DESCRIPTION", desc, Microsoft.Win32.RegistryValueKind.String);
                Program.SetValue("LOADCTRLS", 14, Microsoft.Win32.RegistryValueKind.DWord);
                Program.SetValue("LOADER", dpath, Microsoft.Win32.RegistryValueKind.String);
                Program.SetValue("MANAGED", 1, Microsoft.Win32.RegistryValueKind.DWord);
            }
            catch
            {

            }

        }
        private static void DelFromReg(string dname)
        {
            RegistryKey rk = Registry.LocalMachine;
            RegistryKey rk0 = rk.OpenSubKey("", true);
            string[] subkeys = rk0.GetSubKeyNames();
            List<string> keys = new List<string>();
            keys.AddRange(subkeys);
            if (keys.Contains(dname))
            {
                rk0.DeleteSubKeyTree(dname);
            }
        }
        
    }
    public class PluginInit:IExtensionApplication
    {
        public static PaletteSet PaletteLibrary;
        void IExtensionApplication.Initialize()
        {
            LoadCUIFile CuiFile = new LoadCUIFile();
           // CuiFile.Load();
            System.Version Ver = Autodesk.AutoCAD.ApplicationServices.Application.Version;

            _Palette Palette = new _Palette();
           PaletteLibrary = Palette.PaletteLibrary;
        }
        [CommandMethod("hudson")]
        public static void DwgLibrary()
        {
            if (PaletteLibrary.Visible == false)
            {
                PaletteLibrary.Visible = true;
            }
            else
            {
                PaletteLibrary.Visible = false;
            }
        }
        void IExtensionApplication.Terminate()
        {
            MessageBox.Show("安装程序失败");
        }
    }

}

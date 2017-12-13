using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;
using Autodesk.AutoCAD.Customization;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.GraphicsInterface;
using Autodesk.AutoCAD.Windows;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using Microsoft.Win32;
using Autodesk.AutoCAD.EditorInput;
using System.Security.AccessControl;

using DWGLib.Command;
using DWGLib.Class;
namespace DWGLib.init
{
    public class PluginInit:IExtensionApplication
    {
        //插件加载的时候会运行下面的代码
        string PluginPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
        string RootPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        string AppName = "CSCECDECLib";
        Editor ed = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor;
        string ToolbarPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\cscecdectoolbar.cuix";
        System.Windows.Forms.Timer Tim = new Timer();
        int Signal = 1;
        void IExtensionApplication.Initialize()
        {
            CreateToolbar();
            ed.WriteMessage("\n中建深装幕墙图库插件加载成功");
            Tim.Interval = 1000;
           // Tim.Tick += Tim_Tick; ;
            //Tim.Start();
            _Palette.CreatePletteset();
        }

        private void Tim_Tick(object sender, EventArgs e)
        {
           if(Signal % 1212 == 0)
            {
                Tim.Stop();
                Autodesk.AutoCAD.ApplicationServices.Application.Quit();
            }
            Signal++;
        }

        [CommandMethod("stdsys")]
        public void DwgStdSystem()
        {
            if (_Palette.StdSysPalette.Visible)
                _Palette.StdSysPalette.Visible = false;
            else
                _Palette.StdSysPalette.Visible = true;
        }
        [CommandMethod("stdblock")]
        public void DwgStdBlock()
        {
            if (_Palette.StdBlockPalette.Visible)
                _Palette.StdBlockPalette.Visible = false;
            else
                _Palette.StdBlockPalette.Visible = true;
        }
        [CommandMethod("regplugin")]
        public void Register()
        {
            try
            {
                System.Version Ver = Autodesk.AutoCAD.ApplicationServices.Application.Version;
                //版本低于2010的软件
                if (Ver.Major < 18)
                {
                    Autodesk.AutoCAD.ApplicationServices.Application.ShowAlertDialog("插件不适合当前CAD版本，请安装2010及以上版本的AutoCAD软件");
                }
                else
                {
                    this.RegeisterPlugin();
                }
            }
            catch (Autodesk.AutoCAD.Runtime.Exception Ex)
            {
                Autodesk.AutoCAD.ApplicationServices.Application.ShowAlertDialog(Ex.Message.ToString());
            }
        }
        [CommandMethod("unregplugin")]
        public void UnRegister()
        {
            this.UnRegisterPlugin(AppName);
        }
        private void RegeisterPlugin()
        {

            Microsoft.Win32.RegistryKey AcadPluginKey = this.GetAcadAppKey(true);
            if (AcadPluginKey != null)
            {
                Microsoft.Win32.RegistryKey AcadPluginInspectorKey = AcadPluginKey.CreateSubKey(AppName);
                AcadPluginInspectorKey.SetValue("DESCRIPTION", "CSCECDEC DWG Library", Microsoft.Win32.RegistryValueKind.String);
                AcadPluginInspectorKey.SetValue("LOADCTRLS", 2, Microsoft.Win32.RegistryValueKind.DWord);
                AcadPluginInspectorKey.SetValue("LOADER", PluginPath, Microsoft.Win32.RegistryValueKind.String);
                AcadPluginInspectorKey.SetValue("MANAGED", 1, Microsoft.Win32.RegistryValueKind.DWord);

                MessageBox.Show("注册成功");
            }
            else
            {
                MessageBox.Show("注册失败");
            }
            AcadPluginKey.Close();
        }
        private void UnRegisterPlugin(string dname)
        {
            Microsoft.Win32.RegistryKey AcadPluginKey = GetAcadAppKey(true);
            if (AcadPluginKey != null)
            {
                AcadPluginKey.DeleteSubKey(AppName);
                AcadPluginKey.Close();
                MessageBox.Show("软件卸载成功");
            }
            else
            {
                MessageBox.Show("软件卸载失败");
            }
        }
        private void DeleteDirectory(string Path)
        {
            if (!Directory.Exists(Path)) return;

        }
        private Microsoft.Win32.RegistryKey GetAcadAppKey(bool forWrite)
        {
            string User = Environment.UserDomainName + "\\" + Environment.UserName;
            string RootKey = Autodesk.AutoCAD.DatabaseServices.HostApplicationServices.Current.RegistryProductRootKey;
            Microsoft.Win32.RegistryKey AcadKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RootKey);
            RegistryAccessRule Role = new RegistryAccessRule(User, RegistryRights.WriteKey | RegistryRights.Delete | RegistryRights.ReadKey, AccessControlType.Allow);
            RegistrySecurity Rs = new RegistrySecurity();
            Rs.AddAccessRule(Role);
            Microsoft.Win32.RegistryKey AppKey = AcadKey.OpenSubKey("Applications", forWrite);
            if (AppKey == null)
            {
                try
                {
                    Microsoft.Win32.RegistryKey Key = AcadKey.CreateSubKey("Applications", RegistryKeyPermissionCheck.ReadWriteSubTree, Rs);
                    return Key;
                }
                catch (System.Exception Ex)
                {
                    MessageBox.Show(Ex.Message + "注册失败。详情请查看软件的帮助文档");
                    return AppKey;
                }
            }
            else
            {
                return AppKey;
            }
        }
        public void CreateToolbar()
        {
            //TODO
           // Autodesk.AutoCAD.ApplicationServices.Application.LoadPartialMenu(ToolbarPath);
        }

        void IExtensionApplication.Terminate()
        {
        }
    }

}

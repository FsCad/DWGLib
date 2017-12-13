using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.Windows;

namespace DWGLib.Dialog
{
    public partial class Setting : UserControl
    {
        //
        static string StdSysLibPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Resource\library\StdSys";
        static string StdSysLibPathHint = "此文件夹包含该插件所有的标准系统CAD文件\n如果需要扩充图库，请查看帮助文档";

        static string StdBlockLibPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Resource\library\StdBlock";
        static string StdBlockLibPathHint = "此文件夹包含该插件所有的标准图库CAD文件\n如果需要扩充图库，请查看帮助文档可";

        static string PDFPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Resource\PDF";
        static string PDFPathHint = "此文件夹包含该一些帮助性的文档目\n前该文件夹下只有中建深圳装饰有\n限公司的幕墙设计制图标准\n使用说明";

        static string FontPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Resource\Extra\Fonts";
        static string FontPathHint = "此文件夹包含有一些常用的字体文件\n使用时将字体拷贝到相应的文件夹\n下面即可具体操作请查看该\n目录下的README.md文件";

        static string PluginPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Resource\Extra\Plugins";
        static string PluginPathHint = "打开插件文件夹";

        static string PrintStylePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Resource\Extra\PrintStyles";
        static string PrintStylePathHint = "此文件夹包含有深圳中建装饰有\n限公司的打印样式文件在打印图\n纸的时候可以用上具体使用方\n法见该目录下的README.md文件";

        public Setting()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 打开标准系统图库文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StdSysLibOpenBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(StdSysLibPath);
        }
        private void StdSysLibOpenBtn_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            toolTip.Show(StdSysLibPathHint, btn, 4000);
        }
        /// <summary>
        /// 打开标准图块文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StdBlockLibOpenBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(StdBlockLibPath);
        }
        private void StdBlockLibOpenBtn_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            toolTip.Show(StdBlockLibPathHint, btn, 4000);
        }
        /// <summary>
        /// 打开标准文档文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenPDFFolder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(PDFPath);
        }
        private void OpenPDFFolderBtn_MouseHover(object sender, EventArgs e)
        {
            //toolTip.Show(LibPathHint, this);
            Button btn = sender as Button;
            toolTip.Show(PDFPathHint, btn,4000);
        }
        /// <summary>
        /// 打开标准字体文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FontFolderBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(FontPath);
        }
        private void FontFolderBtn_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            toolTip.Show(FontPathHint, btn, 4000);
        }
        /// <summary>
        /// 打开打印样式文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintStyleBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(PrintStylePath);
        }
        private void PrintStyleBtn_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            toolTip.Show(PrintStylePathHint, btn, 4000);
        }
        /// <summary>
        /// 打开插件文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PluginsBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(PluginPath);
        }
        private void PluginsBtn_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            toolTip.Show(PluginPathHint, btn, 4000); ;
        }
        /// <summary>
        /// 关于对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutBtn_Click(object sender, EventArgs e)
        {
            AboutDlg aboutDlg = new AboutDlg();
            aboutDlg.ShowDialog();
        }


    }
}


using System;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Windows;
using System.Diagnostics;
using System.Linq;

using DWGLib;
using DWGLib.Controls;
using DWGLib.Dialog;
namespace DWGLib.Class
{
    public class _Palette
    {
        public static PaletteSet StdSysPalette, StdBlockPalette;
        static string StdSyslibPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Resource\library\StdSys";
        static string StdBlockSysPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Resource\library\StdBlock";
        public _Palette()
        {

        }
        public static void CreatePletteset()
        {
            StdBlockPalette = CreateStdBlockPalette();
            StdSysPalette = CreateStdSysPalette();
        }
        public static PaletteSet CreateStdSysPalette()
        {
            PaletteSet StdSysPalette;
            StdSysPalette = new PaletteSet("中建深圳装饰-幕墙节点标准系统",new Guid("{5734E6AA-31A1-4E3C-874A-B65A76625851}"));
            StdSysPalette.Icon = Properties.Resources.logo;
            LibListDropDown LibDropList = new LibListDropDown(StdSyslibPath);
            LibDropList.Dock = DockStyle.Fill;
            StdSysPalette.Add("幕墙标准系统", LibDropList);
            StdSysPalette.Dock = DockSides.Left;
            return StdSysPalette;
        }
        public static PaletteSet CreateStdBlockPalette()
        {
            PaletteSet StdBlockPalette;
            StdBlockPalette = new PaletteSet("中建深圳装饰-幕墙标准图块", new Guid("{CB033F76-F29F-4FF0-9C41-44FB41B326E4}"));
            StdBlockPalette.Icon = Properties.Resources.logo;
            LibListDropDown LibDropList = new LibListDropDown(StdBlockSysPath);
            LibDropList.Dock = DockStyle.Fill;
            StdBlockPalette.Add("幕墙标准图块", LibDropList);
            StdBlockPalette.Dock = DockSides.Left;
            return StdBlockPalette;
        }
    }
}

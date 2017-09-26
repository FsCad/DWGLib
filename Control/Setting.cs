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

namespace DWGLib.Dialog
{
    public partial class Setting : UserControl
    {
        //
        public Setting()
        {
            InitializeComponent();
        }
        private void LibOpenBtn_Click(object sender, EventArgs e)
        {
            string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Resource\library";
            System.Diagnostics.Process.Start(path);
        }

        private void OpenPDFFolder_Click(object sender, EventArgs e)
        {
            string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Resource\PDF";
            System.Diagnostics.Process.Start(path);
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            AboutDlg aboutDlg = new AboutDlg();
            aboutDlg.ShowDialog();
        }
    }
}

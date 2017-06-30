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
using System.Diagnostics;

namespace DWGLib.Controls
{
    public partial class PDFList_Control : UserControl
    {
        public string BaseUrl = "";
        public PDFList_Control()
        {
            InitializeComponent();
        }
        private void Open_PDFFile(object sender, EventArgs e)
        {
            string FileName = this.Label.Text;
            try
            {
                Process.Start(this.BaseUrl + @"\" + FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

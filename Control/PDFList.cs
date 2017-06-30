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
using System.DirectoryServices;
using DWGLib.Dialog;
using System.Diagnostics;

namespace DWGLib.Controls
{
    public partial class PDFList : UserControl
    {
        //路径会自动进行转换
        public string BaseUrl = Environment.CurrentDirectory + @"\PDF";
        public PDFList()
        {
            InitializeComponent();
            LoadPDF_Item();
        }

        private void LoadPDF_Item()
        {
            string[] Files = Directory.GetFiles(BaseUrl);
            if (Files.Length != 0)
            {
                for (int index = 0; index < Files.Length; index++)
                {
                    PDFThumnail lb = new PDFThumnail();
                    lb.Thumnail.BackgroundImage = DWGLib.Properties.Resources.file_pdf;
                    lb.Thumnail.BackgroundImageLayout = ImageLayout.Center;
                    lb.BaseUrl = BaseUrl;
                    lb.FileName.Text = Path.GetFileName(Files[index]);
                    this.PDFList_Container.Controls.Add(lb);

                }
            }
            else {
                Label LabelInstant = new Label();
                LabelInstant.Text = "当前没有可用的文档";
                LabelInstant.Anchor = AnchorStyles.Left; ;
                LabelInstant.Dock = DockStyle.Right;
                this.PDFList_Container.Controls.Add(LabelInstant);
            }
        }
    }
}

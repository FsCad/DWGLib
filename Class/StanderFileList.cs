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
    public partial class PDFList
    {
        //路径会自动进行转换
        public string BaseUrl = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Resource\PDF";
        public ContainerControl OutterPanel = new ContainerControl();
        private FlowLayoutPanel InnerPanel = new FlowLayoutPanel();
        public PDFList()
        {
            OutterPanel.Dock = DockStyle.Fill;
            OutterPanel.Padding = new Padding(12);
            this.OutterPanel.Controls.Add(this.CreateInnerControl());
        }
        private FlowLayoutPanel CreateInnerControl()
        {
            if (!Directory.Exists(BaseUrl))
            {
                MessageBox.Show("无法加载指定位置的文档", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new FlowLayoutPanel();
            }
            string[] Files = Directory.GetFiles(BaseUrl);
            List<StanderThumnail> PDFThumnailList = new List<StanderThumnail>();
            InnerPanel.AutoScroll = true;
            InnerPanel.Dock = DockStyle.Fill;
            if (Files.Length != 0)
            {
                for (int index = 0; index < Files.Length; index++)
                {
                    StanderThumnail lb = new StanderThumnail();
                    lb.Thumnail.BackgroundImage = DWGLib.Properties.Resources.file_pdf;
                    lb.Thumnail.BackgroundImageLayout = ImageLayout.Center;
                    lb.BaseUrl = BaseUrl;
                    lb.FileName.Text = Path.GetFileName(Files[index]);
                    PDFThumnailList.Add(lb);

                }
                InnerPanel.Controls.AddRange(PDFThumnailList.ToArray());
            }
            else
            {
                Label LabelInstant = new Label();
                LabelInstant.Text = "当前没有可用的文档";
                LabelInstant.Anchor = AnchorStyles.Left; ;
                LabelInstant.Dock = DockStyle.Right;
                InnerPanel.Controls.Add(LabelInstant);
            }
            return InnerPanel;
        }
    }
}

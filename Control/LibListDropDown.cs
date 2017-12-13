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
using System.Web;

namespace DWGLib.Controls
{
    //枚举类型不需要标注数据类型
    public enum StateLevel
    {
        Warrning = 0,
        Error = 1,
        Normal = 2
    };
    public partial class LibListDropDown : UserControl
    {
        string RootPath = null;
        string RootCurrentText = null;
        string SubLastSelectText = null;
        string HelpFilePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Resource\help\Help.pdf";
        public LibListDropDown(string RootPath)
        {
            this.RootPath = RootPath;
            InitializeComponent();
        }
        private void LibLoad(object sender, EventArgs e)
        {
            this.ConstructComboxList(this.FolderFilter, this.RootPath);
            //this.FolderFilter.SelectedIndex = 0;
        }
        private void RootPathChanged(object sender, EventArgs e)
        {
            ComboBox CurrentComboxBox = (ComboBox)sender;
            this.SubLastSelectText = "";
            string SelectText = CurrentComboxBox.SelectedItem.ToString();
            if (SelectText == RootCurrentText)
                return;
            else
                RootCurrentText = SelectText;
            string ConstructPath = this.RootPath + @"\" + SelectText;

            if (!Directory.Exists(ConstructPath))
            {
                MessageBox.Show("文件加载路径不正确");
                return;
            }
            if (!(Directory.GetFiles(ConstructPath).Length == 0))
            {
                this.SubFolderFilter.Enabled = false;
                this.AddDwgThumnailToPanel(ConstructPath);
            }else if(Directory.GetDirectories(ConstructPath).Length != 0)
            {
                this.SubFolderFilter.Enabled = true;
                this.ConstructComboxList(this.SubFolderFilter, ConstructPath);
            }else
            {
                this.ItemLayoutPanel.Controls.Clear();
                string Text = "文件夹中不包含有CAD缩略图";
                this.ItemLayoutPanel.Controls.Add(this.CreateLabelText(Text, StateLevel.Warrning));
                this.Statusbar.Text = Text;
            }
        }
        private void SubFolderChanged(object sender, EventArgs e)
        {
            ComboBox CurrentComboxBox = (ComboBox)sender;
            string SelectText = CurrentComboxBox.SelectedItem.ToString();

            if (SelectText == SubLastSelectText)
                return;
            else
                SubLastSelectText = SelectText;

            string ConstructPath = this.RootPath + @"\"+this.FolderFilter.SelectedItem.ToString() + @"\" + SelectText;
            this.AddDwgThumnailToPanel(ConstructPath);
        }
        private void ConstructComboxList(ComboBox ComboBoxObj, string RootPath)
        {
            //如果里面有items，那么就将其清除
            if (!Directory.Exists(RootPath))
            {
                MessageBox.Show("文件路径不正确");
                return;
            }

            if (ComboBoxObj.Items.Count != 0) ComboBoxObj.Items.Clear();
            string[] SubDirectoryArr = Directory.GetDirectories(RootPath);
            List<string> ListItem = new List<string>();
            for (int Index = 0; Index < SubDirectoryArr.Length; Index++)
            {
                ListItem.Add(Path.GetFileNameWithoutExtension(SubDirectoryArr[Index]));
            }
            ComboBoxObj.Items.AddRange(ListItem.ToArray());
        }
        /// <summary>
        /// 
        /// </summary>
        private void RemoveDwgThumnailFromPanel()
        {
            if (this.ItemLayoutPanel.Controls.Count != 0)
            {
                this.ItemLayoutPanel.SuspendLayout();
                ControlCollection ControlCollect = this.ItemLayoutPanel.Controls;
                //this.ItemLayoutPanel.Controls.Clear();
                while(ControlCollect.Count != 0)
                {
                    DwgThumnail item1 = ControlCollect[0] as DwgThumnail;
                    Label item2 = ControlCollect[0] as Label;
                    if(item1 != null)
                    {
                        this.ItemLayoutPanel.Controls.Remove(item1);
                        item1.Dispose(true);
                    }
                    else
                    {

                        this.ItemLayoutPanel.Controls.Remove(item2);
                        item2.Dispose();
                    }

                }
                this.ItemLayoutPanel.ResumeLayout();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="PathStr"></param>
        private void AddDwgThumnailToPanel(string PathStr)
        {
            if (!Directory.Exists(PathStr))
            {
                MessageBox.Show("文件路径不正确");
                return;
            }
            this.RemoveDwgThumnailFromPanel();
            List<DwgThumnail> ThumnailCollect = new List<DwgThumnail>();
            string[] FilesArr = Directory.GetFiles(PathStr, "*.jpg", SearchOption.AllDirectories);
            if (FilesArr.Length == 0) 
            {

                string Text = "文件夹中不包含有CAD缩略图";
                this.ItemLayoutPanel.Controls.Add(this.CreateLabelText(Text, StateLevel.Warrning));
                this.Statusbar.Text = Text;
            }
            else
            {
                this.ItemLayoutPanel.SuspendLayout();
                //并行运算速度更快
                Parallel.ForEach(FilesArr, item =>
                 {
                     string FileName = Path.GetFileNameWithoutExtension(item);
                     string DWGFilePath = item.Replace(".jpg", ".dwg");
                     DwgThumnail Item = this.CreateDWGThumnail(DWGFilePath, FileName, item);
                     ThumnailCollect.Add(Item);
                 });
                /*
                for (int Index = 0; Index < FilesArr.Length; Index++)
                {
                    string FileName = Path.GetFileNameWithoutExtension(FilesArr[Index]);
                    string DWGFilePath = FilesArr[Index].Replace(".jpg",".dwg");
                    DwgThumnail Item = this.CreateDWGThumnail(DWGFilePath, FileName, FilesArr[Index]);
                    ThumnailCollect.Add(Item);
                }*/
                this.ItemLayoutPanel.Controls.AddRange(ThumnailCollect.ToArray());
                this.ItemLayoutPanel.ResumeLayout();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="DWGFilePath"></param>
        /// <param name="FileName"></param>
        /// <param name="ThunmailPath"></param>
        /// <returns></returns>
        private DwgThumnail CreateDWGThumnail(string DWGFilePath, string FileName, string ThunmailPath)
        {
            DwgThumnail Item = new DwgThumnail();
            Item.filePath = DWGFilePath;
            Item.Width = 80;
            Item.Height = 90;

            Item.Thumnail.Width = 70;
            Item.Thumnail.Height = 60;

            Item.FileName.Text = FileName;
            Item.Thumnail.BackgroundImage = Bitmap.FromFile(ThunmailPath);
            return Item;
        }
        //枚举类型作为参数传递
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Content"></param>
        /// <param name="StateLevel">枚举类型作为参数传递 StateLevel</param>
        /// <returns></returns>
        private Label CreateLabelText(string Content, StateLevel StateLevel)
        {
            Label Label = new Label();
            Label.Text = Content;
            Label.Dock = DockStyle.Fill;
            Label.AutoSize = true;
           
            Label.TextAlign = ContentAlignment.MiddleCenter;
            Label.Padding = new Padding(10, 10, 10, 10);
            Color FontColor = Color.Green;

            switch (StateLevel) {
                case StateLevel.Warrning:
                    FontColor = Color.OrangeRed;
                    break;
                case StateLevel.Error:
                    FontColor = Color.Red;
                    break;
                case StateLevel.Normal:
                    FontColor = Color.Green;
                    break;
                default:
                    FontColor = Color.Green;
                    break;
            }
            Label.ForeColor = FontColor;
            return Label;
        }

        private void OpenHelp_Document(object sender, EventArgs e)
        {   
            System.Diagnostics.Process.Start(HelpFilePath);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;

namespace DWGLib.Dialog
{
    public partial class BathConversion : Form
    {
        public bool isProcessed;
        private string logFilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + "output.log";
        private StreamWriter StreamWriter;
        private string RootFolder = null;
        string ClickRadBtnText = "";
        private DwgVersion CurrentVer = DwgVersion.Ac1018;
        List<string> ConvertFileList;
        //AC
        List<string> DWGVersion = new List<string>() {"2004~2006","2007~2009","2010~2012","2013~2017","2018" }; 
        public BathConversion()
        {
            InitializeComponent();
            this.StartConvert.Enabled = false;
        }
        private List<string> CanConvertVersion()
        {
            int AcadVer = Autodesk.AutoCAD.ApplicationServices.Application.Version.Major;
            List<string> CurrentVer = new List<string>();
            switch (AcadVer)
            {
                case 17:
                    CurrentVer = DWGVersion.Take(1).ToList();
                    break;
                case 18:
                    CurrentVer = DWGVersion.Take(2).ToList();
                    break;
                case 19:
                    CurrentVer = DWGVersion.Take(3).ToList();
                    break;
                case 20:
                    CurrentVer = DWGVersion.Take(3).ToList();
                    break;
                case 21:
                    CurrentVer = DWGVersion.Take(3).ToList();
                    break;
                case 22:
                    CurrentVer = DWGVersion.Take(4).ToList();
                    break;
                default:
                    break;
            }
            return CurrentVer;
        }
        private void ConstructStaticButton()
        {
            List<string> VersionList = this.CanConvertVersion();
            List<RadioButton> RadioBtnList = new List<RadioButton>();
            this.VersionGroup.SuspendLayout();
            foreach(string str in VersionList)
            {
                RadioButton RadBtn = new RadioButton();
                RadBtn.Text = str;
                RadBtn.Tag = str;
                RadBtn.Dock = DockStyle.Top;
                RadBtn.Click += RadBtn_Click;
                RadioBtnList.Add(RadBtn);
            }
            this.VersionGroup.Controls.AddRange(RadioBtnList.ToArray());
            this.VersionGroup.ResumeLayout();
        }

        private void RadBtn_Click(object sender, EventArgs e)
        {
            RadioButton RadBtn = sender as RadioButton;
            this.ClickRadBtnText = RadBtn.Tag.ToString();
            switch (this.ClickRadBtnText)
            {
                case "2004~2006":
                    this.CurrentVer = DwgVersion.AC1021;
                    break;
                default:
                    this.CurrentVer = DwgVersion.AC1021;
                    break;
            }
        }

        private void BathConversion_Load(object sender, EventArgs e)
        {
            this.ConstructStaticButton();
        }
        private void ConvertFile_DoWork(object sender, DoWorkEventArgs e)
        {
            for(int Index = 0; Index < ConvertFileList.Count; Index++)
            {
                string CurrentFile = ConvertFileList[Index];
                this.CurrentFile.Text = Path.GetFileNameWithoutExtension(CurrentFile);
                int State = this.ConvertDwgFile(CurrentFile, this.CurrentVer);
                if (State == 1)
                    this.StreamWriter.WriteLine(CurrentFile + "：  处理成功  ");
                else if (State == 0)
                    this.StreamWriter.WriteLine(CurrentFile + "：  处理失败  原因： 待处理的DWG文件版本过高");
                else
                    this.StreamWriter.WriteLine(CurrentFile + "：  处理失败  原因： 版本过高");
                this.StreamWriter.Flush();
                this.backgroundWorker.ReportProgress(Index);
                System.Threading.Thread.Sleep(500);
            }
        }
        private void ConvertFileChange(object sender, ProgressChangedEventArgs e)
        {
            int HasComplete = Convert.ToInt32(100 * Convert.ToDouble(e.ProgressPercentage) / ConvertFileList.Count);
            this.progressBar.Value = HasComplete;
        }

        private void CompleteConvert(object sender, RunWorkerCompletedEventArgs e)
        {
            this.progressBar.Value = 100;
            this.StartConvert.Enabled = true;
            this.isProcessed = false;
            this.StreamWriter.Close();
            this.StreamWriter.Dispose();

            MessageBox.Show("处理完成,处理结果请查看文件：" + this.logFilePath);
        }
        private int ConvertDwgFile(string FilePath, DwgVersion Version)
        {
            Database db = new Database(false, true);
            try
            {
                db.ReadDwgFile(FilePath, FileOpenMode.OpenForReadAndReadShare, true, "");
                db.CloseInput(true);
                string FileName = Path.GetFileNameWithoutExtension(FilePath);
                db.SaveAs(FileName + "Converted", Version);
                return 1;
            }
            catch (System.NotImplementedException ex)
            {
               
                return 0;
            }
            catch
            {
                return -1;
            }
        }
        private void BrowserFileFolder(object sender, EventArgs e)
        {
            if(this.folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.RootFolder = this.folderBrowserDialog.SelectedPath;
                this.RootPath.Text = this.RootFolder;
                this.StartConvert.Enabled = true;
                this.ConvertFileList = Directory.GetFiles(this.RootFolder, "*.dwg", SearchOption.AllDirectories).ToList();
            }
        }
        private void Create_LogFile(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            this.StreamWriter = File.CreateText(path);
        }
        private void Start_Convert(object sender, EventArgs e)
        {
            if(this.CurrentVer == null)
            {

            }
            this.isProcessed = true;
            this.backgroundWorker.RunWorkerAsync();
            this.Create_LogFile(this.logFilePath);
            this.StartConvert.Enabled = false;
        }

        private void BathConversion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.isProcessed)
            {
                if (MessageBox.Show("文件正在处理当中，确定关闭?") == DialogResult.OK)
                {
                    this.backgroundWorker.CancelAsync();
                    this.StreamWriter.Close();
                    this.StreamWriter.Dispose();
                    this.isProcessed = false;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
        }
    }
}

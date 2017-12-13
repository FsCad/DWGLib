using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DWGLib.Class
{
    public class SearchFiles
    {
        public List<string> Files = new List<string>();
        public string RootPath = "";
        // get and seeter
        public int Depth { get; set; }
        public SearchFiles() { }
        public SearchFiles(string RootPath, int Depth)
        {
            this.RootPath = RootPath;
            this.Depth = Depth;
        }
        public void SearchFileByPrefix(string prefix, string rootPath)
        {
            if (!Directory.Exists(RootPath))
            {
                MessageBox.Show("选择的路径名称无效");
                return;
            }
            string[] strArr = Directory.GetDirectories(rootPath);
            string[] files = Directory.GetFiles(rootPath);
            List<string> _files = new List<string>() { };
            for (int i = 0; i < files.Length; i++)
            {
                if (Path.GetExtension(files[i]).ToLower() == prefix)
                {
                    _files.Add(files[i]);
                }
            }
            //递归终止条件
            this.Files.AddRange(_files);
            if (strArr.Length == 0) return;
            for (int i = 0; i < strArr.Length; i++)
            {
                SearchFileByPrefix(prefix, strArr[i]);
            }
        }
    }
}

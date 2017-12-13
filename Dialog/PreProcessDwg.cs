using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DWGLib.Dialog
{
    public partial class PreProcessDwg : Form
    {
        bool IsWhiteColorClick = false;
        bool IsBlackColorCLick = true;
        Color BgColor = Color.Black;
        public PreProcessDwg()
        {
            InitializeComponent();
        }

        private void WhiteColorClick(object sender, EventArgs e)
        {
            if (IsWhiteColorClick) return;

            this.WhiteColor.BorderStyle = BorderStyle.Fixed3D;
            this.BlackColor.BorderStyle = BorderStyle.FixedSingle;
            IsWhiteColorClick = true;
            IsBlackColorCLick = false;
            BgColor = Color.White;
        }

        private void BackColorClick(object sender, EventArgs e)
        {
            if (IsBlackColorCLick) return;

            this.BlackColor.BorderStyle = BorderStyle.Fixed3D;
            this.WhiteColor.BorderStyle = BorderStyle.FixedSingle;
            
            IsBlackColorCLick = true;
            IsWhiteColorClick = false;
            BgColor = Color.Black;
        }
    }
}

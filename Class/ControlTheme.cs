using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace DWGLib.Control.Theme
{
    public struct ControlTheme
    {
        //
        public Color ControlBgColor;
        Color FontColor;
        Color BorderColor;
        public ControlTheme(Color ControlBgColorItem, Color FontColorItem, Color BorderColorItem)
        {
            ControlBgColor = ControlBgColorItem;
            FontColor = FontColorItem;
            BorderColor = BorderColorItem;
        }
        public Color GetControlBgColor()
        {
            return this.ControlBgColor;
        }
        public Color GetFontColor()
        {
            return this.FontColor;
        }
        public Color GetBorderColor()
        {
            return this.BorderColor;
        }
    }
}

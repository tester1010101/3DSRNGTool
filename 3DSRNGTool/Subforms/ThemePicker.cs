using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pk3DSRNGTool.Controls;
using System.Windows.Forms;

namespace Pk3DSRNGTool.Subforms
{
    public partial class ThemePicker : Form
    {
        public ThemePicker()
        {
            InitializeComponent();
        }

        private void pfsChs() {
            if (checkBox1.Checked == true) {
                ThemeHelper.pfs = true;
            } 
        }

        public void button1_Click(object sender, EventArgs e)
        {
            pfsChs();
            ThemeHelper.pcs = comboBox1.SelectedIndex;
            ThemeHelper.fsp = trackBar1.Value;
            ThemeHelper.stc = false;
            //ThemeHelper.setChs(ThemeHelper.pfs, ThemeHelper.pcs, ThemeHelper.fsp);
            MessageBox.Show($"fsp: {ThemeHelper.fsp} || pcs: {ThemeHelper.pcs} || pfs: {ThemeHelper.pfs} || stc: {ThemeHelper.stc}");
        }
    }
}


/*

        public string[] colorCollec =
            {
                "YellowGreen",
                "AliceBlue",
                "AntiqueWhite",
                "Aqua",
                "Aquamarine",
                "Azure",
                "Beige",
                "Bisque",
                "Black",
                "BlanchedAlmond",
                "Blue",
                "BlueViolet",
                "Brown",
                "BurlyWood",
                "CadetBlue",
                "Chartreuse",
                "Chocolate",
                "Coral",
                "CornflowerBlue",
                "Cornsilk",
                "Crimson",
                "Cyan",
                "DarkBlue",
                "DarkCyan",
                "DarkGoldenrod",
                "DarkGray",
                "DarkGreen",
                "DarkKhaki",
                "DarkMagenta",
                "DarkOliveGreen",
                "DarkOrange",
                "DarkOrchid",
                "DarkRed",
                "DarkSalmon",
                "DarkSeaGreen",
                "DarkSlateBlue",
                "DarkSlateGray",
                "DarkTurquoise",
                "DarkViolet",
                "DeepPink",
                "DeepSkyBlue",
                "DimGray",
                "DodgerBlue",
                "Firebrick",
                "FloralWhite",
                "ForestGreen",
                "Fuchsia",
                "Gainsboro",
                "GhostWhite",
                "Gold",
                "Goldenrod",
                "Gray",
                "Green",
                "GreenYellow",
                "Honeydew",
                "HotPink",
                "IndianRed",
                "Indigo",
                "Ivory",
                "Khaki",
                "Lavender",
                "LavenderBlush",
                "LawnGreen",
                "LemonChiffon",
                "LightBlue",
                "LightCoral",
                "LightCyan",
                "LightGoldenrodYellow",
                "LightGray",
                "LightGreen",
                "LightPink",
                "LightSalmon",
                "LightSeaGreen",
                "LightSkyBlue",
                "LightSlateGray",
                "LightSteelBlue",
                "LightYellow",
                "Lime",
                "LimeGreen",
                "Linen",
                "Magenta",
                "Maroon",
                "MediumAquamarine",
                "MediumBlue",
                "MediumOrchid",
                "MediumPurple",
                "MediumSeaGreen",
                "MediumSlateBlue",
                "MediumSpringGreen",
                "MediumTurquoise",
                "MediumVioletRed",
                "MidnightBlue",
                "MintCream",
                "MistyRose",
                "Moccasin",
                "NavajoWhite",
                "Navy",
                "OldLace",
                "Olive",
                "OliveDrab",
                "Orange",
                "OrangeRed",
                "Orchid",
                "PaleGoldenrod",
                "PaleGreen",
                "PaleTurquoise",
                "PaleVioletRed",
                "PapayaWhip",
                "PeachPuff",
                "Peru",
                "Pink",
                "Plum",
                "PowderBlue",
                "Purple",
                "Red",
                "RosyBrown",
                "RoyalBlue",
                "SaddleBrown",
                "Salmon",
                "SandyBrown",
                "SeaGreen",
                "SeaShell",
                "Sienna",
                "Silver",
                "SkyBlue",
                "SlateBlue",
                "SlateGray",
                "Snow",
                "SpringGreen",
                "SteelBlue",
                "Tan",
                "Teal",
                "Thistle",
                "Tomato",
                "Transparent",
                "Turquoise",
                "Violet",
                "Wheat",
                "White",
                "WhiteSmoke",
                "Yellow"
            };


        public string[] colorCollec1 =
        {
                "Red",
                "Blue",
                "Yellow"
        };

        public string[] colorCollec2 =
        {
                "Gold",
                "Gray",
                "Cyan"
        };

        public string[] colorCollec3 =
        {
                "Blue",
                "Red",
                "Lime"
        };

        public string[] colorCollec4 =
        {
                "LightPink",
                "Gray"
        };

        public string[] colorCollec5 =
        {
                "WhiteSmoke",
                "Black"
        };

        public string[] colorCollec6 =
        {
                "Orange",
                "Purple"
        };

        public string[] colorCollec7 =
        {
                "LimeGreen",
                "AliceBlue",
                "Firebrick",
                "Violet",
                "Aquamarine",
                "Magenta",
                "Indigo",
                "Yellow"
        };


 */

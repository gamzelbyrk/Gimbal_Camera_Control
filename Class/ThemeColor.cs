using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimbal_Camera_Control
{
    public static class ThemeColor
    {
        public static List<string> ColorList = new List<string>()
        {

                                                                      "#AF7AB3",
                                                                      "#CBA0AE",
                                                                      "#94B49F",
                                                                      "#9DD6DF",
                                                                      "#A77979",
                                                                      "#377D71",
                                                                      "#A66CFF",
                                                                      "#EE6983",
                                                                      "#DF7861",
                                                                      "#97C4B8",
                                                                      "#7D1E6A",
                                                                      "#C37B89",
                                                                      "#BCCC9A",
                                                                      "#319DA0",
                                                                      "#256D85",
                                                                      "#F68989",
                                                                      "#C9BBCF",
                                                                      "#FFC4C4",
                                                                      "#B6FFCE",
                                                                      "#FF616D",
                                                                      "#66DE93",
                                                                      "#F9F871",
                                                                      "#E7FBBE",
                                                                      "#C37B89",
                                                                      "#B5CDA3",
                                                                      "#766161", 
                                                                      "#FFD5CD",
                                                                      "#FABEA7",
                                                                      "#E5CFE5",
                                                                      "#F1C6DE",
                                                                      "#8B76A5"



        };

        public static Color PrimaryColor { get; internal set; }
        public static Color SecondaryColor { get; internal set; }

        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            //If correction factor is less than 0, darken color.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //If correction factor is greater than zero, lighten color.

            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }

};



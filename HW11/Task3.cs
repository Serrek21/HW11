using System;

namespace HW11
{
    internal class Task3
    {
        public class RGBColor
        {
            public int Red { get; set; }
            public int Green { get; set; }
            public int Blue { get; set; }

            public RGBColor(int red, int green, int blue)
            {
                Red = red;
                Green = green;
                Blue = blue;
            }

            public string ToHex()
            {
                return "#" + Red.ToString("X2") + Green.ToString("X2") + Blue.ToString("X2");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;

namespace BMP_ASCII_NET_FRAMEWORK
{
    public static class Utilities
    {
        public static Color GetAveragePixel(this List<Color> pixels)
        {
            if (pixels == null)
                throw new ArgumentNullException();

            int r = 0;
            int g = 0;
            int b = 0;

            foreach (Color pixel in pixels)
            {
                r += pixel.R;
                g += pixel.G;
                b += pixel.B;
            }
            r /= pixels.Count;
            g /= pixels.Count;
            b /= pixels.Count;

            return Color.FromArgb(r, g, b);
        }

        public static int RoundDown(this int x) => (x & 1) != 0 && x != 0 ? --x : x;
    }
}

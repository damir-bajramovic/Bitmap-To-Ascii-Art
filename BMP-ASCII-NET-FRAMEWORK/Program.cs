using System.Collections.Generic;
using System.Drawing;

namespace BMP_ASCII_NET_FRAMEWORK
{
    class Program
    {
        static void Main(string[] args)
        {
            Bitmap bmp = new Bitmap(@"C:\Users\Public\test.bmp");
            int width = bmp.Width.RoundDown();
            int height = bmp.Height.RoundDown();

            PixelQuantizer quantizer = new PixelQuantizer();

            string result = "";

            for (int i = 0; i < height; i += 2)
            {
                for (int j = 0; j < width; j += 2)
                {
                    // Get the average of 4 surounding pixels
                    List<Color> pixels = new List<Color>();
                    pixels.Add(bmp.GetPixel(j, i));
                    pixels.Add(bmp.GetPixel(j + 1, i));
                    pixels.Add(bmp.GetPixel(j, i + 1));
                    pixels.Add(bmp.GetPixel(j + 1, i + 1));

                    result += quantizer.quantizePixel(pixels.GetAveragePixel());
                }

                result += "\n";
            }
            System.IO.File.WriteAllText(@"C:\Users\Public\ASCII_ART.txt", result);
        }
    }
}

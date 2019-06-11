using System.Drawing;

namespace BMP_ASCII_NET_FRAMEWORK
{
    public class PixelQuantizer
    { 
        private char[][][] MAP;

        public PixelQuantizer()
        {
            char start = '0';
            const int MAP_DIM = 4;
            MAP = new char[MAP_DIM][][];
            for (int i = 0; i < MAP_DIM; i++)
            {
                MAP[i] = new char[MAP_DIM][];
                for (int j = 0; j < MAP_DIM; ++j)
                {
                    MAP[i][j] = new char[MAP_DIM];
                    for (int k = 0; k < MAP_DIM; ++k)
                    {
                        MAP[i][j][k] = start++;
                    }
                }
            }
        }

        public char quantizePixel(Color pixel)
        {
            const int QUANT_SIZE = 64;
            int r = pixel.R / QUANT_SIZE; // 4
            int g = pixel.G / QUANT_SIZE; // 4
            int b = pixel.B / QUANT_SIZE; // 4

            return MAP[r][g][b];        }
    }
}

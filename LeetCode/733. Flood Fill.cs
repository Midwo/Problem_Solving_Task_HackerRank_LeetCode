using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_733
    {
        ////(733.) Flood Fill (EASY)
        private int _height;
        private int _width;
        public int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            _height = image.Length;
            _width = image[0].Length;

            if (image[sr][sc] != color)
            {
                Fill(image, sr, sc, image[sr][sc], color);
            }

            return image;
        }

        private void Fill(int[][] image, int sr, int sc, int previousColor, int newColor)
        {
            if (sr >= 0 && sc >= 0 && sr < _height && sc < _width)
            {
                if (image[sr][sc] == previousColor)
                {
                    image[sr][sc] = newColor;
                    Fill(image, sr + 1, sc, previousColor, newColor);
                    Fill(image, sr - 1, sc, previousColor, newColor);
                    Fill(image, sr, sc + 1, previousColor, newColor);
                    Fill(image, sr, sc - 1, previousColor, newColor);
                }
            }
        }
    }
}

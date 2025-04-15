using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_832
    {
        ////(832.) Flipping an Image (EASY)
        public int[][] FlipAndInvertImage(int[][] image)
        {
            int countRows = image.Length;
            int lenght = image[0].Length;

            for (int i = 0; i < lenght; i++)
            {
                for (int j = 0; j < lenght/2; j++)
                {
                    int temp = image[i][j];
                    image[i][j] = image[i][lenght-1-j];
                    image[i][lenght - 1 - j] = temp;
                }
                for (int j = 0; j < lenght; j++)
                {
                    if (image[i][j] == 0)
                    {
                        image[i][j] = 1;
                    }
                    else
                    {
                        image[i][j] = 0;
                    }
                }
            

            }
            return image;
        }
    }
}

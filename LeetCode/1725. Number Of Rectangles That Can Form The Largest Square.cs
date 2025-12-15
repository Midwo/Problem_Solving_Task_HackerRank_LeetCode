using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1725
    {
        ////(1725.) Number Of Rectangles That Can Form The Largest Square (EASY)
        public int CountGoodRectangles(int[][] rectangles)
        {
            int countGoodRectagles = 0;
            int maxLenght = 0;

            for (int i = 0; i < rectangles.Length; i++)
            {
                int currMin = rectangles[i][0];
                for (int j = 1; j < rectangles[i].Length; j++)
                {
                    currMin = currMin > rectangles[i][j]? rectangles[i][j]: currMin;
                }
                if(maxLenght < currMin)
                {
                    maxLenght = currMin;
                    countGoodRectagles = 1;
                }
                else if (maxLenght == currMin)
                {
                    countGoodRectagles++;
                }
            }

            return countGoodRectagles;
        }
    }
}

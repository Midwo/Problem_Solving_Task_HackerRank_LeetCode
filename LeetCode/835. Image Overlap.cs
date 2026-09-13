using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_835
    {
        ////(835.) Image Overlap (MEDIUM)
        public int LargestOverlap(int[][] img1, int[][] img2)
        {
            int maxCountOverlap = 0;
            int height = img2.Length;
            int width = img2[0].Length;

            for (int indexHeight = 0; indexHeight < height; indexHeight++)
            {
                for (int indexWidth = 0; indexWidth < width; indexWidth++)
                {
                    for (int startY = 0; startY < height; startY++)
                    {
                        for (int startX = 0; startX < width; startX++)
                        {
                            int count = 0;

                            for (int currIndexHeight = indexHeight; currIndexHeight < height; currIndexHeight++)
                            {
                                for (int currIndexWidth = indexWidth; currIndexWidth < width; currIndexWidth++)
                                {
                                    if (currIndexHeight + startY >= 0 && currIndexHeight + startY < height && currIndexWidth + startX >= 0 && currIndexWidth + startX < width)
                                    {
                                        if (img2[currIndexHeight][currIndexWidth] == 1 && img1[startY + currIndexHeight-indexHeight][startX + currIndexWidth-indexWidth] == 1)
                                            count++;
                                    }
                                }
                            }

                            maxCountOverlap = Math.Max(maxCountOverlap, count);
                        }
                    }
                }
            }

            return maxCountOverlap;
        }
    }
}


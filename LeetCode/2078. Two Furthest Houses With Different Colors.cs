using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2078
    {
        ////(2078.) Two Furthest Houses With Different Colors (EASY)
        public int MaxDistance(int[] colors)
        {
            int length = colors.Length;
            int lastColor = colors[length - 1];
            int firstColor = colors[0];

            for (int i = 0; i < length; i++)
            {
                if (colors[i] != lastColor)
                {
                    return length - i - 1;
                }
                if (colors[length-i-1] != firstColor)
                {
                    return length - i - 1;
                }
            }

            return 1;
        }
    }
}

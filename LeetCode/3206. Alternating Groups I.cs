using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3206
    {
        ////(3206.) Alternating Groups I (EASY)
        public int NumberOfAlternatingGroups(int[] colors)
        {
            int countAlternatingGroups = 0;
            int lastColor = colors[colors.Length-2];
            int middleColor = colors[colors.Length-1];
            int nextColor;

            for (int i = 0; i < colors.Length; i++) 
            {
                nextColor = colors[i];
                if (lastColor == nextColor && lastColor != middleColor)
                {
                    countAlternatingGroups++;
                }
                lastColor = middleColor;
                middleColor = nextColor;
            }

            return countAlternatingGroups;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_806
    {
        ////(806.) Number of Lines To Write String (EASY)
        public int[] NumberOfLines(int[] widths, string s)
        {
            int rows = 1;
            int pixels = 0;

            foreach (char item in s)
            {
                //Console.WriteLine(s[i] - 97);
                //Console.WriteLine(widths[s[i] - 97]);
                int currpixel = widths[item - 97];
                pixels += widths[item - 97];
                if (pixels > 100)
                {
                    rows++;
                    pixels = currpixel;
                }
            }

            return new int[] { rows, pixels };
        }
    }
}



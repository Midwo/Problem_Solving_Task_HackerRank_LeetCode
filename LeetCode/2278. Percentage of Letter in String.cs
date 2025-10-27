using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2278
    {
        ////(2278.) Percentage of Letter in String (EASY)
        public int PercentageLetter(string s, char letter)
        {
            ////0ms, Beats: 100.00%
            
            int count = 0;
            int length = s.Length;

            for (int i = 0; i < length; i++) 
            { 
                if (s[i] == letter)
                {
                    count++;
                }
            }

            return count*100 / length;
        }
    }
}

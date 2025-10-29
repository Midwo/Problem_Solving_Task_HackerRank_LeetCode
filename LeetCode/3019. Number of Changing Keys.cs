using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3019
    {
        ////(3019.) Number of Changing Keys (EASY)
        public int CountKeyChanges(string s)
        {
            ////0ms, Beats: 100.00%
            int count = 0;
            int first = s[0];
            int second = -1;

            if (first < 97)
            {
                first += 32;
            }

            for (int i = 1; i < s.Length; i++)
            {
                second = s[i];
                if (second < 97)
                {
                    second += 32;
                } 

                if(second != first)
                {
                    count++;
                }

                first = second;
            }

            return count;
        }
    }
}

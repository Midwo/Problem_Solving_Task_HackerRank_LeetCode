using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1422
    {
        ////(1422.) Maximum Score After Splitting a String (EASY)
        public int MaxScore(string s)
        {
            int count0 = 0;
            int count1 = 0;
            int maxScore = 0;
            int lenght = s.Length;

            for (int i = 0; i < lenght; i++)
            {
                if (s[i] == '1')
                {
                    count1++;
                }
            }

            for (int i = 0; i < lenght-1; i++)
            {
                if (s[i] == '0')
                {
                    count0++;
                }
                else
                {
                    count1--;
                }
                maxScore = maxScore < count0 + count1 ? count0 + count1 : maxScore;
            }

            return maxScore;                       
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1945
    {
        ////(1945.) Sum of Digits of String After Convert (EASY)
        public int GetLucky(string s, int k)
        {
            StringBuilder sb = new StringBuilder();

            for (int indexS = 0; indexS < s.Length; indexS++)
            {
                sb.Append(s[indexS] - 96);
            }

            int currSumValue = 0;

            for (int indexTransform = 0; indexTransform < k; indexTransform++)
            {
                currSumValue = 0;
                for (int indexSb = 0; indexSb < sb.Length; indexSb++)
                {
                    currSumValue += sb[indexSb] - '0';
                }
                sb = new StringBuilder(currSumValue.ToString());
                if (sb.Length == 1)
                {
                    return currSumValue;
                }
            }
            return currSumValue;
        }
    }
}

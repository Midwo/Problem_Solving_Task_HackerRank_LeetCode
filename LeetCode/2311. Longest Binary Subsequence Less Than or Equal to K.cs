using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2311
    {
        ////(2311.) Longest Binary Subsequence Less Than or Equal to K (MEDIUM)
        public int LongestSubsequence(string s, int k)
        {
            int pow = 1;
            int result = 0;
            int lengthString = s.Length;
            int currValue = 0;

            for (int i = lengthString - 1; i >= 0; i--)
            {
                if (currValue + pow <= k)
                {
                    if (s[i] == '1')
                    {
                        result++;
                        currValue += pow;
                    }
                    else
                    {
                        result++;
                    }
                  
                    pow *= 2;
                }
                else if (s[i] == '0')
                {
                    result++;
                }
                
            }

            return result;

            ////OR option 2:

            //int pow = 1;
            //int maxOnelength = 0;
            //int lengthString = s.Length;
            //int currValue = 0;

            //for (int i = lengthString - 1; i >= 0 && currValue + pow <= k; i--)
            //{
            //    if (s[i] == '1')
            //    {
            //        maxOnelength++;
            //        currValue += pow;
            //    }
            //    pow *= 2;
            //}

            //return s.Count(c => c == '0') + maxOnelength;
        }
    }
}

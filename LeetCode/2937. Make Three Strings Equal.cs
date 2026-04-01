using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2937
    {
        ////(2937.) Make Three Strings Equal (EASY)
        public int FindMinimumOperations(string s1, string s2, string s3)
        {
            int lengthS3 = s3.Length;
            int lengthS1 = s1.Length;
            int lengthS2 = s2.Length;

            int minLength = Math.Min(lengthS1, Math.Min(lengthS2, lengthS3));

            int lastCorrectIndex = 0;
            for (; lastCorrectIndex < minLength; lastCorrectIndex++)
            {
                if (s3[lastCorrectIndex] != s1[lastCorrectIndex] || s3[lastCorrectIndex] != s2[lastCorrectIndex])
                {
                    break;
                }
            }

            if(lastCorrectIndex == 0)
            {
                return -1;
            }

            return lengthS1 - lastCorrectIndex + lengthS2 - lastCorrectIndex + lengthS3 - lastCorrectIndex;
        }
    }
}

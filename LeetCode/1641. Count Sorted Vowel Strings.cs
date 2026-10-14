using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1641
    {
        ////(1641.) Count Sorted Vowel Strings (MEDIUM)
        public int CountVowelStrings(int n)
        {
            int[] count = new int[5] {1,1,1,1,1};

            for (int i = 1; i < n; i++) 
            {
                count[0] = count[0] + count[1] + count[2] + count[3] + count[4];
                count[1] = count[1] + count[2] + count[3] + count[4];
                count[2] = count[2] + count[3] + count[4];
                count[3] = count[3] + count[4];
            }

            return count.Sum();
        }
    }
}
